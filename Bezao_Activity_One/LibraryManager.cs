using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezao_Activity_One
{
    public class LibraryManager
    {
        
        public void Run()
        {
            Console.WriteLine("Welcome to Library Manager. Type Exit when you want to End the application.");
            
            Console.WriteLine("What would you love to read?");
            string selectedOption = "";

            while (selectedOption != "Exit")
            {

                Console.WriteLine("Reply with the appropraite letters to select the books category");
                Console.WriteLine("Reply c for C# books");
                Console.WriteLine("Reply o for .Net core books");
                Console.WriteLine("Reply d for clean coding books");
                Console.WriteLine("Reply e for EFCore books");


                 selectedOption = Console.ReadLine();



                switch (selectedOption)
                {
                    case "c":
                        Console.WriteLine("You have selected c# books, we have the following: 1. Beginner C#, C# in 3days");
                        break;
                    case "o":
                        Console.WriteLine("You have selected .Net Core books, we have the following: 1. Learn .Net Core, .Net Core in 3days");
                        break;
                    case "d":
                        Console.WriteLine("You have selected Clean coding books, we have the following: 1. The Art of clean coding, 2. Keep it clean");
                        break;
                    case "e":
                        Console.WriteLine("You have selected EFCore books, we have the following: 1. EFCORE way C#, EFCore in 10hrs");
                        break;
                    default:
                        Console.WriteLine("The option you selected is not among the options");

                        break;

                }

            }


    }
    }
}
