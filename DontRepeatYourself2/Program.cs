using System;

namespace DontRepeatYourself2
{
    class Program
    {
        private static Student[] _students;
        private static string[] _resources;

        static void Main(string[] args)
        {
            Initialise();
            DisplayMainMenu();
        }

        private static void Initialise()
        {
            _students = new []
            {
                new Student { Name = "Ahmed", AccountBalance = 50.01m },
                new Student { Name = "Robert", AccountBalance = 36.79m },
                new Student { Name = "Sue", AccountBalance = 114.12m },
                new Student { Name = "Catherine", AccountBalance = 58.21m },
                new Student { Name = "Jitinder", AccountBalance = 9.70m },
                new Student { Name = "James", AccountBalance = 102.30m },
                new Student { Name = "Rihanna", AccountBalance = 78.54m }
            };

            _resources = new []
            {
                "Library",
                "Printer 1",
                "Printer 2",
                "Meeting Room 1",
                "Meeting Room 2",
                "Conference Room 1"
            };
        }

        private static void DisplayMainMenu()
        {
            Console.WriteLine("Please enter a numerical selection:");
            Console.WriteLine("1 - View Students");
            Console.WriteLine("2 - View Available Resources");
            Console.WriteLine("3 - View Student Accounts");
            Console.WriteLine("4 - Exit");
            var selectedAction = Console.ReadLine();
            SelectItem(selectedAction);
        }

        static void SelectItem(string menuSelection)
        {
            Console.Clear();
            switch (menuSelection)
            {
                case "1":
                    ViewStudents();
                    break;
                case "2":
                    ViewResources();
                    break;
                case "3":
                    ViewAccounts();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("I'm sorry, that's not a valid selection. ");
                    Console.WriteLine("");
                    DisplayMainMenu();
                    break;
            }
        }

        static void ViewStudents()
        {
            foreach (var student in _students)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("");
            DisplayMainMenu();
        }

        static void ViewAccounts()
        {
            foreach (var student in _students)
            {
                Console.WriteLine("{0} - {1:C}", student.Name, student.AccountBalance);
            }
            Console.WriteLine("");
            DisplayMainMenu();
        }

        static void ViewResources()
        {
            foreach (var resource in _resources)
            {
                Console.WriteLine(resource);
            }
            Console.WriteLine("");
            DisplayMainMenu();
        }
    }
}