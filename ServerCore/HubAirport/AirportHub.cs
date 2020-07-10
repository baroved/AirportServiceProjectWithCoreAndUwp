using Common.Models;
using Microsoft.AspNetCore.SignalR;
using ServerCore.Infra;
using ServerCore.Repositories;
using ServerCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ServerCore.HubAirport
{
    public class AirportHub : Hub
    {
        private readonly IAirportService _airportService;
        IHubContext<AirportHub> _context;

        public AirportHub(IAirportService airportService, IHubContext<AirportHub> context)
        {
            _context = context;
            _airportService = airportService;
            RegisterToEvent();
        }

        public void RegisterToEvent()
        {
            _airportService.OnAirplaneMove += async (list) =>
            {
                await UpdateClientsFromStart(list);
            };
            _airportService.FlightProcess += async (list) =>
            {
                await UpdateClients(list);
            };
        }

        public async void IncomingFlight(EstimatedTakeOff flight)
        {
            await _context.Clients.All.SendAsync("IncomePlane", flight);
        }

        public async Task UpdateClientsFromStart(List<Station> list)
        {
            await _context.Clients.All.SendAsync("UpdateAirport", list);
        }

        public async Task UpdateClients(List<Station> list)
        {
            await _context.Clients.All.SendAsync("UpdateAirport", list);
        }

    }
}
