using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne_Endpoint.Services
{
    public class SayHelloService
    {
        public string SayHello(string name){
            return "Hello, "+ name+ ". I love your name!";
        }
    }
}