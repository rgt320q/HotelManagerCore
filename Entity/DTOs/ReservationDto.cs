using System;

namespace Entity.DTOs
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public bool Active { get; set; } = true;
        public byte Status { get; set; } = 1;
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public byte Days { get; set; }
        public byte Children { get; set; }
        public byte ChildrenWithFee { get; set; }
        public byte Adult { get; set; }
        public byte GuestTotal { get; set; }
        public byte GuestCapacity { get; set; }
        public string ReservationNote { get; set; }
        public byte AccommodationType { get; set; }
        public byte? BoardType { get; set; }
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }

        public enum AccommodationTypeEnum
        {
            Room = 0,
            Person = 1
        }

        public enum BoardTypeEnum
        {
            BB = 0,
            HB = 1,
            FB = 2,
            AI = 3
        }

        public enum StatusEnum
        {
            Reservation = 1,
            CheckIn = 2,
            CheckOut = 3,
            Canceled = 4
        }
    }
}



