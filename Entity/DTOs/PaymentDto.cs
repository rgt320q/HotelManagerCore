using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public bool Active { get; set; } = true;
        public decimal TotalPrice { get; set; }
        public decimal TotalKdv { get; set; }
        public decimal TotalAccommodationTax { get; set; }
        public decimal TheExtrasPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal DailyAdultPrice { get; set; }
        public decimal DailyChildPrice { get; set; }
        public decimal DailyAccommodationPrice { get; set; }
        public decimal DailyBreakfastPrice { get; set; }
        public decimal DailyLunchPrice { get; set; }
        public decimal DailyDinnerPrice { get; set; }
        public decimal TotalDailyAdultPrice { get; set; }
        public decimal TotalDailyChildPrice { get; set; }
        public decimal TotalDailyRoomPrice { get; set; }
        public decimal TotalDailyAccommodationPrice { get; set; }
        public decimal TotalDailyBreakfastPrice { get; set; }
        public decimal TotalDailyLunchPrice { get; set; }
        public decimal TotalDailyDinnerPrice { get; set; }
        public decimal TotalAdultPrice { get; set; }
        public decimal TotalChildPrice { get; set; }
        public decimal TotalRoomPrice { get; set; }
        public decimal TotalAccommodationPrice { get; set; }
        public decimal TotalBreakfastPrice { get; set; }
        public decimal TotalLunchPrice { get; set; }
        public decimal TotalDinnerPrice { get; set; }
    }
}
