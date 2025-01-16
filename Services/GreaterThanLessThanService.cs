using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne_Endpoint.Services
{
    public class GreaterThanLessThanService
    {
        string statement = "";
        public string GetGreaterThanOrLessThan(int num1, int num2)
        {
            if (num1 > num2)
            {
                statement = "First Number is greater than the second number. Second number is less than the first number.";
            }
            else if (num2 > num1)
            {
                statement = "Second number is greater than the first number. First Number is less than the second number.";
            }
            else
                statement = "First number is equal to second number. second number is equal to first number.";

            return statement;
        }
    }
}