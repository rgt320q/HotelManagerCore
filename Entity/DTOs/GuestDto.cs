using System;

namespace Entity.DTOs
{
    public class GuestDto
    {        
        public int Id { get; set; }
        public bool Active { get; set; }       
        public int TypeOfGuest { get; set; }        
        public string Name { get; set; }        
        public string Surname { get; set; }       
        public string Phone { get; set; }       
        public string Email { get; set; }
        public string IdentNumber { get; set; }
        public int Gender { get; set; }
        public DateTime? Birthday { get; set; }        
        public string FatherName { get; set; }       
        public string MotherName { get; set; }        
        public string MartialStatus { get; set; }       
        public string IdentType { get; set; }        
        public string IdentSerialNo { get; set; }       
        public string CarPlate { get; set; }       
        public string GuestNote { get; set; }
    }
}
