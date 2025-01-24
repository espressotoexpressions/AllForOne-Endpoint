using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne_Endpoint.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
     private readonly SayHelloService _sayHelloService;

     public SayHelloController(SayHelloService sayHelloService){
        _sayHelloService = sayHelloService;
     }   

     [HttpGet]
     [Route("SayHello/{name}")]

     public string SayHello(string name){
        return _sayHelloService.SayHello(name);
     }
    }
}