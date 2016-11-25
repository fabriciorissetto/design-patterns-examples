using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adapter;

namespace AdapterUnitTest
{
    [TestClass]
    public class UserAdapterUnitTest
    {
        static readonly Adapter.Commerce.User _commerUser = new Adapter.Commerce.User("John Doe", new DateTime(1980, 12, 28));
        static readonly Adapter.Ticket.User _ticketUser = new Adapter.Ticket.User("Billy", "the Kid", new DateTime(1859, 09, 17));

        [TestMethod]
        public void Can_Adapt_User_From_Commerce_SubSystem()
        {
            IUserAdapter user = new UserAdapter(_commerUser);
            Assert.AreEqual(user.Born, new DateTime(1980, 12, 28));
            Assert.AreEqual(user.FirstName, "John");
            Assert.AreEqual(user.LastName, "Doe");
            Assert.AreEqual(user.FullName, "John Doe");
        }
        [TestMethod]
        public void Can_Adapt_User_From_Ticket_SubSystem()
        {
            IUserAdapter user = new UserAdapter(_ticketUser);
            Assert.AreEqual(user.Born, new DateTime(1859, 09, 17));
            Assert.AreEqual(user.FirstName, "Billy");
            Assert.AreEqual(user.LastName, "the Kid");
            Assert.AreEqual(user.FullName, "Billy the Kid");
        }

    }
}
