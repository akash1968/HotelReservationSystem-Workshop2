using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelManager
    {
        public List<Hotel> hotelList = new List<Hotel>();

        public void AddHotel(Hotel newHotel)
        {
            if (!hotelList.Contains(newHotel))
            {
                hotelList.Add(newHotel);
            }
            else { Console.WriteLine("Hole already exists"); }
        }

        public void DisplayHotels()
        {
            Console.WriteLine("Name\tWeekday Rate\tWeekend Rate");
            foreach (var hotel in hotelList)
            {
                Console.WriteLine(hotel.hotelName + "\t" + hotel.weekdayRate + "\t" + hotel.weekendRate);
            }
        }

        public Hotel FindCheapHotel(DateTime startDate, DateTime endDate)
        {
            Hotel cheapestHotel = new Hotel();
            if (startDate > endDate)
            {
                throw new HotelException(HotelException.ExceptionType.INVALID_DATE, "Invalid Dates");
            }

            else
            {
                var cost = Int32.MaxValue;
                foreach (var hotel in hotelList)
                {
                    var temp = cost;
                    cost = Math.Min(cost, TotalCostCalculation(hotel, startDate, endDate));
                    if (temp != cost)
                        cheapestHotel = hotel;
                }
                Console.WriteLine("Cheapest Price " + cost);
            }
            return cheapestHotel;
        }

        public int TotalCostCalculation(Hotel hotel, DateTime startDate, DateTime endDate)
        {
            var totalCost = 0;
            var weekdayRate = hotel.weekdayRate;
            var weekendRate = hotel.weekendRate;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                    totalCost += weekendRate;
                else
                    totalCost += weekdayRate;
            }
            return totalCost;
        }
    }
}