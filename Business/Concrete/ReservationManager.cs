using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;
        IBaseConfigurationDal _baseConfigurationDal;
        IRoomDal _roomDal;
        IGuestDal _guestDal;

        public ReservationManager(
            IReservationDal reservationDal,
            IBaseConfigurationDal baseConfigurationDal,
            IRoomDal roomDal,
            IGuestDal guestDal)
        {
            _reservationDal = reservationDal;
            _baseConfigurationDal = baseConfigurationDal;
            _roomDal = roomDal;
            _guestDal = guestDal;
        }

        public IResult Add(Reservation reservation)
        {
            var baseConfiguration = _baseConfigurationDal.GetLastOrDefault(i => i.BaseConfigurationId);

            //If the "GuestId" entered but the Id doesn't exist in the "guests" table.
            //It going to add the entity to the "guests" table.
            CheckGuestExistAccordingId(reservation);


            GuestCapacityCalculation(reservation);
            GuestTotalCalculation(reservation);
            TotalDaysCalculation(reservation);
            DailyPricesCalculation(reservation, baseConfiguration);

            //For Room
            if (reservation.AccommodationType == 0) PaymentCalculationForRoom(reservation);

            //For Person
            if (reservation.AccommodationType == 1) PaymentCalculationForPerson(reservation);

            BoardTypeConfiguration(reservation);

            TaxesCalculation(reservation, baseConfiguration);
            _reservationDal.Attach(reservation);

            return new SuccessResult("Reservation successfully added.");
        }

       

        public IDataResult<Reservation> Get(Expression<Func<Reservation, bool>> filter)
        {
            return new SuccessDataResult<Reservation>(_reservationDal.Get(filter));
        }

        public IDataResult<List<Reservation>> GetAll()
        {
            return new SuccessDataResult<List<Reservation>>(_reservationDal.GetAll());
        }

        public IDataResult<Reservation> GetOneInclude(Expression<Func<Reservation, object>> include, Expression<Func<Reservation, bool>> filter)
        {
            return new SuccessDataResult<Reservation>(_reservationDal.GetOneInclude(include, filter));
        }

        public IDataResult<Reservation> GetTwoIncludes(
            Expression<Func<Reservation, object>> includeOne,
            Expression<Func<Reservation, object>> includeTwo,
            Expression<Func<Reservation, bool>> filter)
        {
            return new SuccessDataResult<Reservation>(_reservationDal.GetTwoInclude(includeOne, includeTwo, filter));
        }

        public IDataResult<Reservation> GetThreeIncludes(
            Expression<Func<Reservation, object>> includeOne,
            Expression<Func<Reservation, object>> includeTwo,
            Expression<Func<Reservation, object>> includeThree,
            Expression<Func<Reservation, bool>> filter)
        {
            return new SuccessDataResult<Reservation>(_reservationDal.GetThreeInclude(includeOne, includeTwo, includeThree, filter));
        }






        ///////////////////// Helper Methots ////////////////////

        /// <summary>
        /// It calculates taxes and fills payment fields from incoming the reservation entity.
        /// </summary>
        /// <param name="reservation">Incoming Reservation entity from the (API or another) interface.</param>
        /// <param name="baseConfiguration">Found last base configuration.</param>
        private static void TaxesCalculation(Reservation reservation, BaseConfiguration baseConfiguration)
        {
            reservation.Payment.TotalKdv = reservation.Payment.TotalPrice * (baseConfiguration.TaxRateForKDV / 100);
            reservation.Payment.TotalAccommodationTax = reservation.Payment.TotalPrice * (baseConfiguration.TaxRateForAccommodation / 100);
        }

        /// <summary>
        /// It calculates daily total prices and fills payment fields from incoming the reservation entity.
        /// </summary>
        /// <param name="reservation">Incoming Reservation entity from the (API or another) interface.</param>
        /// <param name="baseConfiguration">Must be last base configuration.</param>
        /// /// <param name="totalRoomPrice">The prices of the selected rooms.</param>
        private void DailyPricesCalculation(Reservation reservation, BaseConfiguration baseConfiguration)
        {
            decimal totalRoomPrice = 0.0m;
            foreach (var roomInModel in reservation.Rooms)
            {
                var roomInDb = _roomDal.Get(i => i.RoomId == roomInModel.RoomId);
                totalRoomPrice += roomInDb.Price1;
            }

            reservation.Payment.DailyAdultPrice = baseConfiguration.DailyAdultPrice;
            reservation.Payment.DailyChildPrice = baseConfiguration.DailyChildPrice;
            reservation.Payment.DailyAccommodationPrice = baseConfiguration.AccommodationPrice;
            reservation.Payment.DailyBreakfastPrice = baseConfiguration.BreakfastPrice;
            reservation.Payment.DailyLunchPrice = baseConfiguration.LunchPrice;
            reservation.Payment.DailyDinnerPrice = baseConfiguration.DinnerPrice;

            reservation.Payment.TotalDailyAdultPrice = reservation.Payment.DailyAdultPrice * reservation.Adult;
            reservation.Payment.TotalDailyChildPrice = reservation.Payment.DailyChildPrice * reservation.ChildrenWithFee;
            reservation.Payment.TotalDailyAccommodationPrice = reservation.Payment.DailyAccommodationPrice;
            reservation.Payment.TotalDailyBreakfastPrice = reservation.Payment.DailyBreakfastPrice * reservation.GuestTotal;
            reservation.Payment.TotalDailyLunchPrice = reservation.Payment.DailyLunchPrice * reservation.GuestTotal;
            reservation.Payment.TotalDailyDinnerPrice = reservation.Payment.DailyDinnerPrice * reservation.GuestTotal;
            reservation.Payment.TotalDailyRoomPrice = totalRoomPrice;

            reservation.Payment.TotalAdultPrice = reservation.Payment.DailyAdultPrice * reservation.Adult * reservation.Days;
            reservation.Payment.TotalChildPrice = reservation.Payment.DailyChildPrice * reservation.ChildrenWithFee * reservation.Days;
            reservation.Payment.TotalAccommodationPrice = reservation.Payment.DailyAccommodationPrice * reservation.Days;
            reservation.Payment.TotalBreakfastPrice = reservation.Payment.DailyBreakfastPrice * reservation.GuestTotal * reservation.Days;
            reservation.Payment.TotalLunchPrice = reservation.Payment.DailyLunchPrice * reservation.GuestTotal * reservation.Days;
            reservation.Payment.TotalDinnerPrice = reservation.Payment.DailyDinnerPrice * reservation.GuestTotal * reservation.Days;
            reservation.Payment.TotalRoomPrice = totalRoomPrice * reservation.Days;

        }

        /// <summary>
        /// It fills the total price from the incoming payment entity that according to the person count.
        /// </summary>
        /// <param name="reservation">Incoming Reservation entity from the (API or another) interface.</param>
        private void PaymentCalculationForPerson(Reservation reservation)
        {
            reservation.Payment.TotalPrice = (reservation.Payment.TotalDailyAdultPrice + reservation.Payment.TotalDailyChildPrice) + reservation.Payment.TheExtrasPrice - reservation.Payment.DiscountPrice;
        }

        /// <summary>
        /// It fills the total price from the incoming payment entity that according to the room count.
        /// </summary>
        /// <param name="reservation">Incoming Reservation entity from the (API or another) interface.</param>
        private void PaymentCalculationForRoom(Reservation reservation)
        {
            reservation.Payment.TotalPrice = reservation.Payment.TotalDailyRoomPrice + reservation.Payment.TheExtrasPrice - reservation.Payment.DiscountPrice;
        }

        /// <summary>
        /// It subtracts the departure date from the arrival date and fills TotalDays.
        /// </summary>
        /// <param name="reservation">Incoming Reservation entity from the (API or another) interface.</param>
        private void TotalDaysCalculation(Reservation reservation)
        {
            reservation.Days = Convert.ToByte(reservation.DepartureDate.Subtract(reservation.ArrivalDate).Days);
        }

        /// <summary>
        /// It calculates total guest and fills GuestTotal
        /// </summary>
        /// <param name="reservation">Incoming Reservation entity from the (API or another) interface.</param>
        private void GuestTotalCalculation(Reservation reservation)
        {
            reservation.GuestTotal = Convert.ToByte(reservation.Adult + reservation.Children + reservation.ChildrenWithFee);
        }

        /// <summary>
        /// It checks that is there exists in DB sending the guest id.
        /// </summary>
        /// <param name="reservation">Incoming Reservation entity from the (API or another) interface.</param>
        private void CheckGuestExistAccordingId(Reservation reservation)
        {
            foreach (var item in reservation.Guests)
            {
                var isGuestExist = _guestDal.Get(g => g.GuestId == item.GuestId);
                if (isGuestExist == null) item.GuestId = 0;
            }
        }

        /// <summary>
        /// It calculates the total guest capacity for reservation according to the selected rooms.
        /// </summary>
        /// <param name="reservation">Incoming Reservation entity from the (API or another) interface.</param>
        private void GuestCapacityCalculation(Reservation reservation)
        {
            try
            {
                reservation.GuestCapacity = 0;
                foreach (var roomInModel in reservation.Rooms)
                {
                    var roomInDb = _roomDal.Get(i => i.RoomId == roomInModel.RoomId);
                    reservation.GuestCapacity += roomInDb.PersonTotal;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// It make selection confiration according boardtype. For example: if board type BB => Breakfast = true others false.
        /// Board type = 0 is Bed And Breakfast (BB)
        /// Board type = 1 is Half Board (HB)
        /// Board type = 2 is Full Board (FB)
        /// Board type = 3 is All Inclusive (AI)
        /// </summary>
        /// <param name="reservation">Incoming Reservation entity from the (API or another) interface.</param>
        private static void BoardTypeConfiguration(Reservation reservation)
        {            
            if (reservation.BoardType == 0)
            {
                reservation.Breakfast = true;
                reservation.Lunch = false;
                reservation.Dinner = false;
                reservation.Payment.DailyBreakfastPrice = 0;
                reservation.Payment.TotalDailyBreakfastPrice = 0;
                reservation.Payment.TotalBreakfastPrice = 0;
            }

            if (reservation.BoardType == 1)
            {
                reservation.Breakfast = true;
                reservation.Lunch = false;
                reservation.Dinner = true;
                reservation.Payment.DailyBreakfastPrice = 0;
                reservation.Payment.TotalDailyBreakfastPrice = 0;
                reservation.Payment.TotalBreakfastPrice = 0;
                reservation.Payment.DailyDinnerPrice = 0;
                reservation.Payment.TotalDailyDinnerPrice = 0;
                reservation.Payment.TotalDinnerPrice = 0;
            }

            if (reservation.BoardType == 2)
            {
                reservation.Breakfast = true;
                reservation.Lunch = true;
                reservation.Dinner = true;
                reservation.Payment.DailyBreakfastPrice = 0;
                reservation.Payment.TotalDailyBreakfastPrice = 0;
                reservation.Payment.TotalBreakfastPrice = 0;
                reservation.Payment.DailyDinnerPrice = 0;
                reservation.Payment.TotalDailyDinnerPrice = 0;
                reservation.Payment.TotalDinnerPrice = 0;
                reservation.Payment.DailyLunchPrice = 0;
                reservation.Payment.TotalDailyLunchPrice = 0;
                reservation.Payment.TotalLunchPrice = 0;
            }

            if (reservation.BoardType == 3)
            {
                reservation.Breakfast = true;
                reservation.Lunch = true;
                reservation.Dinner = true;
                reservation.Payment.DailyBreakfastPrice = 0;
                reservation.Payment.TotalDailyBreakfastPrice = 0;
                reservation.Payment.TotalBreakfastPrice = 0;
                reservation.Payment.DailyDinnerPrice = 0;
                reservation.Payment.TotalDailyDinnerPrice = 0;
                reservation.Payment.TotalDinnerPrice = 0;
                reservation.Payment.DailyLunchPrice = 0;
                reservation.Payment.TotalDailyLunchPrice = 0;
                reservation.Payment.TotalLunchPrice = 0;
            }
        }
    }
}
