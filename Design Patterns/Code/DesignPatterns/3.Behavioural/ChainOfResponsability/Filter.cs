using DesignPatterns._3.Behavioural.ChainOfResponsability.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DesignPatterns._3.Behavioural.ChainOfResponsability
{
    public class Filter
    {
        public static void FilterUsers()
        { 
            List<User> Users= JsonConvert.DeserializeObject<List<User>>(Resource1.Users);
        }
    }
}
