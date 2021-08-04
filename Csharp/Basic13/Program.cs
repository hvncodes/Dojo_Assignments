using System;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintSum();
            // int[] numbers = new int[] {1, 2, 3, 4, 5};
            // LoopArray(numbers);
            // int[] numbers = new int[] {-20, -3, -5, -7, 5};
            // FindMax(numbers);
            // OddArray();
            // GetAverage(new int[] {2, 10, 3});
            // GreaterThanY(new int[] {1, 3, 5, 7}, 3);
            // SquareArrayValues(new int[] {1, 5, 10, -10});
            // EliminateNegatives(new int[] {1, 5, 10, -2});
            // MinMaxAverage(new int[] {1, 5, 10, -2});
            // ShiftValues(new int[] {1, 5, 10, 7, -2});
            NumToString(new int[] {-1, -3, 2});
        }

        // Print 1-255
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Print odd numbers between 1-255
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Print Sum
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"New Number: {i} Sum: {sum}");
            }
        }

        // Iterating through an Array
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console.
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        // Find Max
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            foreach (var number in numbers)
            {
                if (max < number)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The Max Value in the given array is {max}");
            return max;
        }

        // Get Average
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int average = 0;
            int counter = 0;
            foreach (var number in numbers)
            {
                counter++;
                average += number;
            }
            average = average / counter;
            Console.WriteLine(average);
        }

        // Array with Odd Numbers
        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            double HalfLen = (double)255 / 2;
            int len = (int)Math.Ceiling(HalfLen);
            int[] OddNums = new int[len];
            Console.WriteLine(len);
            int index = 0;
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    OddNums[index] = i;
                    index++;
                }
            }
            Console.WriteLine("["+String.Join(", ", OddNums)+"]");
            return OddNums;
        }

        // Greater than Y
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int counter = 0;
            foreach (var number in numbers)
            {
                if (number > y)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            return counter;
        }

        // Square the Values
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine("["+String.Join(", ", numbers)+"]");
        }

        // Eliminate Negative Numbers
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine("["+String.Join(", ", numbers)+"]");
        }

        // Min, Max, and Average
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int total = 0;
            int max = numbers[0];
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                total += numbers[i];
            }
            double average = (double) total / numbers.Length;
            Console.WriteLine($"Min: {min}, Max: {max}, Average: {average}");
        }

        // Shifting the values in an array
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i+1 < numbers.Length)
                {
                    numbers[i] = numbers[i+1];
                }
                else
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine("["+String.Join(", ", numbers)+"]");
        }

        // Number to String
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] returnArray = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    returnArray[i] = numbers[i];
                }
                else
                {
                    returnArray[i] = "Dojo";
                }
            }
            Console.WriteLine("["+String.Join(", ", returnArray)+"]");
            return returnArray;
        }

    }
}
