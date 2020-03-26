using DesignPatterns._1.Creational.Singleton.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._1.Creational.Singleton
{
    public class CitySingleton
    {
        private static CitySingleton singleton;
        public List<City> Cities;

        private CitySingleton() {
            Cities = JsonConvert.DeserializeObject<List<City>>(Resource1.Cities);
        }

        public static CitySingleton GetInstance()
        {
            if (singleton == null) singleton = new CitySingleton();

            return singleton;
        }

    }
}
