using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.ObjectPool;

namespace AllForOne_Endpoint.Services
{
    public class AddOrEvenServices
    {
        public string IsItOddOrEven(string num)
        {

            int num1 = 0;
            bool isValidInteger = int.TryParse(num, out num1);

            if (isValidInteger == false){
                return "Error: Enter a valid integer!";
            }
            else{

                if (num1 % 2 == 0){

                    return $"{num1} is an even number!";
                }
                else{

                    return ($"{num1} is an odd number!");


                }

            }

        }
    }
}