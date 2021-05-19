using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    [Index(nameof(IdentNumber), IsUnique = true)]
    public class Guest : IEntity
    {
        [Key]
        public int GuestId { get; set; }

        public bool Active { get; set; } = true;

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        [Required, Phone, DataType(DataType.PhoneNumber), StringLength(15)]
        public string Phone { get; set; }

        [EmailAddress, DataType(DataType.EmailAddress), StringLength(80)]
        public string Email { get; set; }

        [DisplayName("Ident Number"), Required, MinLength(11), MaxLength(11)]
        public string IdentNumber { get; set; }

        [Required, Range(0, 1)]
        public byte Gender { get; set; }

        [DisplayName("Birth Day"), DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }

        [DisplayName("Father Name"), StringLength(50)]
        public string FatherName { get; set; }

        [DisplayName("Mother Name"), StringLength(50)]
        public string MotherName { get; set; }

        [DisplayName("Martial Status"), Range(0, 4)]
        public byte MartialStatus { get; set; }

        [DisplayName("Ident Serial No"), StringLength(50)]
        public string IdentSerialNo { get; set; }

        [DisplayName("Car Plate"), StringLength(12)]
        public string CarPlate { get; set; }

        [DisplayName("Guest Note"), StringLength(150)]
        public string GuestNote { get; set; }

        [DisplayName("Insert Date Time")]
        public DateTime InsertDateTime { get; set; } = DateTime.Now;

        [DisplayName("Update Date Time")]
        public DateTime UpdateDateTime { get; set; } = DateTime.Now;

        virtual public IEnumerable<Reservation> Reservations { get; set; }
    }
}
