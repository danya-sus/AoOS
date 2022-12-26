using AoOS.Models;

namespace AoOS.Repositories
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAll();
        Vehicle Get(string id);
    }
}
