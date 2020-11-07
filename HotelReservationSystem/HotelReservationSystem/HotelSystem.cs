using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        public Hotel GetCheapestHotel(DateTime[] dates)
        {
            double noOfWeekend = 0;
            double cheapestPrice = Double.MaxValue;
            double noOfWeekday = 0;
            Hotel cheapestHotel = null;
            foreach (var date in dates)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    noOfWeekend++;
            }
            TimeSpan timeSpan = dates[1].Subtract(dates[0]);
            noOfWeekday = timeSpan.TotalDays - noOfWeekend;
            foreach (var hotel in hotelList)
            {
                double priceDuringStay = hotel.weekdayRatesForRegularCustomer * noOfWeekday + hotel.weekendRatesForRegularCustomer * noOfWeekend;
                if (priceDuringStay < cheapestPrice)
                {
                    cheapestPrice = priceDuringStay;
                    cheapestHotel = hotel;
                }
            }
            return cheapestHotel;
        }
        public Hotel GetCheapestHotelWithBestRating(DateTime[] dates)
        {
            double noOfWeekend = 0;
            double cheapestPrice = Double.MaxValue;
            double noOfWeekday = 0;
            List<Hotel> cheapestHotels = new List<Hotel>();
            foreach (var date in dates)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    noOfWeekend++;
            }
            TimeSpan timeSpan = dates[1].Subtract(dates[0]);
            noOfWeekday = timeSpan.TotalDays - noOfWeekend;
            foreach (var hotel in hotelList)
            {
                double priceDuringStay = hotel.weekdayRatesForRegularCustomer * noOfWeekday + hotel.weekendRatesForRegularCustomer * noOfWeekend;
                if (priceDuringStay < cheapestPrice)
                {
                    cheapestPrice = priceDuringStay;
                    cheapestHotels.Add(hotel);
                }
            }
            List<Hotel> sortedCheapestHotelsAsPerRating = cheapestHotels.OrderByDescending(x => x.rating).ToList();
            return sortedCheapestHotelsAsPerRating[0];
        }
    }
}
