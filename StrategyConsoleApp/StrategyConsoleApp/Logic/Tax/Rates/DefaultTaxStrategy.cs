using StrategyConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsoleApp.Logic.Tax.Rates
{
    internal class DefaultTaxStrategy : IOrderTaxStrategy
    {
        public decimal GetTaxFor(OrderItem item)
        {
            return 100;
        }
    }
}
