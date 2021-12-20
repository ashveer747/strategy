using StrategyConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsoleApp.Logic.Tax.Rates
{
    public class JunkFoodTaxStrategy : IOrderTaxStrategy
    {
        public decimal GetTaxFor(OrderItem item)
        {
            return 50;
        }
    }
}
