using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationExceptionHandling
{
    public class Pattern
    {
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);

        }
        public static void checkFirstName(string FirstName)
        {
            try
            { 
                if (FirstName == String.Empty || FirstName == " ")
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.NULL_FIELD,"Field is empty ");
                }
                else  if (Regex.IsMatch(FirstName, Regex_FirstName) == false )
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.INVALID_INPUT,"Invalid input please check the first letter ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Field  ={0}", e.Message);
            }
        }


    }
}
