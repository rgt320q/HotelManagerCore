using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Reservation
    {
        private DateTime _arrivalDate;
        private DateTime _departureDate;
        private byte _dayTotal;
        private byte _guestTotal;

        public Reservation()
        {
            //For null exeption error
            this.Rooms = new HashSet<Room>();
            this.Guests = new HashSet<Guest>();
            this.Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        [Required]
        public bool Active { get; set; } = true;

        [DisplayName("Arrival Date")]
        public DateTime ArrivalDate
        {
            get { return _arrivalDate; }
            set { _arrivalDate = value; }
        }

        [DisplayName("Departure Date")]
        public DateTime DepartureDate
        {
            get { return _departureDate; }
            set { _departureDate = value; }
        }

        [Range(1, 30)]
        public byte Days
        {
            get { return _dayTotal; }
            set { _dayTotal = Convert.ToByte(_departureDate.Subtract(_arrivalDate).Days); }
        }

        [Range(0, 30)]
        public byte Children { get; set; }
        [DisplayName("Children With Fee"), Range(0, 30)]
        public byte ChildrenWithFee { get; set; } = 0;
        [Range(1, 30)]
        public byte Adult { get; set; } = 1;
        [Range(1, 90)]
        [DisplayName("Guest Total")]
        public byte GuestTotal
        {
            get { return _guestTotal; }
            set
            {
                if (value!=1)
                {
                    _guestTotal = Convert.ToByte(Adult + Children + ChildrenWithFee);
                }

                _guestTotal = 1;
            }
        }

        [DisplayName("Reservation Note")]
        public string ReservationNote { get; set; }
        [DisplayName("Accommodation Type")]
        public byte AccommodationType { get; set; }
        [DisplayName("Board Type")]
        public byte? BoardType { get; set; }
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }
        public string InvoiceFileName { get; set; }
        [DisplayName("Insert Date Time")]
        public DateTime InsertDateTime { get; set; } = DateTime.Now;
        [DisplayName("Update Date Time")]
        public DateTime UpdateDateTime { get; set; } = DateTime.Now;

        public ICollection<Room> Rooms { get; set; }
        public ICollection<Guest> Guests { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
