using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
   public interface IFlightService
    {
        Task<Station> SendFlight(EstimatedTakeOff estimatedTakeOff);
    }
}
