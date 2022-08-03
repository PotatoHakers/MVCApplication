
using BusinessLogic.Interface;
using Model;
using MVCApplication;

namespace BusinessLogic.Service
{
    public class CarService : ICarService
    {
        private readonly ApplicationContext _appContext;


        public CarService(ApplicationContext appContext)
        {
            _appContext = appContext;
            
        }

        public void AddAllCars()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetCars()
        {
            return _appContext.Cars.ToList();
        }

       
    }
}
