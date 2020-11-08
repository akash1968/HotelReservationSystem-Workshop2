using System;

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
                Console.WriteLine("Choose among the following option\n1.Add Hotel\n2.Display Hotel\n3.Exit\n4.Find Cheapest Hotel");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            manager.AddHotel(new Hotel("Bridgewood", 160, 100));
                            manager.AddHotel(new Hotel("Ridgewood", 220, 180));
                            manager.AddHotel(new Hotel("Lakewood", 110, 80));
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
                            Hotel cheapHotel = manager.FindCheapHotel(startDate, endDate);
                            Console.WriteLine("Cheapest Hotel will be: " + cheapHotel.hotelName + "\n");
                            break;
                        }

                    default: break;
                }
            }
        }
    }
}