using Core.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class BaseConfiguration:IEntity
    {
        public int BaseConfigurationId { get; set; }
        public bool Active { get; set; } = true;

        [DisplayName("Company Name")]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [DisplayName("Tax Rate For KDV (%)")]
        public decimal TaxRateForKDV { get; set; } = 18;

        [DisplayName("Tax Rate For Accommodation (%)")]
        public decimal TaxRateForAccommodation { get; set; } = 1;

        [DisplayName("Daily Adult Price")]
        public decimal DailyAdultPrice { get; set; } = 0;

        [DisplayName("Daily Child Price")]
        public decimal DailyChildPrice { get; set; } = 0;

        [DisplayName("Accommodation Price")]
        public decimal AccommodationPrice { get; set; } = 0;

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
