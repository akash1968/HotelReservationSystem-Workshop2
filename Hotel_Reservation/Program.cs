﻿using System;
using System.Collections.Generic;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation System\n");
            HotelManager manager = new HotelManager();
            bool val = true;
            while (val)
            {
                Console.WriteLine("\nChoose among the following option\n1.Add Hotel\n2.Display Hotel\n3.Exit\n4.Find Cheapest Hotel" +
                    "\n5.Retrieve Ratings\n6.Find Cheapest Hotel as per Ratings");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            manager.AddHotel(new Hotel("Bridgewood", 150, 50, 110, 50, 4));
                            manager.AddHotel(new Hotel("Ridgewood", 220, 150, 100, 40, 5));
                            manager.AddHotel(new Hotel("Lakewood", 110, 90, 80, 80, 3));
                            break;
                        }

                    case 2:
                        {
                            manager.DisplayHotels();
                            break;
                        }

                    case 3:
                        {
                            val = false;
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Enter the startDate");
                            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter the endDate");
                            DateTime endDate = Convert.ToDateTime(Console.ReadLine());
                            Dictionary<Hotel, int> cheapHotelList = manager.FindCheapHotel(startDate, endDate);
                            foreach (var kvp in cheapHotelList)
                            {
                                Console.WriteLine("Cheapest Hotel will be: " + kvp.Key.hotelName + " with price $" + kvp.Value);
                            }
                            break;
                        }

                    case 5:
                        {
                            List<int> ratingList = new List<int>();
                            ratingList = manager.RetrieveHotelRatings();
                            foreach (var rating in ratingList)
                            {
                                Console.Write(rating + "\t");
                            }
                            Console.WriteLine("\n");
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Enter the startDate");
                            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter the endDate");
                            DateTime endDate = Convert.ToDateTime(Console.ReadLine());
                            Dictionary<Hotel, int> cheapHotelList = manager.FindCheapestBestRatedHotel(startDate, endDate);
                            foreach (var kvp in cheapHotelList)
                            {
                                Console.WriteLine("Cheapest Hotel will be: " + kvp.Key.hotelName + " with price $" + kvp.Value);
                            }
                            break;
                        }

                    default: break;
                }
            }
        }
    }
}
