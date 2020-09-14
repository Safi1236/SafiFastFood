using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SafiFastFood.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string FoodName { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

    }

    public class FoodDBContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
    }
}