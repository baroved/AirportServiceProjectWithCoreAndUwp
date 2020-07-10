using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Models;
using ServerCore.Services;

namespace ServerCore.Infra
{
    public interface IAirportService
    {
        Task<List<Station>> TakeOff(EstimatedTakeOff flight);
        event Action<List<Station>> OnAirplaneMove;
        event Action<List<Station>> FlightProcess;
        Task<List<Station>> ContinueFlightProcess(Station st);
        Task<int> CheckAvalibleStation(int idStation);
        Task<Station> GetStationByID(int idStation);
        Task<bool> CheckLastStation(int idStation);
    }
}
