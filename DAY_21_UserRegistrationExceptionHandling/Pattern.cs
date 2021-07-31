using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationExceptionHandling
{
    public class Pattern
    {
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
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
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(FirstName, Regex_FirstName) == false)
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.INVALID_INPUT,
                        "Invalid FirstName please check the first letter ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Field exception ={0}", e.Message);
            }
        }
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);

        }
        public static void checkLastName(string LastName)
        {
            try
            {
                if (LastName == String.Empty || LastName == " ")
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(LastName, Regex_FirstName) == false)
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.INVALID_INPUT,
                        "Invalid LastName please check the first letter ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Field exception ={0}", e.Message);
            }

        }
    }
}