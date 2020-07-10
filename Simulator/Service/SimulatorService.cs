using Common.Models;
using Extend;
using Simulator.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Service
{
    public class SimulatorService:ISimulator
    {
        
            List<EstimatedTakeOff> Takeoffs;
            private readonly IFlightService flightService;

        public SimulatorService(IFlightService flightService)
        {

        
            this.flightService = flightService;

            Takeoffs = new List<EstimatedTakeOff>()
            {
                new EstimatedTakeOff
                {
                  FlightNum = 213,
                  EstimatedTime = DateTime.Now,
                  PlaneID = 1
                },
                new EstimatedTakeOff
                {
                  FlightNum = 2132,
                  EstimatedTime = DateTime.Now,
                  PlaneID = 2
                }
            };

            Start();

        
    }
        public async void Start()
        {
            if (await flightService.SendFlight(Takeoffs[0]))
            {
                Console.WriteLine("Works");
            }
        }
    }
}
