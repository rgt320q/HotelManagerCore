using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.DTOs
{
    public class PaymentDto
    {
        public int PaymentId { get; set; }        

        [DisplayName("Total Price"), Range(0.00, 10000.00)]
        public decimal TotalPrice { get; set; }        

        [DisplayName("Total KDV"), Range(0.00, 10000.00)]
        public decimal TotalKdv { get; set; }

        [DisplayName("Total Accommodation Tax"), Range(0.00, 10000.00)]
        public decimal TotalAccommodationTax { get; set; }

        [DisplayName("The Extras Price"), Range(0.00, 10000.00)]
        public decimal TheExtrasPrice { get; set; }

        [DisplayName("Discount Price"), Range(0.00, 10000.00)]
        public decimal DiscountPrice { get; set; }

        //Daily prices.
        [DisplayName("Daily Adult Price"), Range(0.00, 10000.00)]
        public decimal DailyAdultPrice { get; set; }

        [DisplayName("Daily Child Price"), Range(0.00, 10000.00)]
        public decimal DailyChildPrice { get; set; }

        [DisplayName("Daily Accommodation Price"), Range(0.00, 10000.00)]
        public decimal DailyAccommodationPrice { get; set; }

        [DisplayName("Daily Breakfast Price"), Range(0.00, 10000.00)]
        public decimal DailyBreakfastPrice { get; set; }

        [DisplayName("Daily Lunch Price"), Range(0.00, 10000.00)]
        public decimal DailyLunchPrice { get; set; }

        [DisplayName("Daily Dinner Price"), Range(0.00, 10000.00)]        
        public decimal DailyDinnerPrice { get; set; }

        //Total daily prices.
        [DisplayName("Total Daily Adult Price"), Range(0.00, 10000.00)]        
        public decimal TotalDailyAdultPrice { get; set; }

        [DisplayName("Total Daily Child Price"), Range(0.00, 10000.00)]        
        public decimal TotalDailyChildPrice { get; set; }

        [DisplayName("Total Daily Room Price"), Range(0.00, 10000.00)]        
        public decimal TotalDailyRoomPrice { get; set; }

        [DisplayName("Daily Accommodation Price"), Range(0.00, 10000.00)]        
        public decimal TotalDailyAccommodationPrice { get; set; }

        [DisplayName("Daily Breakfast Price"), Range(0.00, 10000.00)]        
        public decimal TotalDailyBreakfastPrice { get; set; }

        [DisplayName("Daily Lunch Price"), Range(0.00, 10000.00)]
        public decimal TotalDailyLunchPrice { get; set; }

        [DisplayName("Daily Dinner Price"), Range(0.00, 10000.00)]
        public decimal TotalDailyDinnerPrice { get; set; }

        //Total prices
        [DisplayName("Total Adult Price"),Range(0.00, 10000.00)]        
        public decimal TotalAdultPrice { get; set; }

        [DisplayName("Total Child Price"), Range(0.00, 10000.00)]
        public decimal TotalChildPrice { get; set; }

        [DisplayName("Total Room Price"), Range(0.00, 10000.00)]      
        public decimal TotalRoomPrice { get; set; }

        [DisplayName("Total Accommodation Price"), Range(0.00, 10000.00)]
        public decimal TotalAccommodationPrice { get; set; }

        [DisplayName("Total Break Fast Price"), Range(0.00, 10000.00)]
        public decimal TotalBreakfastPrice { get; set; }

        [DisplayName("Total Lunch Price"), Range(0.00, 10000.00)]
        public decimal TotalLunchPrice { get; set; }

        [DisplayName("Total Dinner Price"), Range(0.00, 10000.00)]
        public decimal TotalDinnerPrice { get; set; }       

        public List<PaidFeeDto> PaidFees { get; set; }
       
    }
}
