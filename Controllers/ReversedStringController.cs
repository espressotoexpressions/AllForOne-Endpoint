using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllForOne_Endpoint.Services;

namespace AllForOne_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReversedStringController : ControllerBase
    {
        private readonly ReverseItServices _reverseItservices;

        public ReversedStringController(ReverseItServices reverseItServices)
        {
            _reverseItservices = reverseItServices;
        }

        [HttpGet]
        [Route("ReverseIt/{inputString}")]

        public string GetReverseString(string inputString)
        {
            return _reverseItservices.GetReverseString(inputString);
        }

    }
}