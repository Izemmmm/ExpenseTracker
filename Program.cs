using ExpenseTracker.Enums;
using ExpenseTracker.Tracker;

ExpenseList expenses = new ExpenseList();

MenuOption chosenOption = MenuOption.Default;
string? input = "";



while(chosenOption != MenuOption.Exit)
{
    Console.WriteLine("Welcome to Expense tracker!");
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Add new expense");
    Console.WriteLine("2. View expenses");
    Console.WriteLine("3. Total");
    Console.WriteLine("4. Delete expense");
    Console.WriteLine("5. Exit");
    
    input = Console.ReadLine();
    if(!Enum.TryParse(input, out chosenOption))
    {
        Console.WriteLine("Incorrect option, please try again!");
        chosenOption = MenuOption.Default;
        continue;
    }

    switch (chosenOption)
    {
        case MenuOption.Add:
            Expense newExpense = GetExpense();
            expenses.AddExpense(newExpense);
            break;
        case MenuOption.View:
            string overview = expenses.ToString();
            Console.WriteLine("Here is your overview:");
            Console.WriteLine(overview);
            break;
        case MenuOption.Total:
            Console.WriteLine($"Here is your total spending: ${expenses.GetExpenseTotal()}");
            break;
        case MenuOption.Delete:
            ChooseDeleteExpense();
            break;
        default:
            break;
    }
}

void ChooseDeleteExpense()
{
    int expenseNumber;

    Console.WriteLine("Please enter the number of expxense you want to delete. Or 0 to quit.");
    while (true)
    {
        string? input = Console.ReadLine();
        while (!int.TryParse(input, out expenseNumber))
        {
            Console.WriteLine("Incorrect value, try again!");
            input = Console.ReadLine();
        }

        if (expenseNumber == 0)
        {
            return;
        }

        if (expenses.DeleteExpense(expenseNumber))
        {
            Console.WriteLine($"The expense number #{expenseNumber} was deleted succesfully.");
            return;
        }
        else
        {
            Console.WriteLine($"The expense number #{expenseNumber} does not exist, please try again.");
        }
    }
}

Expense GetExpense()
{
    int amount;
    string description = "";

    Console.WriteLine("Please enter amount of your expense.");
    string? input = Console.ReadLine();
    while (!int.TryParse(input, out amount))
    {
        Console.WriteLine("Incorrect value, try again!");
        input = Console.ReadLine();
    }
    
    Console.WriteLine("Please enter description for your expense.");
    input = Console.ReadLine();
    description = input is null ? "" : input;

    return new Expense(amount, description);
}