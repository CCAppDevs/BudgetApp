using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    public class App
    {
        private bool isRunning = false;
        private List<BudgetItem> Items = new List<BudgetItem>();

        public App()
        {
            Run();
        }

        private void Run()
        {
            isRunning = true;

            // start our loop
            while (isRunning)
            {
                Console.Clear();
                PrintMenu();

                // prompt for a choice
                Console.Write("What would you like to do? (0-9) ");
                int answer = Convert.ToInt32(Console.ReadLine());

                switch (answer)
                {
                    case 0:
                        isRunning = false;
                        break;
                    case 1:
                        AddBudgetItem();
                        break;
                    case 2:
                        PrintBudget();
                        Console.ReadLine();
                        break;
                    case 3:
                        SaveBudget();
                        Console.ReadLine();
                        break;
                    default:
                        Console.Write("Press enter to try again...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        public void AddBudgetItem()
        {
            Console.Write("What is the name of the item you wish to add? ");
            string name = Console.ReadLine();
            Console.Write("How much is budgeted for the item? ");
            double budget = Convert.ToDouble(Console.ReadLine());

            int id = Items.Count + 1;

            Items.Add(new BudgetItem(id, name, budget));
        }

        public void PrintBudget()
        {
            Console.WriteLine();
            Console.WriteLine("Printing the budget");
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("---- The Budget----");
            Console.WriteLine("-------------------");

            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }

        public void SaveBudget()
        {
            Console.WriteLine("Saving the budget to file.");
        }



        public void PrintMenu()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("---- Main Menu ----");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("1. Add a new Budget Item");
            Console.WriteLine("2. Print the Budget"); // Read all items from the file
            Console.WriteLine("3. Save All Budget Items");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
        }
    }
}
