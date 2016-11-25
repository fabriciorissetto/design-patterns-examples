using System;

namespace Adapter
{
    public interface IUserAdapter
    {
        DateTime Born { get; }
        string FirstName { get; }
        string FullName { get; }
        string LastName { get; }
    }
}