using StrategyConsoleApp.Logic.Tax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsoleApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
    }

    public class OrderTaxProvider
    {
        public string Assembly { get; set; }
        public int TaxTypeID { get; set; }
    }

    public class OrderItem
    {
        public List<Order> Items { get; set; }
        public List<OrderTaxProvider> TaxProviders { get; set; }    
        public int TaxTypeID { get; set; }
        public OrderItem(int TaxTypeID)
        {
            Items = new List<Order>()
            {
                new Order(){ Id = 1 , Name = "Chips",       Price = 20, CategoryID = 1 },
                new Order(){ Id = 1 , Name = "Sweets",      Price = 30, CategoryID = 1 },
                new Order(){ Id = 2 , Name = "Chocolate",   Price = 15, CategoryID = 3 },
                new Order(){ Id = 3 , Name = "Eggs",        Price = 20, CategoryID = 2 },
                new Order(){ Id = 3 , Name = "Beans",       Price = 15, CategoryID = 2 },
            };
            this.TaxProviders = new List<OrderTaxProvider>()
            {
                new OrderTaxProvider(){ Assembly = "StrategyConsoleApp.Logic.Tax.Rates.JunkFoodTaxStrategy", TaxTypeID = 1 },
                new OrderTaxProvider(){ Assembly = "StrategyConsoleApp.Logic.Tax.Rates.DefaultTaxStrategy", TaxTypeID = 2 },
                new OrderTaxProvider(){ Assembly = "StrategyConsoleApp.Logic.Tax.Rates.DefaultTaxStrategy", TaxTypeID = 3 },
            };
            this.TaxTypeID = TaxTypeID;
        }
    }
}
