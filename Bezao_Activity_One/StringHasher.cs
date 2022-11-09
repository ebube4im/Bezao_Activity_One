using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezao_Activity_One
{
    internal class StringHasher
    {
      

        public string hashedMessage { get; set; }
         
        public string Run()
        {
            Console.WriteLine("Welcome to String hasher");
             Console.WriteLine("Enter the Text to be hashed without spaces");

            string rawMessage = Console.ReadLine();

            Console.WriteLine(rawMessage);

             
            if (rawMessage.Length <= 4)
            {
                Console.WriteLine("The input string is less than 4 characters");
               
            }
            else
            {

                string lastPart = rawMessage.Substring(rawMessage.Length - 4, 4);

                string firstPart = rawMessage.Substring(0, rawMessage.Length - 4);

                hashedMessage = rawMessage.Replace(firstPart, hashReturn(firstPart));

                Console.WriteLine(hashedMessage);
            }

            return rawMessage;
        }

        public string hashReturn(string text)
        {
            char[] chars = text.ToCharArray();

            string hashchar = "";

            foreach (var item in chars)
            {
                hashchar = hashchar + "#";
            }

            return hashchar;
        }
    }
}
