using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Guest:IEntity
    {
        [Key]
        public int GuestId { get; set; }

        public bool Active { get; set; } = true;

        [DisplayName("Type Of Guest")]
        public int TypeOfGuest { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        //[Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        [DisplayName("Ident Number")]
        public string IdentNumber { get; set; }

        [Required]
        public int Gender { get; set; }

        [DisplayName("Birth Day")]
        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        [DisplayName("Father Name")]
        public string FatherName { get; set; }

        [StringLength(50)]
        [DisplayName("Mother Name")]
        public string MotherName { get; set; }

        [StringLength(50)]
        [DisplayName("Martial Status")]
        public string MartialStatus { get; set; }

        [StringLength(50)]
        [DisplayName("Ident Type")]
        public string IdentType { get; set; }

        [StringLength(50)]
        [DisplayName("Ident Serial No")]
        public string IdentSerialNo { get; set; }

        [StringLength(12)]
        [DisplayName("Car Plate")]
        public string CarPlate { get; set; }

        [StringLength(150)]
        [DisplayName("Guest Note")]
        public string GuestNote { get; set; }

        [DisplayName("Insert Date Time")]
        public DateTime InsertDateTime { get; set; } = DateTime.Now;

        [DisplayName("Update Date Time")]
        public DateTime UpdateDateTime { get; set; } = DateTime.Now;

        public ICollection<Reservation> Reservations { get; set; }
    }
}
