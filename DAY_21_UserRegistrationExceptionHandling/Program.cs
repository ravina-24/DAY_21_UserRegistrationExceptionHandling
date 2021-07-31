using System;
using UserRegistrationExceptionHandling;

namespace UserRegistrationExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration  ");

            string FirstName;
            Console.Write("Enter First Name : ");
            FirstName = Console.ReadLine();
            Pattern.checkFirstName(FirstName);

            string Lastname;
            Console.Write("Enter Last Name : ");
            Lastname = Console.ReadLine();
            Pattern.checkLastName(Lastname);
            Console.ReadKey();
        }
    }
}
