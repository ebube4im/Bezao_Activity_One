using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezao_Activity_One
{
    public class Authentication
    {
        public class User
        {

            public string Username { get; set; }
            public string Password { get; set; }
            public bool IsAuthenticated { get; set; }

        }


        public List<User>? Users { get; set; } = new List<User> { };

       

        public void Run()
        {
            Console.WriteLine("Welcome to the Authentication System");
       
           string selectedOption = "";

            while (selectedOption != "Exit")
            {

                Console.WriteLine("Which operation do you want to perform? Type L to Login, R to Register new account");

                selectedOption = Console.ReadLine();



                switch (selectedOption.ToUpper())
                {
                    case "L":
                        Login();
                        break;
                    case "R":
                        Register();
                        break;
                     default:
                        Console.WriteLine("The option you selected is not among the options");

                        break;

                }

            }


        }

        public void Login()
        {
            Console.WriteLine("Login Page | Enter your details to login");
           
            User user = new User();
            Console.WriteLine("Enter your Username");
            user.Username = Console.ReadLine();

            Console.WriteLine("Enter your password");
            user.Password = Console.ReadLine();

         
            user.IsAuthenticated = Users.Any(c => c.Username == user.Username && c.Password == user.Password);
           
            Console.WriteLine(user.IsAuthenticated);
            if (user.IsAuthenticated)
            {
                Console.WriteLine("Your Login was successful, You will be redirected shortly...");
            }
            else
            {
                Console.WriteLine("One or more fields are not correct!");
            }




        }

        public void Register()
        {
            Console.WriteLine("Registration Page | Enter your details to Register");

            User newUser = new User();

            Console.WriteLine("Enter your Username");
            newUser.Username = Console.ReadLine();

            Console.WriteLine("Enter a suitable password");
            newUser.Password = Console.ReadLine();

            Console.WriteLine("You have entered the following details Username: {0} , Password: {1}", newUser.Username, newUser.Password);

            Users = new List<User> { newUser };

            Console.WriteLine("Your Registeration was successfull, You will be redirected to the Login Page");
            Login();
           
        }


    }
}
