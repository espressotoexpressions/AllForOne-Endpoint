using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllForOne_Endpoint.Services;

namespace AllForOne_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersService _addTwoNumbersService;

        public AddTwoNumbersController(AddTwoNumbersService addTwoNumbersService)
        {
            _addTwoNumbersService =addTwoNumbersService;
        }

        [HttpGet]
        [Route("GetSumOfTwoNumbers/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            return _addTwoNumbersService.AddTwoNumbers(num1, num2);
          
        }
    }
}