using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationSystem
{
    public class Hotel
    {
        public string name;
        public int ratesForRegularCustomer;
        public int weekdayRatesForRegularCustomer;
        public int weekendRatesForRegularCustomer;
        public int weekdayRatesForRewardCustomer;
        public int weekendRatesForRewardCustomer;
        public int rating;
        public Hotel()
        {
            name = "";
            weekdayRatesForRegularCustomer = 0;
            weekendRatesForRegularCustomer = 0;
            rating = 0;
        }
        public Hotel(string name, int ratesForRegularCustomer)
        {
            this.name = name;
            weekdayRatesForRegularCustomer = ratesForRegularCustomer;
        }
        public Hotel(string name, int weekdayRatesForRegularCustomer, int weekendRatesForRegularCustomer)
        {
            this.name = name;
            this.weekdayRatesForRegularCustomer = weekdayRatesForRegularCustomer;
            this.weekendRatesForRegularCustomer = weekendRatesForRegularCustomer;
        }
        public Hotel(string hotelName, int rating, int weekdayRatesForRegularCustomer, int weekendRatesForRegularCustomer)
        {
            this.name = hotelName;
            this.rating = rating;
            this.weekdayRatesForRegularCustomer = weekdayRatesForRegularCustomer;
            this.weekendRatesForRegularCustomer = weekendRatesForRegularCustomer;
        }
        public Hotel(string hotelName, int rating, int weekdayRatesForCustomer, int weekendRatesForCustomer, RewardCustomer rewardCustomer)
        {
            this.name = hotelName;
            this.rating = rating;
            this.weekdayRatesForRewardCustomer = weekdayRatesForCustomer;
            this.weekendRatesForRewardCustomer = weekendRatesForCustomer;
        }
    }
}
