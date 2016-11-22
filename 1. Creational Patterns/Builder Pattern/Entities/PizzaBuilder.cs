using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PizzaBuilder : Pizza
    {
        public PizzaBuilder(int size)
        {
            base.size = size;
        }

        public PizzaBuilder Cheese()
        {
            base.cheese = true;
            return this;
        }

        public PizzaBuilder Pepperoni()
        {
            base.pepperoni = true;
            return this;
        }

        public PizzaBuilder Bacon()
        {
            base.bacon = true;
            return this;
        }

        public Pizza Build()
        {
            return this as Pizza;
        }
    }
}
