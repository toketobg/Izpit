using System;
using BusinessLayer;
using DataLayer;
using ServiceLayer;

namespace PresentationLayer // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Choose();
        }
        public static void Choose()
        {
            while (true)
            {
                Console.WriteLine("Choose Database to Change");
                Console.WriteLine("1) Car\n2) RPU\n3) Person\n4) Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CarInteract.Start();
                        break;
                    case 2:
                        RPUInteract.Start();
                        break;
                    case 3:
                        PersonInteract.Start();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No such option");
                        break;
                }

            }
        }
    }
}