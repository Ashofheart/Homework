using System;

namespace Fib
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            string puth = "fib.txt";
            using (StreamWriter sw = new StreamWriter(puth))
            {
                for (int i = 0; i < n; i++)
                {
                    sw.Write((arr[i]).ToString() + " ");
                }
            }
        }
    }
}