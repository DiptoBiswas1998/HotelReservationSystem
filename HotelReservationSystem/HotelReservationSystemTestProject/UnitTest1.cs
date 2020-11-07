using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;
namespace HotelReservationSystemTestProject
{
    [TestClass]
    public class UnitTest1
    {
        HotelSystem hotelSystem = new HotelSystem();
        [TestMethod]
        public void TestMethod1()
        {
            string hotelName = "Hyath";
            int ratesForRegularCustomer = 100;
            Hotel hotel = new Hotel(hotelName, ratesForRegularCustomer);
            hotelSystem.AddHotel(hotel);
            Assert.AreEqual("Hyath", hotelSystem.hotelList[0].name);
        }
        [TestMethod]
        public void GivenHotelOptionsReturnCheapestHotel()
        {
            hotelSystem.AddHotel(new Hotel("Lakewood", 10000));
            hotelSystem.AddHotel(new Hotel("Bridgewood", 5000));
            hotelSystem.AddHotel(new Hotel("Ridgewood", 20000));
            string[] dates = "10Dec2020,11Dec2020".Split(",");
            Hotel cheapestHotel = hotelSystem.GetCheapestHotel(dates);
            Assert.AreEqual("Bridgewood", cheapestHotel.name);
        }
    }
}
