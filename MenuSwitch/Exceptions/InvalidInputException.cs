using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSwitch.Exceptions
{
    internal class InvalidInputException : Exception
    {

        public InvalidInputException(string message):base (message) { }


        public static void CheckIfInteger(string input, ref int id2)
        {
            if (!int.TryParse(input, out int id3))
            {
                throw new InvalidInputException("Input is not an integer.");
            }

            id2= id3;
        }
    }
}
