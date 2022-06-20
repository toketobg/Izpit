using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public class PersonInteract
    {
        private static readonly PersonContext ctx = DBContextManager.GetPersonContext();
        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Person Interaction Menu!");
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
            Console.WriteLine("SSN: ");
            string ssn = Console.ReadLine();
            //Change 
            Console.WriteLine("First Name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("DoB: ");
            string dob = Console.ReadLine();
            Person item = new Person(ssn, fname, lname, dob);
            ctx.Create(item);
        }
        public static void Read()
        {
            Console.WriteLine("SSN: ");
            string id = Console.ReadLine();
            Person item = ctx.Read(id);
            Console.WriteLine(item.ToString());
            Console.ReadKey();
        }
        public static void ReadAll()
        {
            List<Person> items = ctx.ReadAll().ToList();
            foreach (Person item in items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
        public static void Update()
        {
            //Change
            Console.WriteLine("SSN: ");
            string ssn = Console.ReadLine();
            //Change 
            Console.WriteLine("First Name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("DoB: ");
            string dob = Console.ReadLine();
            Person item = new Person(ssn, fname, lname, dob);
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

