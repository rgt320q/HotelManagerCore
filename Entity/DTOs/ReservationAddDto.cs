using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class ReservationAddDto
    {
        public ReservationGetDto ReservationDto { get; set; }
        public GuestDto GuestDto { get; set; }
        public RoomDto RoomDto { get; set; }
        public PaymentDto PaymentDto { get; set; }

    }
}
