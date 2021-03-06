using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationExceptionHandling
{
    public class Pattern
    {
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
        public static string Regex_EmailId = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public static string Regex_PhoneNumber = "^[0-9]{2}[ ][6-9][0-9]{9}$";

        public static string Regex_Password = "^((?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*-_.])(?=.{8,}))";

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
        public bool ValidateEmailId(string EmailId)
        {
            return Regex.IsMatch(EmailId, Regex_EmailId);

        }
        public static void CheckEmail(string EmailId)
        {
            try
            {
                if (EmailId == String.Empty || EmailId == " ")
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(EmailId, Regex_FirstName) == false)
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.INVALID_INPUT,
                        "Invalid EmailId");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Field exception ={0}", e.Message);
            }
        }
        public bool ValidatePhoneNumber(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, Regex_PhoneNumber);

        }
        public static void CheckNumber(string PhoneNumber)
        {
            try
            {
                if (PhoneNumber == String.Empty || PhoneNumber == " ")
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(PhoneNumber, Regex_PhoneNumber) == false)
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.INVALID_INPUT,
                        "Invalid PhoneNumber  ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Field exception ={0}", e.Message);
            }
        }

        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);

        }
        public static void CheckPassword(string Password)
        {
            try
            {
                if (Password == String.Empty || Password == " ")
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.NULL_FIELD, "Field  is empty ");
                }
                else if (Regex.IsMatch(Password, Regex_Password) == false)
                {
                    throw new ExceptionHandling(ExceptionHandling.ExceptionType.INVALID_INPUT,
                        "Invalid Password. It should  contain atleast 1 special character. ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Field exception ={0}", e.Message);
            }
        }

    }
}