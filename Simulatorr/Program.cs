using ServerCore.Infra;
using ServerCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulatorr
{
    class Program
    {
        static void Main(string[] args, IAirportService iAirportService)
        {
            SimulatorService simulatorService = new SimulatorService(iAirportService);
        }
    }
}
