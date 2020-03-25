using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._1.Creational
{
    public sealed class SingletonClass
    {

        private  static SingletonClass _instance = null;

        private SingletonClass()
        {
        }

        public static SingletonClass Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SingletonClass();


                return _instance;
            }
        }
    }
}
