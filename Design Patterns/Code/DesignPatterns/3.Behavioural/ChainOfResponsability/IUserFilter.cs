using System.Collections.Generic;

namespace DesignPatterns._3.Behavioural.ChainOfResponsability
{
    using Models;

    public interface IUserFilter
    {
        IUserFilter Next { get; }

        List<User> ExecuteFilter(List<User> users);

    }
}
