using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class UserAdapter : IUserAdapter
    {
        public UserAdapter(Commerce.User user)
        {
            Born = user.Born;
            FullName = user.FullName;
            FirstName = user.FullName.Substring(0, user.FullName.IndexOf(" "));
            LastName = user.FullName.Substring(user.FullName.IndexOf(" ") + 1);
        }

        public UserAdapter(Ticket.User user)
        {
            Born = user.Born;
            FullName = string.Concat(user.FirstName, " ", user.LastName);
            FirstName = user.FirstName;
            LastName = user.LastName;
        }

        public DateTime Born { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get; private set; }
    }
}
