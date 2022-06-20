using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public class RPUInteract
    {
        private static readonly RPUContext ctx = DBContextManager.GetRPUContext();
        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the RPU Interaction Menu!");
                Console.WriteLine("Choose option:");
                Console.WriteLine("1) Create\n2) Read\n3) ReadAll\n4) Update\n5) Delete");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        Read();
                        break;
                    case 3:
                        ReadAll();
                        break;
                    case 4:
                        Update();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        Console.WriteLine("No such option");
                        Start();
                        break;
                }
            }
        }
        public static void Create()
        {
            //Change 
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Number: ");
            int num = Convert.ToInt16(Console.ReadLine());
            RPU item = new RPU(city, num);
            ctx.Create(item);
        }
        public static void Read()
        {
            Console.WriteLine("SSN: ");
            string id = Console.ReadLine();
            RPU item = ctx.Read(id);
            Console.WriteLine(item.ToString());
            Console.ReadKey();
        }
        public static void ReadAll()
        {
            List<RPU> items = ctx.ReadAll().ToList();
            foreach (RPU item in items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
        public static void Update()
        {
            //Change
            Console.WriteLine("ID: ");
            string id = Console.ReadLine();
            //Change 
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Number: ");
            int num = Convert.ToInt16(Console.ReadLine());
            RPU item = new RPU(id, city, num);
            ctx.Update(item);
        }
        public static void Delete()
        {
            Console.WriteLine("SSN: ");
            string id = Console.ReadLine();
            ctx.Delete(id);
        }

    }
}

