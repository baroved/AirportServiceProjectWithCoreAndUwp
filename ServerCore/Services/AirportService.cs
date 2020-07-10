using Common.Models;
using Microsoft.AspNetCore.SignalR;
using ServerCore.Infra;
using ServerCore.Repositories;
using ServerCore.Ripositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore.Services
{

    public class AirportService : IAirportService
    {
        public List<Station> Stations { get; set; }
        public ConnectedStationRepository _repoConStation { get; set; }
        public StationRepository _repoStation { get; set; }
        public PlaneRepository _planeRepository;
        public event Action<List<Station>> OnAirplaneMove;
        public event Action<List<Station>> FlightProcess;

        public AirportService(PlaneRepository planeRepository
            , ConnectedStationRepository repoConStation
            , StationRepository repoStation)
        {
            _planeRepository = planeRepository;
            _repoConStation = repoConStation;
            _repoStation = repoStation;
            Stations = new List<Station>();
            
        }

        public async Task<List<Station>> TakeOff(EstimatedTakeOff flight)
        {
            Stations = await _repoStation.GetAllStations();
            Station st1 = await _repoStation.GetStationById(1);
            if (st1.IsAvailable)
            {
                _repoStation.UpdateFirstStation(flight);
                Stations.Add(st1);
            }
            OnAirplaneMove.Invoke(Stations);
            await ContinueFlightProcess(Stations[0]);
            return Stations;
        }

        public async Task<int> CheckAvalibleStation(int idStation)
        {
            List<ConnecedStation> stationlist = await _repoConStation.GetStationsByStart(idStation);
            foreach (var item in stationlist)
            {
                if (item.ToStation.IsAvailable)
                {
                    await _repoConStation.UpdateStations(item);
                    return item.Id;
                }
            }
            return 0;
        }

        public async Task<bool> CheckLastStation(int idStation)
        {

            List<ConnecedStation> stationlist = await _repoConStation.GetStationsByStart(idStation);
            if (!stationlist.Any())
            {
                Station st = await _repoStation.GetStationById(idStation);
                await _repoStation.RemovePlain(st);
                return true;
            }
            return false;

        }

        public async Task<Station> GetStationByID(int idStation)
        {
            return await _repoStation.GetStationById(1);
        }

        public async Task<List<Station>> ContinueFlightProcess(Station st)
        {
            int temp = await CheckAvalibleStation(st.Id);
            if (temp != 0)
            {
                FlightProcess.Invoke(Stations);
                if (!await CheckLastStation(temp))
                {
                    Thread.Sleep(2000);
                    await ContinueFlightProcess(await _repoStation.GetStationById(temp));
                }
            }
            return Stations;
        }
    }
}
