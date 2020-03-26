using DesignPatterns._1.Creational.Singleton.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._1.Creational.Singleton
{
    internal static class CitiesManager
    {
        internal static void ReadAllCities(){
            List<City> cities = JsonConvert.DeserializeObject<List<City>>(Resource1.Cities);

            cities.ForEach(city => Console.WriteLine(city));
        }
    }
}
