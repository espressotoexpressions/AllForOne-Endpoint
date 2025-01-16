using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllForOne_Endpoint.Services;
using AllForOne_Endpoint.Models;

namespace AllForOne_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadlibController : ControllerBase
    {
        private readonly MadlibServices _madlibServices;
        public MadlibStory madlibStory = new MadlibStory();

        public MadlibController(MadlibServices madlibServices)
        {
            _madlibServices = madlibServices;
        }

        [HttpGet]
        [Route("Madlib/{noun1},{adjective2},{number3}, {noun4},{noun5},{adjective6},{noun7},{number8},{number9},{adjective10},{adverb11},{noun12}")]

        public string GenerateStory(string noun1, string adjective2, string number3, string noun4, string noun5, string adjective6, string noun7, string number8, string number9, string adjective10, string adverb11, string noun12)
        {
            madlibStory.Noun1 = noun1;
            madlibStory.Adjective2 = adjective2;
            madlibStory.Number3=number3;
            madlibStory.Noun4 = noun4;
            madlibStory.Noun5 = noun5;
            madlibStory.Adjective6 = adjective6;
            madlibStory.Noun7 = noun7;
            madlibStory.Number8 = number8;
            madlibStory.Number9 = number9;
            madlibStory.Adjective10 = adjective10;
            madlibStory.Adverb11 =adverb11;
            madlibStory.Noun12 = noun12;
            
            return _madlibServices.GenerateStory(madlibStory);
        }
    }
}