using System;

namespace BoobleSort_
{
    public class BoobleSort
    {
        static int numberOfExchangeOperations = 0;
        Random rnd = new Random();

        public static int NumberOfExchangeOperations { get => numberOfExchangeOperations; set => numberOfExchangeOperations = value; }

        public int[] CreateArrayRandom(int arrSize, int minValue, int maxValue)
        {            
            int[] arr = new int[arrSize];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(minValue, maxValue);

            return arr;
        }

        public int[] SortArray(int[] arr, bool Ascending)
        {
            bool condition;

            foreach (var _ in arr)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (Ascending)
                        condition = arr[j] > arr[j + 1];                        
                    else
                        condition = arr[j] < arr[j + 1];                        

                    if (condition)
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        NumberOfExchangeOperations++;
                    }
                        
                }
            }
            return arr;
        }        
    }
}