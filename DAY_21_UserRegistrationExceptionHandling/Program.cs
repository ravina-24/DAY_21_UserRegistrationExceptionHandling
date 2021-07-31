﻿using System;
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

            string EmailId;
            Console.Write("Enter  Email Id  :");
            EmailId = Console.ReadLine();
            Pattern.CheckEmail(EmailId);

            string PhoneNumber;
            Console.Write("Enter Phone Number : ");
            PhoneNumber = Console.ReadLine();
            Pattern.CheckNumber(PhoneNumber);

            string Password;
            Console.Write("Enter Password : ");
            Password = Console.ReadLine();
            Pattern.CheckPassword(Password);


            Console.ReadKey();
        }
    }
}
