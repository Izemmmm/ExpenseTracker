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

    public string GetNiceView()
    {
        string niceView = "----------------------------------------\n";
        foreach(Expense expense in Expenses)
        {
            niceView += $"Amount: ${expense.Amount}\n";
            niceView += $"Description: ${expense.Description}\n";
            niceView += $"Date: ${expense.Date}\n\n";
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
