using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        private static Singleton _instance;
        private static object obj = new object();

        private Singleton()
        {
            Console.WriteLine("Constructor!");
        }

        public static Singleton Instance()
        {

            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
