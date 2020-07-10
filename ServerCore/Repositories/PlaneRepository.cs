using Common.Models;
using ServerCore.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerCore.Ripositories
{
    public class PlaneRepository
    {
        private readonly DBContext _context;
        public PlaneRepository(DBContext context)
        {
            _context = context;
        }

        public Task<List<Plane>> GetAllPlains()
        {
            return Task.FromResult(_context.Planes.ToList());
        }

    }
}
