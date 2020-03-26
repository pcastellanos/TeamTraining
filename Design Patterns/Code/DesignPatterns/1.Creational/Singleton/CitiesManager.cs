using DesignPatterns._1.Creational.Singleton.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns._1.Creational.Singleton
{
    internal static class CitiesManager
    {
        internal static void ReadAllCities(){
            List<City> cities = CitySingleton.GetInstance().Cities;
            
            cities.ForEach(city => Console.WriteLine(city));
        }
    }
}
