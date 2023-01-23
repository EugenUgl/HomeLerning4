namespace View_
{
    static class View
    {
        public static bool InputValue(string? strValue, out int value)
            => int.TryParse(strValue, out value);
        

        public static void OutArr(int[] arr)
        {
            foreach (var item in arr) 
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}