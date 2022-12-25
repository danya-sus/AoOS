using AoOS.Models;

namespace AoOS.Repositories
{
    public interface IVehicleRepository
    {
        public IEnumerable<Vehicle> GetAll();
        public Vehicle Get(string id);
    }
}
