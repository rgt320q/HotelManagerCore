using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Payment
    {
        public int Id { get; set; }
        public bool Active { get; set; } = true;

        [DisplayName("Total Price")]
        public decimal TotalPrice { get; set; } = 0;

        [DisplayName("Total KDV")]
        public decimal TotalKdv { get; set; }

        [DisplayName("Total Accommodation Tax")]
        public decimal TotalAccommodationTax { get; set; }

        [DisplayName("The Extras Price")]
        public decimal TheExtrasPrice { get; set; } = 0;

        [DisplayName("Discount Price")]
        [Range(0.00, 10000.00)]
        public decimal DiscountPrice { get; set; } = 0;

        [DisplayName("Daily Adult Fee")]
        public decimal DailyAdultFee { get; set; } = 0;

        [DisplayName("Daily Guest Fee For Room")]
        public decimal DailyGuestFeeForRoom { get; set; } = 0;

        [DisplayName("Daily Child Fee")]
        public decimal DailyChildFee { get; set; } = 0;

        [DisplayName("Room Fee")]
        public decimal RoomFee { get; set; } = 0;

        [DisplayName("Accommodation Fee")]
        public decimal AccommodationFee { get; set; } = 0;

        [DisplayName("Breakfast Price")]
        public decimal BreakfastPrice { get; set; } = 0;

        [DisplayName("Lunch Price")]
        public decimal LunchPrice { get; set; } = 0;

        [DisplayName("Dinner Price")]
        public decimal DinnerPrice { get; set; } = 0;

        [DisplayName("Total Daily Adult Fee")]
        public decimal TotalDailyAdultFee { get; set; } = 0;

        [DisplayName("Total Daily Guest Fee For Room")]
        public decimal TotalDailyGuestFeeForRoom { get; set; } = 0;

        [DisplayName("Total Child Fee")]
        public decimal TotalChildFee { get; set; } = 0;

        [DisplayName("Total Room Fee")]
        public decimal TotalRoomFee { get; set; } = 0;

        [DisplayName("Total Accommodation Fee")]
        public decimal TotalAccommodationFee { get; set; } = 0;

        [DisplayName("Total Break Fast Fee")]
        public decimal TotalBreakFastFee { get; set; } = 0;

        [DisplayName("Total Lunch Fee")]
        public decimal TotalLunchFee { get; set; } = 0;

        [DisplayName("Total Dinner Fee")]
        public decimal TotalDinnerFee { get; set; } = 0;

        [DisplayName("Insert Date Time"), ScaffoldColumn(false)]
        public DateTime InsertDateTime { get; set; } = DateTime.Now;

        [DisplayName("Update Date Time"), ScaffoldColumn(false)]
        public DateTime? UpdateDateTime { get; set; } = DateTime.Now;

        public Reservation Reservation { get; set; }
       
    }
}
