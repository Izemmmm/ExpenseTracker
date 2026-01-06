namespace ExpenseTracker.Tracker;

public class ExpenseList
{
    List<Expense> Expenses {get; } = new List<Expense>();

    public void AddExpense(int amount, string description = "")
    {
        Expense newExpense = new Expense(amount, description);
        Expenses.Add(newExpense);
    }
}
