using AoOS.Models;

namespace AoOS.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private VehicleContext _context;

        public VehicleRepository(VehicleContext context)
        {
            _context = context;
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _context.vehicles.ToList();
        }

        public Vehicle Get(string id)
        {
            return _context.vehicles.FirstOrDefault(m => m.Code == id);
        }
    }
}
