using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            Console.WriteLine(numArray);
            string[] stringArray = {"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(stringArray[0]);
            bool[] booleanArray = {true,false,true,false,true,false,true,false,true,false};
            Console.WriteLine (booleanArray[3]);
            List<string> iceCream = new List<string>();
            iceCream.Add("Chocolate");
            iceCream.Add("MazurBerry");
            iceCream.Add("Neopolitan");
            iceCream.Add("Pistachio");
            iceCream.Add("Wasabi");
            Console.WriteLine("Count: {0}", iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.Remove("Neopolitan");
            Console.WriteLine("Count: {0}", iceCream.Count);
            Dictionary<string,string> iceCreamOrders = new Dictionary<string, string>();
            Random random = new Random();
            var randFlavor = random.Next(iceCream.Count);
            //tested both ways. Random isn't very random. 
            foreach (string element in stringArray)
            {
                iceCreamOrders.Add(element, iceCream[randFlavor]);
            }
            iceCreamOrders.Add(stringArray[0], iceCream[randFlavor]);
            iceCreamOrders.Add(stringArray[1], iceCream[randFlavor]);
            iceCreamOrders.Add(stringArray[2], iceCream[randFlavor]);
            iceCreamOrders.Add(stringArray[3], iceCream[randFlavor]);
            foreach (KeyValuePair<string,string> entry in iceCreamOrders)
            {
                Console.WriteLine(entry.Key +"-"+ entry.Value);
            }
        }
    }
}
