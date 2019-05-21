using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._3.Behavioural.ChainOfResponsability
{
    using Models;

    public class NullableFilter: IUserFilter
    {
        public IUserFilter Next { get; }

        public NullableFilter(IUserFilter next)
        {
            Next = next;
        }
        public List<User> ExecuteFilter(List<User> users)
        {
            return users;
        }
    }
}
