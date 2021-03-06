using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    [Index(nameof(ArrivalDate))]
    public class Reservation : IEntity
    {
        public int ReservationId { get; set; }

        [Required]
        public bool Active { get; set; } = true;

        [DisplayName("Reservation Status"), Range(0, 3)]
        public byte Status { get; set; }

        [DisplayName("Accommodation Type"), Range(0, 1)]
        public byte AccommodationType { get; set; }

        [DisplayName("Board Type"), Range(0, 3)]
        public byte? BoardType { get; set; }

        [DisplayName("Arrival Date"), DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        [DisplayName("Departure Date"), DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [DisplayName("Total Accommodation Day."), Range(1, 30)]
        public byte Days { get; set; } = 1;

        [DisplayName("Children Without Fee Count"), Range(0, 30)]
        public byte Children { get; set; } = 0;

        [DisplayName("Children With Fee Count"), Range(0, 30)]
        public byte ChildrenWithFee { get; set; } = 0;

        [DisplayName("Adult Count"), Range(1, 30)]
        public byte Adult { get; set; } = 1;

        [DisplayName("Guest Total"), Range(1, 90)]
        public byte GuestTotal { get; set; } = 1;

        [DisplayName("Guest Capacity"), Range(0, 90)]
        public byte GuestCapacity { get; set; }

        [DisplayName("Reservation Note"), StringLength(150)]
        public string ReservationNote { get; set; }

        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }

        [StringLength(150)]
        public string InvoiceFileName { get; set; }

        [DisplayName("Insert Date Time")]
        public DateTime InsertDateTime { get; set; } = DateTime.Now;

        [DisplayName("Update Date Time")]
        public DateTime UpdateDateTime { get; set; } = DateTime.Now;

        public int PaymentId { get; set; }

        virtual public Payment Payment { get; set; }
        virtual public IEnumerable<Room> Rooms { get; set; }
        virtual public IEnumerable<Guest> Guests { get; set; }

    }
}
