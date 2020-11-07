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
        public Hotel()
        {
            name = "";
            ratesForRegularCustomer = 0;
            weekdayRatesForRegularCustomer = 0;
            weekendRatesForRegularCustomer = 0;
        }
        public Hotel(string name, int ratesForRegularCustomer)
        {
            this.name = name;
            this.ratesForRegularCustomer = ratesForRegularCustomer;
        }
        public Hotel(string name, int weekdayRatesForRegularCustomer, int weekendRatesForRegularCustomer)
        {
            this.name = name;
            this.weekdayRatesForRegularCustomer = weekdayRatesForRegularCustomer;
            this.weekendRatesForRegularCustomer = weekendRatesForRegularCustomer;
        }
    }
}
