using Common.Models;
using Extend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class Simulator
        {
            List<EstimatedTakeOff> takeoffs = new List<EstimatedTakeOff>()
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
            private readonly IFlightService flightService;

            public Simulator(IFlightService flightService)
            {
                this.flightService = flightService;
                
                something();
                
            }

            public async void something()
            {
                if(await flightService.SendFlight(takeoffs[0]))
                {
                    Console.WriteLine("Works");
                }
            }



        }
    }
}
