using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne_Endpoint.Services
{
    public class WakeUpNameService
    {
        //  public string wakeUpStr="";
        public WakeUpNameService()
        {

        }

        public string GetWakeUpName(string name, string wakeUpTime)
        {

            return "Hello, " + name + ". You woke up at " + wakeUpTime + ".";
        }
    }
}