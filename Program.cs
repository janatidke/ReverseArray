using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[] { 12, 11, 14, 13 };
            int temp = 0;

            for (int i = 0; i <= Array.Length - 1; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] < Array[j])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in descending order");
            foreach (var item in Array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
