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
            decimal tax = 0;
            foreach(var product in item.Items)
            {
                switch(product.CategoryID)
                {
                    case 1:
                        tax += 5;
                        break;
                    case 2:
                        tax += 3;
                        break;
                    case 3:
                        tax += 4;
                        break;
                    default:
                        tax += 0;
                        break;
                }
            }

            return tax;
        }
    }
}
