using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton_Net4
    {
        private Singleton_Net4()
        {
            Console.WriteLine("Construtor!");
        }

        private static readonly Lazy<Singleton_Net4> lazy = new Lazy<Singleton_Net4>(() => new Singleton_Net4());

        public static Singleton_Net4 Instance() 
        { 
            return lazy.Value; 
        }
    }
}
