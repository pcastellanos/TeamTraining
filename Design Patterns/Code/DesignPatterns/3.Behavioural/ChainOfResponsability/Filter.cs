using DesignPatterns._3.Behavioural.ChainOfResponsability.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using static System.Console;
namespace DesignPatterns._3.Behavioural.ChainOfResponsability
{
    using System;
    using System.Linq;
    using System.Runtime.InteropServices;

    public class Filter
    {
        public static void FilterUsers()
        { 
            List<User> users= JsonConvert.DeserializeObject<List<User>>(Resource1.Users);
            users = users.Where(user => user.IsActive).ToList();
            users = users.Where(user => user.Age > 20).ToList();
            Print(users);
        }

        private static void Print(List<User> users)
        {
            users.ForEach(user=> WriteLine(user.ToString()));
        }

    }
}
