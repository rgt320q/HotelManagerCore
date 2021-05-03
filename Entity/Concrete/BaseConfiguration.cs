using Core.Entities;
using System;
using System.ComponentModel;

namespace Entity.Concrete
{
    public class BaseConfiguration:IEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; } = true;

        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [DisplayName("Tax Rate For KDV (%)")]
        public decimal TaxRateForKDV { get; set; } = 18;

        [DisplayName("Tax Rate For Accommodation (%)")]
        public decimal TaxRateForAccommodation { get; set; } = 1;

        [DisplayName("Daily Adult Fee")]
        public decimal DailyAdultFee { get; set; } = 0;

        [DisplayName("Daily Guest Fee For Room")]
        public decimal DailyGuestFeeForRoom { get; set; } = 0;

        [DisplayName("Daily Child fee")]
        public decimal DailyChildFee { get; set; } = 0;

        [DisplayName("Accommodation Fee")]
        public decimal AccommodationFee { get; set; } = 0;

        [DisplayName("Breakfast Price")]
        public decimal BreakfastPrice { get; set; } = 0;

        [DisplayName("Lunch Price")]
        public decimal LunchPrice { get; set; } = 0;

        [DisplayName("Dinner Price")]
        public decimal DinnerPrice { get; set; } = 0;

        [DisplayName("Insert Date Time")]
        public DateTime InsertDateTime { get; set; } = DateTime.Now;

        [DisplayName("Update Date Time")]
        public DateTime UpdateDateTime { get; set; } = DateTime.Now;
    }
}
