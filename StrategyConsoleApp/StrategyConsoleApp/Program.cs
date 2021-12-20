// See https://aka.ms/new-console-template for more information
using StrategyConsoleApp.Logic.Tax;
using StrategyConsoleApp.Models;

Console.WriteLine("Application Start...");

OrderItem Orders = new(1);

Console.WriteLine("TAX: " + new OrderTaxFactory().GetTaxStrategy(Orders));

Console.ReadLine();

Console.WriteLine("Application End...");
