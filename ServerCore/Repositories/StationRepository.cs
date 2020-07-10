using Common.Models;
using ServerCore.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerCore.Repositories
{
    public class StationRepository
    {
        private readonly DBContext _context;
        public StationRepository(DBContext context)
        {
            _context = context;
        }

        public Task<List<Station>> GetAllStations()
        {
            return Task.FromResult(_context.Stations.ToList());
        }

        public Task<Station> GetStationById(int ID)
        {
            return Task.FromResult(_context.Stations.Where(a => a.Id == ID).FirstOrDefault());
        }

        public async Task RemovePlain(Station st)
        {
            await Task.Run(() =>
            {
                st.Plane = null;
                _context.SaveChangesAsync();
            });
        }

        public async void UpdateFirstStation(EstimatedTakeOff flight)
        {
            Station st1 = await GetStationById(1);
            st1.Plane = flight.Plane;
            st1.PlaneID = flight.PlaneID;
            st1.IsAvailable = false;
            _context.SaveChanges();
        }
    }
}
