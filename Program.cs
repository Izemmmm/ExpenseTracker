using ExpenseTracker.Enums;

MenuOption chosenOption = MenuOption.Default;
string? input = "";

Console.WriteLine("Welcome to Expense tracker!");
Console.WriteLine("Menu:");
Console.WriteLine("1. Add new expense");
Console.WriteLine("2. View expenses");
Console.WriteLine("3. Exit");

while(chosenOption != MenuOption.Exit)
{
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

            break;
        case MenuOption.View:
        
            break;
        default:
            break;
    }
}