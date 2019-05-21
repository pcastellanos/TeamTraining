using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._3.Behavioural.ChainOfResponsability
{
    using System.Linq;
    using System.Threading;
    using Models;

    class AgeFilter : IUserFilter
    {
        public IUserFilter Next { get; }

        public AgeFilter(IUserFilter next)
        {
            Next = next;
        }
        public List<User> ExecuteFilter(List<User> users)
        {
            users = users.Where(user => user.Age > 30).ToList();
            return Next.ExecuteFilter(users);
            
        }
    }
}
