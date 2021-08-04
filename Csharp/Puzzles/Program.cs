using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins(10);
            // FunkyNameMethod();
            Names();
        }

        // Create a function called RandomArray() that returns an integer array
        // Place 10 random integer values between 5-25 into the array
        // Print the min and max values of the array
        // Print the sum of all the values
        public static int[] RandomArray()
        {
            int[] returnArray = new int[10];
            Random rand = new Random();
            returnArray[0] = rand.Next(5,26);
            int max = returnArray[0];
            int min = returnArray[0];
            int sum = returnArray[0];
            for (int i = 1; i < returnArray.Length; i++)
            {
                returnArray[i] = rand.Next(5,26);
                // if (returnArray[i] > max)
                // {
                //     max = returnArray[i];
                // }
                // else if (returnArray[i] < min)
                // {
                //     min = returnArray[i];
                // }
                max = Math.Max(max, returnArray[i]);
                min = Math.Min(min, returnArray[i]);
                sum += returnArray[i];
            }
            Console.WriteLine("["+String.Join(", ", returnArray)+"]");
            Console.WriteLine($"Min: {min}, Max: {max}, Sum: {sum}");
            return returnArray;
        }

        // Coin Flip
        public static string TossCoin()
        {
            // Have the function print "Tossing a Coin!"
            // Randomize a coin toss with a result signaling either side of the coin 
            // Have the function print either "Heads" or "Tails"
            // Finally, return the result
            string result;
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int faceValue = rand.Next(2);
            if (faceValue == 0)
            {
                result = "Heads";
            }
            else
            {
                result = "Tails";
            }
            Console.WriteLine($"The coin toss resulted in: {result}!");
            return result;
        }

        // Create another function called TossMultipleCoins(int num) that returns a Double
        public static double TossMultipleCoins(int num)
        {
            double ratio;
            int heads = 0;
            Random rand = new Random();
            // Have the function call the tossCoin function multiple times based on num value
            for (int i = 1; i <= num; i++) {
                if (rand.Next(2) == 0)
                {
                    heads++;
                }
            }
            // Have the function return a Double that reflects the ratio of head toss to total toss
            ratio = (double)heads/num;
            Console.WriteLine($"Total Tosses: {num}, Total Heads: {heads}, Ratio: {ratio}");
            return ratio;
        }
        
        // Build a function Names that returns a list of strings.
        public static List<string> FunkyNameMethod()
        {
            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            List<string> people = new List<string> { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            // Shuffle the list and print the values in the new order
            Console.WriteLine($"Shuffling the List...");
            Random rand = new Random();
            for (int i = 0; i < people.Count; i++) {
                int indexToShuffle = rand.Next(people.Count);
                Console.WriteLine($"Taking index {i} and swapping it with index {indexToShuffle}");
                var temp = people[i];
                people[i] = people[indexToShuffle];
                people[indexToShuffle] = temp;
            }
            Console.WriteLine($"The List now looks like:");
            foreach (var person in people)
            {
                Console.WriteLine($"- {person}");
            }
            // Return a list that only includes names longer than 5 characters
            Console.WriteLine($"Removing all names in List that are 5 characters or shorter...");
            int index = 0;
            while (index < people.Count)
            {
                if (people[index].Length <= 5)
                {
                    people.Remove(people[index]);
                }
                else
                {
                    index++;
                }
            }
            Console.WriteLine($"The people left inside the List are:");
            foreach (var person in people)
            {
                Console.WriteLine($"- {person}");
            }
            return people;
        }

        public static List<string> Names()
        {
            // Create an list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            List<string> names = new List<string>()
            {
                "Todd1", "Todd2", "Todd3", "Todd4", "Todd5", "Todd6", "Sydney"
            };

            Random rand = new Random();

            // shuffle names
            for(var i=0; i<names.Count/2; i++)
            {
                // swap names[i] with names[randomIndex]
                int randomIndex = rand.Next(names.Count);
                string temp = names[randomIndex];
                names[randomIndex] = names[i];
                names[i] = temp;
            }

            // print new order of names
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            // remove names not larger than 5 characters
            for(var i = 0; i < names.Count; i++)
            {
                if(names[i].Length <= 5)
                    names.RemoveAt(i);
            }
            Console.WriteLine($"The people left inside the List are:");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            return names;
        }
    }
}
