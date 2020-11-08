using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        public string hotelName { get; set; }
        public int rateOfRegularCustomer { get; set; }

        public Hotel()
        {
            hotelName = "";
            rateOfRegularCustomer = 0;
        }

        public Hotel(string name, int rate)
        {
            this.hotelName = name;
            this.rateOfRegularCustomer = rate;
        }
    }
}