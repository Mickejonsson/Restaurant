using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Restaurant
{

    class Program
    {
        static void Main(string[] args)
        {
            RestaurantX restaurant = new RestaurantX("MaxDonalds");

            bool shouldRun = true;

            while (shouldRun)
            {
                Clear();


                WriteLine("1. Add order");
                WriteLine("2. List orders");
                WriteLine("3.Exit");

                ConsoleKeyInfo keyPressed = ReadKey();

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:

                        Write("Dish: ");

                        string dish = ReadLine();

                        Write("Table: ");

                        string table = ReadLine();

                        Orders order = new Orders(dish, table);

                        restaurant.RegisterOrder(order);

                       
                        Clear();

                        WriteLine("Order registered");

                        Thread.Sleep(2000);

                        break;

                    case ConsoleKey.D2:

                        break;

                    case ConsoleKey.D3:
                        shouldRun = false;

                        break;


                }
            }
        }
    }
}
