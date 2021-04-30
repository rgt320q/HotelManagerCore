﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Reservation:IEntity
    {
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
        public DateTime ArrivalDate { get; set; }

        [DisplayName("Departure Date")]
        public DateTime DepartureDate { get; set; }

        [Range(1, 30)]
        public byte Days { get; set; } = 1;

        [Range(0, 30)]
        public byte Children { get; set; } = 0;

        [DisplayName("Children With Fee"), Range(0, 30)]
        public byte ChildrenWithFee { get; set; } = 0;

        [Range(1, 30)]
        public byte Adult { get; set; } = 1;

        [Range(1, 90)]
        [DisplayName("Guest Total")]
        public byte GuestTotal { get; set; } = 1;

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
