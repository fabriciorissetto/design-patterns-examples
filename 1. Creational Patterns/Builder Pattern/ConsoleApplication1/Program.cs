using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {            
            //var bigPizza = new Pizza(30, true, true, true);

            var familyPizza = new PizzaBuilder(45)
                              .Bacon()
                              .Cheese()
                              .Build();

            var s = new StringBuilder();
            s.Append("sdada").Append("dsadas").ToString();
        }
    }
}
