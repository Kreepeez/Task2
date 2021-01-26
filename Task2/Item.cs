using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Item
    {
        List<String> itemList;
        String item1;
        String item2;
        Thing thing;
        public Item(String item1, String item2)
        {
            this.item1 = item1;
            this.item2 = item2;
            itemList = new List<String>();
            itemList.Add(Item1);
            itemList.Add(Item2);
            thing = new Thing();
            
        }
        public String Item1
        { get { return item1; } }

        public String Item2
        {
            get { return item2; }
            
        }
        public List<String> ItemList
        {
            get { return itemList; }
            
        }
        public Thing Thing
        {
            get { return thing; }
        }

    }
}
