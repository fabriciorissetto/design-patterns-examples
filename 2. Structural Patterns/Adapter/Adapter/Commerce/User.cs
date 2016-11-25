using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Commerce
{
    public class User
    {
        public User(string fullName, DateTime born)
        {
            FullName = fullName;
            Born = born;
        }

        public DateTime Born { get; private set; }
        public string FullName { get; private set; }
    }
}
