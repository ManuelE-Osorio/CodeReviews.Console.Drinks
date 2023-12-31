namespace DrinksProgram;

public class UI
{
    public static void WelcomeMessage()
    {
        Helpers.ClearConsole();
        Console.WriteLine("Welcome to the Flash Cards App!\n");
        Thread.Sleep(2000);
    }

    public static void MainMenu(string? errorMessage)
    {
        Helpers.ClearConsole();
        
        if (errorMessage != null)
        {
            Console.WriteLine("Error: " + errorMessage+"\n");
        }

        Console.WriteLine(
            "Please write the name of the category:"); //make it fancier
    }
}