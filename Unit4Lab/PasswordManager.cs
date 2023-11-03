using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4Lab
{
    public class PasswordManager
    {
        public PasswordManager()
        {
                
        }
        private bool continueGoing = true;

        //Unit 4 Version
        //public void ActivatePwManager()
        //{
            //while (continueGoing)
            //{
            //    Console.WriteLine("Enter your password:");
            //    string pw1 = Console.ReadLine();
            //    Console.WriteLine("Enter your password again:");
            //    string pw2 = Console.ReadLine();
            //    if (pw1 == pw2)
            //    {
            //        Console.WriteLine("You have successfully created your password.");
            //        continueGoing = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your passwords didn't match. Please start over.");
            //    }
            //}
        //}

        //Unit 5 version
        public void ActivatePwManager()
        {
            Console.WriteLine("Enter your password:");
            string pw1 = Console.ReadLine();

            int numPasswordAttempts = 3;
            for(int i = numPasswordAttempts; i>0; i--)
            {
                Console.WriteLine("Enter your password again:");
                string pw2 = Console.ReadLine();
                if (pw1 == pw2)
                {
                    Console.WriteLine("You have successfully created your password.");
                    break;
                }
                else
                {
                    Console.WriteLine("Your passwords didn't match.");
                }
                if (i == 1)
                {
                    Console.WriteLine("You have been locked out.");
                }
            }
        }
    }
}
