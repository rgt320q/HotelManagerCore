using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.DTOs
{
    public class GuestDto
    {        
        public int GuestId { get; set; }       

        [Required, StringLength(50)]       
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        //[Required]
        [DisplayName("Phone Number"),Phone, DataType(DataType.PhoneNumber)]      
        public string Phone { get; set; }

        [DisplayName("Email Address"),EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       
        [Required,DisplayName("Ident Number"), MinLength(11), MaxLength(11)]
        public string IdentNumber { get; set; }
        
        public string Gender { get; set; }

        [DisplayName("Birth Day")]
        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        [DisplayName("Father Name")]
        public string FatherName { get; set; }

        [StringLength(50)]
        [DisplayName("Mother Name")]
        public string MotherName { get; set; }

        [StringLength(15)]
        [DisplayName("Martial Status")]
        public string MartialStatus { get; set; }   

        [StringLength(50)]
        [DisplayName("Ident Serial No")]
        public string IdentSerialNo { get; set; }

        [StringLength(12)]
        [DisplayName("Car Plate")]
        public string CarPlate { get; set; }

        [StringLength(150)]
        [DisplayName("Guest Note")]
        public string GuestNote { get; set; }
    }
}
