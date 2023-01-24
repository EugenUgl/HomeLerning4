using BoobleSort_;

namespace View_
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int arrSize;
            View.InputValue(Console.ReadLine(), out arrSize);

            Console.Write("Enter higth range: ");
            int hiRange;
            View.InputValue(Console.ReadLine(), out hiRange);

            Console.Write("Enter low range: ");
            int loRange;
            View.InputValue(Console.ReadLine(), out loRange);

            Console.Write("Creaated array: ");
            BoobleSort boobleSort = new();

            if (loRange > hiRange)
            {
                Console.WriteLine("Error: ");
                return;
            }

            var arr = boobleSort.CreateArrayRandom(arrSize, loRange, hiRange);
            View.OutArr(arr);

            Console.Write("Sorted ascending array: ");
            arr = boobleSort.SortArray(arr, true);
            View.OutArr(arr);

            //Descending
            Console.Write("Sorted descending array: ");
            arr = boobleSort.SortArray(arr, false);
            View.OutArr(arr);

            Console.WriteLine($"Sorted descending array: {BoobleSort.NumberOfExchangeOperations}");
        }
    }
}