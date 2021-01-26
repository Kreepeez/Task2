using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Thing
    {
        
        public string name = "TheThing";
        public String Name { get { return name; } }
        public string description = "Alien Movie";
        public String Description { get { return description; } }
        public Item Item
        {
            get { return new Item("apple", "pineapple"); }
        }
    }
}
