namespace Assignment_Session_1_Advanced_C_
{
    internal static class Helper<T> where T : IComparable<T>
    {
        #region Methods 

        //ReverseArray Method For Question 2
        public static void ReverseArray(T[] array)
        {

            if (array != null)
            {
                int start = 0;
                int end = array.Length - 1;

                while (start < end)
                {
                    SWAP(ref array[start], ref array[end]);
                    start++;
                    end--;
                }
            }
        }
        //Generics Method
        public static void SWAP(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }



        //GetEvenNumbers Method For Question 3
        public static T[] GetEvenNumbers(T[] inputArray)
        {
            int evenCount = 0;

            foreach (var number in inputArray)
            {
                if (number is int && (int)(object)number % 2 == 0)
                {
                    evenCount++;
                }
            }

            T[] evenNumbers = new T[evenCount];
            int index = 0;

            foreach (var number in inputArray)
            {
                if (number is int && (int)(object)number % 2 == 0)
                {
                    evenNumbers[index++] = number;
                }
            }

            return evenNumbers;  // Return the array of even numbers
        }

        //FirstnonrepeatedChar Method For Question 5
        public static int FirstnonrepeatedChar(string s)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charFrequency.ContainsKey(c))
                {
                    charFrequency[c]++;
                }
                else
                {
                    charFrequency[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charFrequency[s[i]] == 1)
                {
                    return i; // Return the index of the first non-repeated character
                }
            }

            return -1; // Return -1 if no non-repeated character is found
        }

        #endregion
    }
}
