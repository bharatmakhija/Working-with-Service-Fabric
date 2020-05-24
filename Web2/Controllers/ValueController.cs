using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using CalculatorService.Interface;

/// <summary>
/// ValueController.cs
/// </summary>
namespace Web2.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ValueController
    {

        [HttpGet]
        public int Add(int a, int b)
        {
            var calculatorClient = ServiceProxy.Create<ICalculatorService>(
            new Uri("fabric:/CalculatorApplication/CalculatorService"));
            return calculatorClient.Add(a, b).Result;
        }

        [HttpGet]
        public int Substract(int a, int b)
        {
            var calculatorClient = ServiceProxy.Create<ICalculatorService>(
            new Uri("fabric:/CalculatorApplication/CalculatorService"));
            return calculatorClient.Substract(a, b).Result;
        }


        [HttpGet]
        public int Multiply(int a, int b)
        {
            var calculatorClient = ServiceProxy.Create<ICalculatorService>(
            new Uri("fabric:/CalculatorApplication/CalculatorService"));
            return calculatorClient.Multiply(a, b).Result;
        }


        [HttpGet]
        public int Divide(int a, int b)
        {
            var calculatorClient = ServiceProxy.Create<ICalculatorService>(
            new Uri("fabric:/CalculatorApplication/CalculatorService"));
            return calculatorClient.Divide(a, b).Result;
        }
    }
}
