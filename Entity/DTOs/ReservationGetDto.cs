using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.DTOs
{
    public class ReservationGetDto
    {
        public ReservationGetDto()
        {
            //this.Rooms = new List<RoomDto>();
            //this.Guests = new Collection<GuestDto>();
        }
        public int ReservationId { get; set; }

        [Required]
        public bool Active { get; set; } = true;

        [DisplayName("Reservation Status"), Range(0, 3)]
        public string Status { get; set; }

        [DisplayName("Accommodation Type"), Range(0, 1)]
        public string AccommodationType { get; set; }

        [DisplayName("Board Type"), Range(0, 3)]
        public string BoardType { get; set; }

        [DisplayName("Arrival Date"), DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        [DisplayName("Departure Date"), DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [DisplayName("Total Accommodation Day."), Range(1, 30)]
        public byte Days { get; set; }

        [DisplayName("Children Without Fee Count"), Range(0, 30)]
        public byte Children { get; set; }

        [DisplayName("Children With Fee Count"), Range(0, 30)]
        public byte ChildrenWithFee { get; set; }

        [DisplayName("Adult Count"), Range(1, 30)]
        public byte Adult { get; set; }

        [DisplayName("Guest Total"), Range(1, 90)]
        public byte GuestTotal { get; set; }

        [DisplayName("Guest Capacity"), Range(0, 90)]
        public byte GuestCapacity { get; set; }

        [DisplayName("Reservation Note"), StringLength(150)]
        public string ReservationNote { get; set; }

        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }

        public PaymentDto Payment { get; set; }
        public List<RoomDto> Rooms { get; set; }
        public List<GuestDto> Guests { get; set; }
    }
}



