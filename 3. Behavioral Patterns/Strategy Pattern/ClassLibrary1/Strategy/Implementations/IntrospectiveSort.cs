using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Strategy.Implementations
{
    public class IntrospectiveSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); //Introspective is the default of .NET 4.5 

            Console.WriteLine("IntrospectiveSorted list ");
        }
    }
}
