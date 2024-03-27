using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp
{
    class Program
    {
        static void GenNums(string puth)
        {
            int len = 100000;
            using (StreamWriter stream = new StreamWriter(puth))
            {
                Random rand = new Random();
                for (int i = 0; i < len; i++)
                {
                    stream.Write((rand.Next(0, 100000)).ToString() + ' ');
                }
            }
        }
        static List<int> ReadNums(string puth)
        {
            List<int> nums = new List<int>();
            try
            {
                using (StreamReader stream = new StreamReader(puth))
                {
                    string file = stream.ReadToEnd();
                    int num = 0;
                    foreach (char i in file)
                    {
                        if (i == ' ')
                        {
                            nums.Add(num);
                            num = 0;
                        }
                        else
                        {
                            num *= 10;
                            num += Convert.ToInt32(i) - Convert.ToInt32('0');
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid file puth!");
            }
            return nums;
        }
        static long FindMaxInWind(List<int> nums)
        {
            long max = Convert.ToInt64(nums[0]) * Convert.ToInt64(nums[1]);
            for (int i = 7; i < nums.Count; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if (Convert.ToInt64(nums[i - j]) * Convert.ToInt64(nums[i - k]) > max && j != k)
                        {
                            max = Convert.ToInt64(nums[i - j]) * Convert.ToInt64(nums[i - k]);
                        }
                    }
                }
            }
            return max;
        }
        static void Main()
        {
            const string puth = "nums.txt";
            GenNums(puth);
            List<int> nums = ReadNums(puth);
            long res = FindMaxInWind(nums);
            Console.WriteLine(res);
        }
    }
}