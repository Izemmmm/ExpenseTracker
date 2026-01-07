namespace ExpenseTracker.Tracker;

public class ExpenseList
{
    List<Expense> Expenses {get; } = new List<Expense>();

    public void AddExpense(int amount, string description = "")
    {
        Expense newExpense = new Expense(amount, description);
        Expenses.Add(newExpense);
    }

    public void AddExpense(Expense newExpense)
    {
        Expenses.Add(newExpense);
    }

    public override string ToString()
    {
        string niceView = "----------------------------------------";
        for(int i = 0; i < Expenses.Count; ++i)
        {
            niceView += $"\n{i}#\n";
            niceView += $"Amount: ${Expenses[i].Amount}\n";
            niceView += $"Description: ${Expenses[i].Description}\n";
            niceView += $"Date: ${Expenses[i].Date}\n";
        }
        niceView += "----------------------------------------\n";

        return niceView;
    }

    public int GetExpenseTotal()
    {
        int total = 0;
        foreach(Expense expense in Expenses)
        {
            total += expense.Amount;
        }

        return total;
    }
}
