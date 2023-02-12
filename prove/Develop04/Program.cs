using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your fancy journal!");
        int menuOption;
        do 
    {
        Menu mainMenu = new Menu();
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        menuOption = int.Parse(Console.ReadLine());
 
    if (menuOption == 1)
    {
        mainMenu.Write();
    }
    } while (menuOption != 5);
}
}

