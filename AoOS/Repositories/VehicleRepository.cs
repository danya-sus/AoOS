using AoOS.Models;

namespace AoOS.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private VehicleContext _context;
        private ILogger _logger;

        public VehicleRepository(VehicleContext context, ILogger<VehicleRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Vehicle> GetAll()
        {
            _logger.LogInformation("GET ALL ...");
            return _context.vehicles.ToList();
        }

        public Vehicle Get(string id)
        {
            return _context.vehicles.FirstOrDefault(m => m.Code == id);
        }
    }
}
