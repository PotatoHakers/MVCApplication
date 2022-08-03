
using Model;

namespace BusinessLogic.Interface
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();
        void AddAllCars();
    }
    
}
