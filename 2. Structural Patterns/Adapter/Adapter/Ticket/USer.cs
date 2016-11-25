using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ticket
{
    public class User
    {
        public User(string firnstName, string lastName, DateTime born)
        {
            FirstName = firnstName;
            LastName = lastName;
            Born = born;
        }

        public DateTime Born { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
