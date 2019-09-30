using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class RestaurantX
    {
        public string Name { get; set; }
        private Queue<Orders> OrderQueue { get; } = new Queue<Orders>();

        public RestaurantX(string name)
        {

            Name = name;
        }

        public void RegisterOrder (Orders order)
        {

            OrderQueue.Enqueue(order);
        }

    }
}
