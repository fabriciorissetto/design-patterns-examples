using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = Singleton_Net4.Instance();
            var d = Singleton_Net4.Instance();
        }
    }
}
