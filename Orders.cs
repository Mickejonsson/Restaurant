using System;

namespace Restaurant
{

    class Orders
    {
        public string Dish { get; }
        public string Table { get; }
        public DateTime RegistereAt { get; } = DateTime.Now;
        public DateTime? StartedAt { get; }
        public DateTime? CompletedAt { get; }

        
        public Orders(string dish, string table)
        {

            Dish = dish;
            Table = table;

        }

    }
}
