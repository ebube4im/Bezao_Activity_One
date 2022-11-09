// See https://aka.ms/new-console-template for more information

using Bezao_Activity_One;


Console.WriteLine("Welcome to BEZAO Task One");

Console.WriteLine("Select the appropraite number to run the required program. Type EXIT to Exit the application");

 
string selectedOption = "";

while (selectedOption != "Exit")
{

    Console.WriteLine("Reply with 1 to run Task One - String Hasher");
    Console.WriteLine("Reply with 2 to run Task Two - Capital Letter indexer");
    Console.WriteLine("Reply with 3 to run Task Three - Date Updater");
    Console.WriteLine("Reply with 4 to run Task Four - Break Continue Sample");
    Console.WriteLine("Reply with 5 to run Task Five - Authentication System");
    Console.WriteLine("Reply with 6 to run Task Six - Library Manager");



    selectedOption = Console.ReadLine();



    switch (selectedOption)
    {
        case "1":
            Console.WriteLine("You have selected Task One");
            StringHasher stringHasher = new StringHasher();
            stringHasher.Run();
            break;

        case "2":
            Console.WriteLine("You have selected Task Two");
            CapitalLetterIndexer capitalLetterIndexer = new CapitalLetterIndexer();
            capitalLetterIndexer.Run();

            break;
        case "3":
            Console.WriteLine("You have selected Task Three");
            DateUpdater dateUpdater = new DateUpdater();
            dateUpdater.Run();
            break;
        case "4":
            Console.WriteLine("You have selected Task Four");
            BreakContinue breakContinue = new BreakContinue();
            breakContinue.Run();
            break;
        case "5":
            Console.WriteLine("You have selected Task Five");
            Authentication authentication = new Authentication();
            authentication.Run();
            break;
        case "6":
            Console.WriteLine("You have selected Task Six");
            LibraryManager manageLibrary = new LibraryManager();
            manageLibrary.Run();
            break;
        default:
            Console.WriteLine("The option you selected is not among the options");

            break;

    }
}