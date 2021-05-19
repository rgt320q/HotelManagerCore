using Core.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Room:IEntity
    {
        //public Room()
        //{
        //    Reservations = new Collection<Reservation>();
        //}

        public int RoomId { get; set; }
        public bool Active { get; set; } = true;

        [StringLength(50)]
        public string Name { get; set; }
        public bool Dirty { get; set; }

        [StringLength(150)]
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

        virtual public IEnumerable<Reservation> Reservations { get; set; }
    }
}
