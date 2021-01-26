using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            String path = "Thing.Description";
            var result = LookUp(new Item("apple", "pineapple"), path);
            Console.WriteLine(result);
        }

        public static object LookUp(object obj, string path)
        {
            var _propertyNames = path.Split('.');

            for (int i = 0; i < _propertyNames.Length; i++)
            {
                if (obj != null)
                {
                    var _propertyInfo = obj.GetType().GetProperty(_propertyNames[i]);
                    if (_propertyInfo != null)
                    {
                        obj = _propertyInfo.GetValue(obj);
                    }
                    else
                    {
                        throw new ArgumentNullException("Object null");
                    }
                        
                }
            }

            return obj;
        }
    } 
}
