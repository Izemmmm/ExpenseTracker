using ExpenseTracker.Enums;

MenuOption chosenOption = MenuOption.Default;
string input = "";

while(chosenOption != MenuOption.Exit)
{
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