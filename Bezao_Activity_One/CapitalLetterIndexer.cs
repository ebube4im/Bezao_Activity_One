using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezao_Activity_One
{
    public class CapitalLetterIndexer
    {
        public void Run()
        {
            Console.WriteLine("Welcome to Capital Letter Indexer Manager. Type Exit when you want to End the application.");

            Console.WriteLine("Enter a Sentence");
            string Sampletext = "";

            Sampletext = Console.ReadLine();

            List<string> list = new List<string>();

            foreach (char letter in Sampletext)
            {
                if (char.IsUpper(letter))
                {
                    list.Add(Sampletext.IndexOf(letter).ToString());

                     Console.WriteLine(Sampletext.IndexOf(letter));
                                         
                }
            }

          String[] Indices =  list.ToArray();
        }
    } 
}
