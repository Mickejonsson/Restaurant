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
                    case ConsoleKey.NumPad1:

                        Write("Dish: ");

                        string dish = ReadLine();

                        Write("Table: ");

                        string table = ReadLine();

                        Orders newOrder = new Orders(dish, table);

                        restaurant.RegisterOrder(newOrder);

                       
                        Clear();

                        WriteLine("Order registered");

                        Thread.Sleep(2000);

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        WriteLine("Table    Dish                                   Registered");
                        WriteLine("-------------------------------------------------------------------");

                        foreach (Orders order in restaurant.OrderQueue)
                        {
                            WriteLine($"{order.Table}        {order.Dish}                                 {order.RegistereAt}");
                        }

                        WriteLine();
                        WriteLine("Press any key to continue");

                        ReadKey();

                        break;

                    case ConsoleKey.D3:
                        shouldRun = false;

                        break;


                }
            }
        }
    }
}
