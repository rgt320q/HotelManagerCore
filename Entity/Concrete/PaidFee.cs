using Core.Entities;
using System;
using System.ComponentModel;

namespace Entity.Concrete
{
    public class PaidFee:IEntity
    {        
        public int PaidFeeId { get; set; }
        public bool Active { get; set; } = true;

        [DisplayName("Amount Of The Fee Paid")]
        public decimal AmountOfTheFeePaid { get; set; }

        [DisplayName("Payment Type")]
        public string PaymentType { get; set; }

        public DateTime InsertDateTime { get; set; } = DateTime.Now;

        [DisplayName("Update Date Time")]
        public DateTime? UpdateDateTime { get; set; } = DateTime.Now;

        public Payment Payment { get; set; }
    }
}
