using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace AllForOne_Endpoint.Services
{
    public class AddTwoNumbersService
    {
        public int sum = 0;

        public AddTwoNumbersService(){ 
            // constructor class
            //enter anything here to run first
        } 

        public string AddTwoNumbers(int num1, int num2)
        {
            sum = num1+num2;
            string sumStr="The sum of "+ num1+" and " +num2+ " is " +sum+".";
            return sumStr;
        }
    }
}