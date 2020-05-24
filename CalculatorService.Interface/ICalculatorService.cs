using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.FabricTransport;

namespace CalculatorService.Interface
{
    public interface ICalculatorService : IService
    {
        Task<int> Add(int a, int b);
        Task<int> Substract(int a, int b);

        Task<int> Multiply(int a, int b);

        Task<int> Divide(int a, int b);
    }
}
