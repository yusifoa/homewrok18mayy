using System;

namespace homevork18may
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 2, 3, 4, 7 };
            int[] secondArray = { 2, 3 };

            Console.WriteLine(IsArrayContains(firstArray, secondArray));

        }
        static bool IsArrayContains(int[] Array1, int[] Array2)
        {
            string ConvertFirstArr = string.Join(",", Array1);
            string ConvertSecArr = string.Join(",", Array2);

            if (ConvertSecArr.Length <= ConvertFirstArr.Length)
            {
                if (ConvertFirstArr.Contains(ConvertSecArr))
                    return true;
            }
            return false;
        }
    }
}
