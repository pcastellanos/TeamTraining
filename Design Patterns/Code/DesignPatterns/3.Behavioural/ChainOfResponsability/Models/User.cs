using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._3.Behavioural.ChainOfResponsability.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public int Age { get; set; }
        public EyeColors EyeColor { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int UnreadMessage { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Fruits FavoriteFruit { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, UnreadMessage: {UnreadMessage}, IsActive: {IsActive}, Eye Color: {EyeColor}, Age: {Age}";
        }
    }
}
