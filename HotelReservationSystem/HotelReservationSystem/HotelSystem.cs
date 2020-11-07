using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace HotelReservationSystem
{
    public class HotelSystem
    {
        public List<Hotel> hotelList;
        CheckDate checkDate = new CheckDate();
        public HotelSystem()
        {
            hotelList = new List<Hotel>();
        }
        public void AddHotel(Hotel hotel)
        {
            hotelList.Add(hotel);
        }
        public Hotel GetCheapestHotel(string[] dates)
        {
            DateTime[] validatedDates = checkDate.ValidateAndReturnDates(dates);
            hotelList.Sort((e1, e2) => e1.ratesForRegularCustomer.CompareTo(e2.ratesForRegularCustomer));
            return hotelList[0];
        }
    }
}
