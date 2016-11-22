using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Implementations
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.Sort(); //Was the default sort of .NET 4.0 and earlier

            Console.WriteLine("QuickSorted list ");
        }
    }
}
