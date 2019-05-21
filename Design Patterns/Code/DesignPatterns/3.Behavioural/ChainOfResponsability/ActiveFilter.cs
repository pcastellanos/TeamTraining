using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._3.Behavioural.ChainOfResponsability
{
    using System.Linq;
    using Models;

    public class ActiveFilter : IUserFilter
    {
        public IUserFilter Next { get; }

        public ActiveFilter(IUserFilter next)
        {
            Next = next;
        }
        public List<User> ExecuteFilter(List<User> users)
        {
            users = users.Where(user => user.IsActive).ToList();
            return Next.ExecuteFilter(users);
        }
    }
}
