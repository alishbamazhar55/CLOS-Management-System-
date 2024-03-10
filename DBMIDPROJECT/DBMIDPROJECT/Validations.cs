using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace DBMIDPROJECT
{
    class Validations
    {

        public static string NameValidation(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Name cannot be empty or whitespace.");
            }

            if (!input.All(char.IsLetter))
            {
                throw new Exception("Name should only contain alphabets.");
            }

            return input;
        }

        public static string EmailValidation(string input)
        {
            // Simple email format validation
            if (!Regex.IsMatch(input, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                throw new Exception("Invalid email format ,correct format is  sheikhalishba878@gmail.com.");
            }


            return input;
        }

        public static string IntegerValidation(string input, int expectedLength)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Input cannot be empty or whitespace.");
            }

            if (!input.All(char.IsDigit))
            {
                throw new Exception("Input should only contain digits.");
            }

            if (input.Length != expectedLength)
            {
                throw new Exception($"Input length should be {expectedLength}.");
            }

            return input;
        }
        public static string IntegerValidation1(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Input cannot be empty or whitespace.");
            }

            if (!input.All(char.IsDigit))
            {
                throw new Exception("Input should only contain digits.");
            }

           

            return input;
        }
    }

}
