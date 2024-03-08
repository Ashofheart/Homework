using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    struct Complex
    {
        public double re;
        public double im;

        public override string ToString()
        {
            return $"{re} + {im}i";
        }
        public static Complex Plus(Complex p1, Complex p2)
        {
            Complex ret;
            ret.re = p1.re + p2.re;
            ret.im = p1.im + p2.im;
            return ret;
        }

        public Complex Plus(Complex p1)
        {
            this.re += p1.re;
            this.im += p1.im;
            return this;
        }

        public Complex Minuse(Complex p1)
        {
            this.re += p1.re;
            this.im += p1.im;
            return this;
        }

        public static Complex Minuse(Complex p1, Complex p2)
        {
            p1.re += p2.re;
            p1.im += p2.im;
            return p1;
        }
        public Complex Umn(Complex p1)
        {
            this.re *= p1.re;
            this.im *= p1.re;
            return this;
        }
        public static Complex Umn(Complex p1, Complex p2)
        {
            p1.re *= p2.re;
            p1.im *= p2.im;
            return p1;
        }
    }
    public class Fraction
    {
        private int numerator;

        public int Num
        {
            get { return numerator; }
            set { numerator = value; }
        }
        private int denominator;

        public int Den
        {
            get 
            { 
                return denominator; 
            }
            set
            {
                try
                {
                    if (value == 0)
                    {
                        throw new Exception("На ноль делить нельзя!");
                    }
                    else
                    {
                        denominator = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public double frac
        {
            get
            {
                return 1.0 * Num / Den;
            }
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public Fraction(int num, int denom)
        {
            Den = denom;
            Num = num;
        }
    }
    class Program
    {
        public static int SU_OF_NUMS()
        {
            int su = 0;
            int a;
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a != 0 && a > 0 && a % 2 == 1)
                {
                    su += a;
                }
            } while (a != 0);
            return su;
        }
        static void Main(string[] args)
        {
            int n;
            Complex c = new Complex();
            c.re = int.Parse(Console.ReadLine());
            c.im = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("What do we do?\n1) Print num\n2) Init num\n3) Multiply num\n4) Plus num\n5) Minus num");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine(c);
                        break;
                    case 2:
                        c.re = int.Parse(Console.ReadLine());
                        c.im = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        c.Umn(new Complex { re = int.Parse(Console.ReadLine()), im = int.Parse(Console.ReadLine()) });
                        break;
                    case 4:
                        c.Plus(new Complex { re = int.Parse(Console.ReadLine()), im = int.Parse(Console.ReadLine()) });
                        break;
                    case 5:
                        c.Minuse(new Complex { re = int.Parse(Console.ReadLine()), im = int.Parse(Console.ReadLine()) });
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Incorrect input!");
                        break;
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            } while (n != 6);
        }
        public static void Print(out int number)
        {
            number = 10;
            Console.WriteLine($"Переменная number = {number}");
        }
    }
}