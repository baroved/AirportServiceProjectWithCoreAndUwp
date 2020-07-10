using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace Extend
{
    public class FlightService : IFlightService
    {
        private readonly IHttpService _httpService;
        public FlightService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task<Station> SendFlight(EstimatedTakeOff estimatedTakeOff)
        {
            return await _httpService.PostAsync<EstimatedTakeOff, Station>("/Flight/Takeoff", estimatedTakeOff);
        }
    }
}
