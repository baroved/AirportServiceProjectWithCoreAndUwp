using Common.Models;
using ServerCore.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerCore.Repositories
{
    public class ConnectedStationRepository
    {
        private readonly DBContext _context;
        public ConnectedStationRepository(DBContext context)
        {
            _context = context;
        }
        public Task<List<ConnecedStation>> GetAllPlains()
        {
            return Task.FromResult(_context.ConnectedStations.ToList());
        }
        public Task<List<ConnecedStation>> GetStationsByStart(int id)
        {
            return Task.FromResult(_context.ConnectedStations.Where(a => a.FromStationID == id).ToList());
        }
        public Task<List<ConnecedStation>> GetStationsByEnd(int id)
        {
            return Task.FromResult(_context.ConnectedStations.Where(a => a.ToStationID == id).ToList());
        }
        public Task<ConnecedStation> GetConnectedStationsByEnd(int id)
        {
            return Task.FromResult(_context.ConnectedStations.Where(a => a.ToStationID == id).FirstOrDefault());
        }

        public async Task UpdateStations(ConnecedStation cs)
        {
            await Task.Run(() =>
            {
                cs.ToStation.Plane = cs.FromStation.Plane;
                cs.ToStationID = cs.FromStation.Id;
                cs.FromStation.Plane = null;
                cs.FromStation.PlaneID = null;
                cs.FromStation.IsAvailable = true;
                cs.ToStation.IsAvailable = false;
                _context.SaveChangesAsync();
            });
        }

        public Task<ConnecedStation> GetConnectedStation(int startid,int endid)
        {
            return Task.FromResult(_context.ConnectedStations
                .Where(a => a.FromStationID == startid && a.ToStationID == endid).FirstOrDefault());
        }
    }
}
