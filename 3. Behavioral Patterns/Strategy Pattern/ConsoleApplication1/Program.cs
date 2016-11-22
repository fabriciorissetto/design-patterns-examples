using ClassLibrary1;
using ClassLibrary1.Implementations;
using ClassLibrary1.Strategy.Implementations;
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
            SortedList studentRecords = new SortedList();
            
            studentRecords.Add("Joao");
            studentRecords.Add("Maria");
            studentRecords.Add("Rafael");
            studentRecords.Add("Ana 2");
            studentRecords.Add("Ana");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new IntrospectiveSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}
