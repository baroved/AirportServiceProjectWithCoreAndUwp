using Common.Models;
using ServerCore.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerCore.Services
{
    public class SimulatorService
    {
        private List<EstimatedTakeOff> Takeoffs;
        private  readonly IAirportService _airportService;
        
        public SimulatorService(IAirportService iAirportService)
        {
            _airportService = iAirportService;

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

        }
        public void Start()
        {
             _airportService.TakeOff(Takeoffs[0]);
        }
    }
}
