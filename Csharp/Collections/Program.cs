using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
            // Create an array to hold integer values 0 through 9
            int[] IntArray = new int[] {0,1,2,3,4,5,6,7,8,9};

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] NameArray = new string[] { "Time", "Martin", "Nikki", "Sara" };
            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] AlternatingBoolArray = new bool[] { true , false , true , false , true , false , true , false , true , false };

            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> IceCreamList = new List<string>();
            IceCreamList.Add("Vanilla");
            IceCreamList.Add("Chocolate");
            IceCreamList.Add("Mint");
            IceCreamList.Add("Strawberry");
            IceCreamList.Add("Cookie Dough");
            // Output the length of this list after building it
            Console.WriteLine(IceCreamList.Count); // 5
            // Output the third flavor in the list, then remove this value
            Console.WriteLine(IceCreamList[2]); // Mint
            IceCreamList.RemoveAt(2);
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(IceCreamList.Count); // 4

            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> IceCreamDict = new Dictionary<string, string>();
            // Add key/value pairs to this dictionary where:
            // each key is a name from your names array
            // each value is a randomly select a flavor from your flavors list.
            Random rand = new Random();
            foreach (var name in NameArray)
            {
                string randomflavor = IceCreamList[rand.Next(IceCreamList.Count)];
                IceCreamDict.Add(name, randomflavor);
            }
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (var entry in IceCreamDict)
            {
                Console.WriteLine($"{entry.Key} --- {entry.Value}");
            }
        }
    }
}
