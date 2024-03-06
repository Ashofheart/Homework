using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace ConsoleApp1
{
    class Wwa
    {
        int[] arr;
        public int Sum
        {
            get
            {
                int su = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    su += arr[i];
                }
                return su;
            }
        }
        public int MxCnt
        {
            get
            {
                int mx = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > mx)
                    {
                        mx = arr[i];
                    }
                }
                int ans = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == mx)
                    {
                        ans++;
                    }
                }
                return ans;
            }
        }
        public int[] Inverse()
        {
            int[] newarr = new int[arr.Length];
            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = arr[i] + 1;
            }
            return newarr;
        }
        public void Multi(int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= n;
            }
        }
        public Wwa(int n, int m, int o)
        {
            arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = m;
                m += o;
            }
        }

    }
    static class StCl
    {
        public static int ArrWork(out int[] arr)
        {
            Random rnd = new Random();
            arr = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 10000 + rnd.Next() % 10000;
            }
            int ans = 0;
            int cnt;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                cnt = 0;
                if (arr[i] % 3 == 0)
                {
                    cnt++;
                }
                if (arr[i + 1] % 3 == 0)
                {
                    cnt++;
                }
                if (cnt == 1)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}