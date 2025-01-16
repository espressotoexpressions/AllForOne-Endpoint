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
    public class MagicEightBallController : ControllerBase
    {
        private readonly MagicEightBallServices _magicEightBallServices;

        public MagicEightBallController(MagicEightBallServices magicEightBallServices)
        {
            _magicEightBallServices =magicEightBallServices;
        }
        
        [HttpGet]
        [Route("GetAnswer/{question}")]

        public string GetAnswer(string question)
        {
            return _magicEightBallServices.GetAnswer(question);
        }


    }
}