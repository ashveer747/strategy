using StrategyConsoleApp.Logic.Tax.Rates;
using StrategyConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsoleApp.Logic.Tax
{
    public class OrderTaxFactory
    {
        public decimal GetTaxStrategy(OrderItem item)
        {
            IOrderTaxStrategy ash;
            switch (item.TaxTypeID)
            {
                case 1:
                    ash = new JunkFoodTaxStrategy();
                    break;
                case 2:
                    ash = new DefaultTaxStrategy();
                    break;
                default:
                    ash = new JunkFoodTaxStrategy();
                    break;
            }

            return ash.GetTaxFor(item);
        }
    }
}
