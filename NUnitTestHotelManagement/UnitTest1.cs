using NUnit.Framework;
using HotelReservationSystem;
using System;

namespace NUnitTestHotelManagement
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddingListofHotels_ShouldReturn_CountofHotelsinList()
        {
            HotelManager manager = new HotelManager();
            manager.AddHotel(new Hotel("Lakewood", 110, 80));
            manager.AddHotel(new Hotel("Bridgewood", 160, 120));
            manager.AddHotel(new Hotel("Ridgewood", 220, 180));

            int actual = manager.hotelList.Count;
            Assert.AreEqual(3, actual);

        }

        [Test]
        public void GivenStartandEndDates_ShouldReturn_CheapestHotel()
        {
            HotelManager manager = new HotelManager();
            DateTime startDate = new DateTime(2020, 08, 12);
            DateTime endDate = new DateTime(2020, 08, 20);
            Hotel cheapHotel = manager.FindCheapHotel(startDate, endDate);
            Assert.AreEqual("Lakewood", cheapHotel.hotelName);
        }


    }
}