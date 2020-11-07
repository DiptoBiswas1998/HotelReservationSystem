using System;
namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hotel Reservation System!");
            HotelSystem hotelSystem = new HotelSystem();
            hotelSystem.AddHotel(new Hotel("Hyath", 100));
            hotelSystem.AddHotel(new Hotel("Taj", 150));
            hotelSystem.AddHotel(new Hotel("Oberoi", 200));
        }
    }
}
