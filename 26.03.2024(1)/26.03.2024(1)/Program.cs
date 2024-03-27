using System;
using System.Numerics;

namespace ConsoleApp
{
    class Program
    {
        static List<string> secList = new List<string> { "Unconfidencial", "Codenficial", "Sicret", "Top-sicret" };
        static List<string> userList = new List<string> { "Admin", "User1", "User2", "User3", "User4", "User5" };
        static List<int> secOfUsers = new List<int>();
        static List<string> fileList = new List<string> { "File1.txt", "File2.txt", "File3.txt", "File4.txt", "File5.txt" };
        static List<int> secOfFiles = new List<int>();

        static void Main()
        {
            Random rand = new Random();
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i] != "Admin")
                {
                    secOfUsers.Add(rand.Next(0, secList.Count - 1));
                }
                else
                {
                    secOfUsers.Add(secList.Count - 1);
                }
            }

            int UserIndex = 10;
            bool RightInput;
            RightInput = false;
            while (!RightInput)
            {
                Console.WriteLine("Who are you?");
                for (int i = 0; i < userList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {userList[i]}({secList[secOfUsers[i]]})");
                }

                string User = Console.ReadLine();
                if (userList.IndexOf(User) != -1)
                {
                    RightInput = true;
                    UserIndex = secOfUsers[userList.IndexOf(User)];
                }
                else
                {
                    Console.WriteLine("Uncorrect login");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                Console.Clear();
            }

            for (int i = 0; i < fileList.Count; i++)
            {
                secOfFiles.Add(rand.Next(0, secList.Count));
            }

            string comand;
            while (true)
            {
                Console.WriteLine("List of comands:");
                Console.WriteLine("1) read");
                Console.WriteLine("2) write");
                Console.WriteLine("List of files:");
                for (int i = 0; i < fileList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {fileList[i]}({secList[secOfFiles[i]]})");
                }
                Console.Write("comand>");
                comand = Console.ReadLine();

                if (comand.Substring(0, 4) == "read")
                {
                    if (fileList.IndexOf(comand.Substring(5, comand.Length - 5)) != -1)
                    {
                        if (UserIndex >= secOfFiles[fileList.IndexOf(comand.Substring(5, comand.Length - 5))])
                        {
                            Console.WriteLine($"Succes to read {comand.Substring(5, comand.Length - 5)}");
                        }
                        else
                        {
                            Console.WriteLine("Security error");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid file name");
                    }
                }
                else if(comand.Substring(0, 5) == "write"){
                    if (fileList.IndexOf(comand.Substring(6, comand.Length - 6)) != -1)
                    {
                        if (UserIndex <= secOfFiles[fileList.IndexOf(comand.Substring(6, comand.Length - 6))])
                        {
                            Console.WriteLine($"Succesfull write {comand.Substring(6, comand.Length - 6)}");
                        }
                        else
                        {
                            Console.WriteLine("Security error");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid file name");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid comand");
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}