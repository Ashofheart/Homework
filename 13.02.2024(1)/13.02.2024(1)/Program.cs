using System;

namespace Program
{
    class Console1
    {
        public static void Main()
        {
            Ancet();
            IMT();
            PointsMod();
            ChangeInts();
            SayInform();
        }
        public static void Ancet()
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("My name is " + name + " " + surname + ", I\'m " + age + " years old. My height is " + height + ", my weight is " + weight + "!\n");
            Console.WriteLine("My name is {0} {1}, I\'m {2} years old, my height is {3} and weight is {4}!\n", name, surname, age.ToString(), height.ToString(), weight.ToString());
            Console.WriteLine($"My name is {name} {surname}, I\'m {age.ToString()} years old, my height is {height.ToString()} and weight is {weight.ToString()}!");
        }
        public static void IMT()
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine(((float)w / h / h).ToString());
        }
        public static void PointsMod()
        {
            int x1 = int.Parse(Console.ReadLine()), y1 = int.Parse(Console.ReadLine()), x2 = int.Parse(Console.ReadLine()), y2 = int.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(r);
        }
        public static void ChangeInts()
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            a *= b;
            b = a / b;
            a /= b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static void SayInform()
        {
            string s = " ";
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                s += " ";
            }
            Console.WriteLine("Ivan");
            Console.WriteLine("Baturin");
            Console.WriteLine("Kazan");
            Console.WriteLine(s.Substring(0, Console.WindowWidth / 2 - 2) + "Ivan" + s.Substring(0, Console.WindowWidth / 2 - 2));
            Console.WriteLine(s.Substring(0, Console.WindowWidth / 2 - 3) + "Baturin" + s.Substring(0, Console.WindowWidth / 2 - 4));
            Console.WriteLine(s.Substring(0, Console.WindowWidth / 2 - 2) + "Kazan" + s.Substring(0, Console.WindowWidth / 2 - 1));
        }
    }
}