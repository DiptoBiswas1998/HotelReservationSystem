using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationSystem
{
    public class Hotel
    {
        public string name;
        public int ratesForRegularCustomer;
        public Hotel()
        {
            name = "";
            ratesForRegularCustomer = 0;
        }
        public Hotel(string name, int ratesForRegularCustomer)
        {
            this.name = name;
            this.ratesForRegularCustomer = ratesForRegularCustomer;
        }
    }
}
