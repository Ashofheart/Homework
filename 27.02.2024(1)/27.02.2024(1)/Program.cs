using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.Serialization.Formatters;
using static System.Net.WebRequestMethods;

namespace Programm
{
    class Console1
    {
        public static void Main()
        {
            Console.WriteLine(Min_three());
            Console.WriteLine(ncnt());
            Console.WriteLine(SumNch());
            Examination();
            Console.WriteLine(IMT());
            OtADoB();
        }
        public static int Min_three()
        {
            int n1 = int.Parse(Console.ReadLine()), n2 = int.Parse(Console.ReadLine()), n3 = int.Parse(Console.ReadLine());
            return Math.Min(Math.Min(n1, n2), n3);
        }
        public static int ncnt()
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            while (n != 0)
            {
                n /= 10;
                cnt++;
            }
            return cnt;
        }
        public static int SumNch()
        {
            int a;
            int su = 0;
            while (true)
            {
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    return su;
                }
                if (a % 2 == 1 && a > 0)
                {
                    su += a;
                }
            }
        }
        public static bool CheckProf(string log, string pas)
        {
            return log == "root" && pas == "ITTop";
        }
        public static void Examination()
        {
            string log;
            string pas;
            int cnt = 1;
            bool pass = false;
            do
            {
                log = Console.ReadLine();
                pas = Console.ReadLine();
                if (CheckProf(log, pas))
                {
                    pass = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Login or password is not right!");
                }
                cnt++;
            } while (cnt <= 3);
            if (pass)
            {
                Console.WriteLine("You passed examination!");
            }
            else
            {
                Console.WriteLine("You failed examination!");
            }
        }
        public static int IMT()
        {
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            double ans = w / Math.Pow(h / 100.0, 2);
            int ans1 = (int)Math.Round(ans, 0);
            if (ans1 < 22)
            {
                Console.WriteLine("You need to eat more!");
            }
            else if (ans1 > 22)
            {
                Console.WriteLine("You need to do sport!");
            }
            return ans1;
        }
        public static void OtADoB(int a = -1, int b = -1)
        {
            if (a == -1 && b == -1)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            }
            if (a < b)
            {
                Console.WriteLine(a);
                OtADoB(a + 1, b);
            }
            else if (a == b)
            {
                Console.WriteLine(a);
            }
        }
    }
}