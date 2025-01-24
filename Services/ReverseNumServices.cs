using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne_Endpoint.Services
{
    public class ReverseNumServices
    {
        public string GetReverseNum(string num)
        {
            int numInput = 0;
            bool isNumValid = int.TryParse(num, out numInput);
            int numReverse = 0;

            // if number is valid then proceed with reversal
            if (isNumValid)
            {

                while (numInput != 0)
                {
                    numReverse = numReverse * 10;  // adds an additional 0 on the numReverse array , increases length of numReverse
                    numReverse += numInput % 10; // picks up the last digit in the numInput and adds it to the numReverse Value
                    numInput = numInput / 10;// removes the last digit of the numInput 

                }
                return numReverse.ToString();

            }

            // else if invalid number, display error message
            else
            {
                return "ERROR: Your input is not a number.";
            }
        }
    }
}