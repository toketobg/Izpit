using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public class CarInteract
    {
        private static readonly CarContext ctx = DBContextManager.GetCarContext();
        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Car Interaction Menu!");
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
            Console.WriteLine("License Plate: ");
            string lp = Console.ReadLine();
            Console.WriteLine("Make: ");
            string make = Console.ReadLine();
            Console.WriteLine("Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Year: ");
            int year = Convert.ToInt16(Console.ReadLine());
            Car item = new Car(lp, make, model, color, year);
            ctx.Create(item);
        }
        public static void Read()
        {
            Console.WriteLine("License Plate: ");
            string lp = Console.ReadLine();
            Car item = ctx.Read(lp);
            Console.WriteLine(item.ToString());
            Console.ReadKey();
        }
        public static void ReadAll()
        {
            List<Car> items = ctx.ReadAll().ToList();
            foreach (Car item in items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
        public static void Update()
        {
            Console.WriteLine("License Plate: ");
            string lp = Console.ReadLine();
            Console.WriteLine("Make: ");
            string make = Console.ReadLine();
            Console.WriteLine("Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Year: ");
            int year = Convert.ToInt16(Console.ReadLine());
            Car item = new Car(lp, make, model, color, year);
            ctx.Update(item);
        }
        public static void Delete()
        {
            Console.WriteLine("License Plate: ");
            string id = Console.ReadLine();
            ctx.Delete(id);
        }

    }
}

