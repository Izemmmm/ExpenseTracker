namespace ExpenseTracker.Tracker;

public class Expense
{
    public int Amount {get; set;}
    public string Description {get; set;}
    public DateTime Date {get; set;} = DateTime.Now;

    public Expense(int amount, string description = "")
    {
        Amount = amount;
        Description = description;
    }

    public Expense(int amount, DateTime date, string description = "") : this(amount, description)
    {
        Date = date;
    }
}