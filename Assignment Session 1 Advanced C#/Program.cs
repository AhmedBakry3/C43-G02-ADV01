using Assignment_Session_1_Advanced_C_.Question_1;
using Assignment_Session_1_Advanced_C_.Question_4;

namespace Assignment_Session_1_Advanced_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 : Create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.
            //Requirements:
            // Create a generic class named Range<T> where T represents the type of values.
            //Implement a constructor that takes the minimum and maximum values to define the range.
            //Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
            //Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            //Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

            //Calling IsInRange Method
            Range<int> range = new Range<int>(5, 10);
            Console.WriteLine(range.IsInRange(7)); //True

            //Calling Length() Method
            Console.WriteLine(range.Lengh()); // 5 => Max-Min = 10-5 = 5
            #endregion

            #region Question 2 : You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Original Array: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " "); //Original Array:
                                             //1 2 3 4 5 6 7 8 9 10
            }

            Helper<int>.ReverseArray(numbers);

            Console.WriteLine("\nReversed Array: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");//Reversed Array:
                                            //10 9 8 7 6 5 4 3 2 1
            }

            #endregion

            #region Question 3 : You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //Creating an array of numbers "Numbers"
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //using GetEvenNumbers Method
            int[] evenNumbers = Helper<int>.GetEvenNumbers(numbers);

            Console.Write("Even numbers: ");

            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.Write(evenNumbers[i]);

                if (i < evenNumbers.Length - 1)
                {
                    Console.Write(", "); //Even numbers: 2, 4, 6, 8, 10
                }
            }

            #endregion

            #region Question 4 :implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
            //Requirements:
            //Create a generic class named FixedSizeList<T>.
            //Implement a constructor that takes the fixed capacity of the list as  parameter.
            //Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            //Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.

            try
            {
                FixedSizeList<int> fixedList = new FixedSizeList<int>(3);
                fixedList.Add(10);  // Add elements
                fixedList.Add(20);
                fixedList.Add(30);
                fixedList.Add(40);  // This will throw an exception
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);  // Output: "Cannot add more elements, the list is full"
            }

            try
            {
                FixedSizeList<int> fixedList = new FixedSizeList<int>(3);
                fixedList.Add(10);  // Add one element

                int invalidElement = fixedList.Get(3);  // This will throw an exception
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);  // Output: "Index is out of range"
            }
            #endregion

            #region Question 5 : Given a string, find the first non-repeated character in it and return its index. If there is no such character, return 
            ////Hint: you can use dictionary

            string input = "Ahmed";
            int index = Helper<int>.FirstnonrepeatedChar(input);

            if (index != -1)
            {
                Console.WriteLine($"The first non-repeated character is at index: [{index}]"); //The first non-repeated character is at index: [0]
            }
            else
            {
                Console.WriteLine("No non-repeated character found.");
            }

            #endregion
        }
    }
}
