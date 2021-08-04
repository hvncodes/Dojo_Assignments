using System;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Create an empty List of type object
            List<object> someList = new List<object>();
            // Add the following values to the list: 7, 28, -1, true, "chair"
            someList.Add(7);
            someList.Add(28);
            someList.Add(-1);
            someList.Add(true);
            someList.Add("chair");

            // Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach (var item in someList)
            {
                Console.WriteLine(item);
                // if (item is int) {
                //     Console.WriteLine((int)item);
                // }
                // else if (item is string)
                // {
                //     Console.WriteLine(item as string);
                // }
                // else if (item is bool)
                // {
                //     Console.WriteLine((bool)item);
                // }
            }
            // for loop method
            for (int idx = 0; idx < someList.Count; idx++)
            {
                Console.WriteLine(someList[idx]);
            }

            // Add all values that are Int type together and output the sum
            int sum = 0;
            foreach (var item in someList)
            {
                if (item is int) {
                    sum += (int)item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
