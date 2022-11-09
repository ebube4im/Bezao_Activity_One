using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezao_Activity_One
{
    public class DateUpdater
    {

        public void Run()
        {
            Console.WriteLine("Welcome to Date Updater. Type Exit when you want to End the application.");

            Console.WriteLine("Enter a Date to get the updated value!");
            Console.WriteLine("Ensure your date is in the following format  dd/mm/yyyy");
            string selectedOption = "";

            selectedOption = Console.ReadLine();
            while (selectedOption != "Exit")
            {
                Console.WriteLine("You have entered {0}", selectedOption);
                                

                DateTime dateTime = DateTime.Parse(selectedOption);

                dateTime = dateTime.AddDays(7);

                Console.WriteLine(dateTime.ToString());
                break;
            }

        }

            }
}
