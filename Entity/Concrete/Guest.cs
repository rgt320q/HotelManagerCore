using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }
        public bool Active { get; set; } = true;

        [DisplayName("Type Of Guest")]
        public int TypeOfGuest { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        //[Required]
        [Phone]
        [MaxLength(11)]
        [MinLength(11)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        //[Index(IsUnique = true)]
        [DisplayName("Ident Number")]
        public string IdentNumber { get; set; }

        [Required]
        public int Gender { get; set; }

        [DisplayName("Birth Day")]
        public DateTime? Birthday { get; set; }

        [DisplayName("Father Name")]
        public string FatherName { get; set; }

        [DisplayName("Mother Name")]
        public string MotherName { get; set; }

        [DisplayName("Martial Status")]
        public string MartialStatus { get; set; }

        [DisplayName("Ident Type")]
        public string IdentType { get; set; }

        [DisplayName("Ident Serial No")]
        public string IdentSerialNo { get; set; }

        [DisplayName("Car Plate")]
        public string CarPlate { get; set; }

        [DisplayName("Guest Note")]
        public string GuestNote { get; set; }

        [DisplayName("Insert Date Time")]
        public DateTime InsertDateTime { get; set; } = DateTime.Now;

        [DisplayName("Update Date Time")]
        public DateTime UpdateDateTime { get; set; } = DateTime.Now;

        public ICollection<Reservation> Reservations { get; set; }
    }
}
