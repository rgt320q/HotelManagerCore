using System;
using System.Collections.Generic;

namespace Entity.Concrete
{
    public class Room
    {
        public int Id { get; set; }
        public bool Active { get; set; } = true;
        public string Name { get; set; }
        public bool Dirty { get; set; }
        public string Description { get; set; }
        public byte PersonTotal { get; set; }
        public byte DoubleBed { get; set; }
        public byte SingleBed { get; set; }
        public decimal Price1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Price3 { get; set; }
        public decimal? Price4 { get; set; }
        public DateTime InsertDateTime { get; set; } = DateTime.Now;
        public DateTime UpdateDateTime { get; set; } = DateTime.Now;

        public ICollection<Reservation> Reservations { get; set; }
    }
}
