using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    public class BudgetItem
    {
        // what describes a budget item
        public int BudgetId { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }

        public BudgetItem(int id, string name, double amount)
        {
            BudgetId = id;
            Name = name;
            Amount = amount;
        }

        public override string? ToString()
        {
            return $"{ BudgetId } - { Name } - { Amount }";
        }
    }
}
