using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.DTOs
{
    public class PaidFeeDto
    {
        public int PaidFeeId { get; set; }

        [DisplayName("Amount Of The Fee Paid"), Range(0.00, 100000.00), DataType(DataType.Currency)]
        public decimal AmountOfTheFeePaid { get; set; }

        [DisplayName("Payment Type"), StringLength(20)]
        public string PaymentType { get; set; }
    }
}
