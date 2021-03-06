using Core.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Payment : IEntity
    {
        //public Payment()
        //{
        //    this.PaidFees = new Collection<PaidFee>();
        //}

        public int PaymentId { get; set; }
        public bool Active { get; set; } = true;

        [DisplayName("Total Price"), DataType(DataType.Currency), Range(0.00, 100000.00)]
        public decimal TotalPrice { get; set; }

        public bool IsThePaymentComplete { get; set; } = false;

        [DisplayName("Total KDV"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalKdv { get; set; }

        [DisplayName("Total Accommodation Tax"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalAccommodationTax { get; set; }

        [DisplayName("The Extras Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TheExtrasPrice { get; set; }

        [DisplayName("Discount Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal DiscountPrice { get; set; }

        //Daily prices.
        [DisplayName("Daily Adult Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal DailyAdultPrice { get; set; }

        [DisplayName("Daily Child Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal DailyChildPrice { get; set; }

        [DisplayName("Daily Accommodation Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal DailyAccommodationPrice { get; set; }

        [DisplayName("Daily Breakfast Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal DailyBreakfastPrice { get; set; }

        [DisplayName("Daily Lunch Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal DailyLunchPrice { get; set; }

        [DisplayName("Daily Dinner Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal DailyDinnerPrice { get; set; }

        //Total daily prices.
        [DisplayName("Total Daily Adult Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalDailyAdultPrice { get; set; }

        [DisplayName("Total Daily Child Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalDailyChildPrice { get; set; }

        [DisplayName("Total Daily Room Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalDailyRoomPrice { get; set; }

        [DisplayName("Daily Accommodation Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalDailyAccommodationPrice { get; set; }

        [DisplayName("Daily Breakfast Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalDailyBreakfastPrice { get; set; }

        [DisplayName("Daily Lunch Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalDailyLunchPrice { get; set; }

        [DisplayName("Daily Dinner Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalDailyDinnerPrice { get; set; }

        //Total prices
        [DisplayName("Total Adult Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalAdultPrice { get; set; }

        [DisplayName("Total Child Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalChildPrice { get; set; }

        [DisplayName("Total Room Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalRoomPrice { get; set; }

        [DisplayName("Total Accommodation Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalAccommodationPrice { get; set; }

        [DisplayName("Total Break Fast Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalBreakfastPrice { get; set; }

        [DisplayName("Total Lunch Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalLunchPrice { get; set; }

        [DisplayName("Total Dinner Price"), DataType(DataType.Currency), Range(0.00, 10000.00)]
        public decimal TotalDinnerPrice { get; set; }

        //Informations
        [DisplayName("Insert Date Time")]
        public DateTime InsertDateTime { get; set; } = DateTime.Now;

        [DisplayName("Update Date Time")]
        public DateTime? UpdateDateTime { get; set; } = DateTime.Now;

        virtual public IEnumerable<PaidFee> PaidFees { get; set; }

    }
}
