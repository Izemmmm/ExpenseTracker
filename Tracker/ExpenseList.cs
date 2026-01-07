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

    public bool DeleteExpense(int number)
    {
        int index = number - 1;
        if (index < 0 || index >= Expenses.Count)
        {
            return false;
        }

        Expenses.RemoveAt(index);
        return true;
    }

    public override string ToString()
    {
        string niceList = "----------------------------------------";
        for (int i = 0; i < Expenses.Count; ++i)
        {
            niceList += $"\n{i + 1}#\n";
            niceList += Expenses[i].ToString(); 
        }
        niceList += "----------------------------------------\n";

        return niceList;
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
