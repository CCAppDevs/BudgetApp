namespace BudgetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BudgetItem item1 = new BudgetItem(1, "Rent", 1025.00);
            BudgetItem item2 = new BudgetItem(2, "Water", 100.50);

            App app = new App();
        }
    }
}
