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
            IOrderTaxStrategy? strategyType = null;
            string provider = item.TaxProviders.FirstOrDefault(x => x.TaxTypeID == item.TaxTypeID)?.Assembly ?? "";
            Type? type = Type.GetType(provider);
            if (type != null)
            {
                object? temp = Activator.CreateInstance(type);
                if (temp != null)
                {
                    strategyType = (IOrderTaxStrategy)temp;
                }
            }
            if(strategyType == null)
            {
                strategyType = new DefaultTaxStrategy();
            }
            return strategyType.GetTaxFor(item);
        }
    }
}
