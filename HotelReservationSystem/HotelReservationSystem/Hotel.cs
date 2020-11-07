using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationSystem
{
    public class Hotel
    {
        public string name;
        public int ratesForRegularCustomer;
        public int weekdayRatesForCustomer;
        public int weekendRatesForCustomer;
        public int rating;
        public Hotel()
        {
            name = "";
            weekdayRatesForCustomer = 0;
            weekendRatesForCustomer = 0;
            rating = 0;
        }
        public Hotel(string name, int ratesForRegularCustomer)
        {
            this.name = name;
            weekdayRatesForCustomer = ratesForRegularCustomer;
        }
        public Hotel(string name, int weekdayRatesForRegularCustomer, int weekendRatesForRegularCustomer)
        {
            this.name = name;
            this.weekdayRatesForCustomer = weekdayRatesForRegularCustomer;
            this.weekendRatesForCustomer = weekendRatesForRegularCustomer;
        }
        public Hotel(string hotelName, int rating, int weekdayRatesForRegularCustomer, int weekendRatesForRegularCustomer)
        {
            this.name = hotelName;
            this.rating = rating;
            this.weekdayRatesForCustomer = weekdayRatesForRegularCustomer;
            this.weekendRatesForCustomer = weekendRatesForRegularCustomer;
        }
        public Hotel(string hotelName, int rating, int weekdayRatesForCustomer, int weekendRatesForCustomer, RewardCustomer rewardCustomer)
        {
            this.name = hotelName;
            this.rating = rating;
            this.weekdayRatesForCustomer = weekdayRatesForCustomer;
            this.weekendRatesForCustomer = weekendRatesForCustomer;
        }
    }
}
