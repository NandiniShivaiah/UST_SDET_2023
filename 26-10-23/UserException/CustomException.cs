using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.UserException
{
    internal class CustomException
    {
        public static Dictionary<int, string> customMessageList =
            new Dictionary<int, string>()
            {

                {1, "Age should be between 0 and 120" }

            };
    }

    internal class AgeException : Exception
    {
        public AgeException(string? message) : base(message)
        {
        }
    }
}

