using Blazor_Models.Interfaces;
using Blazor_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Models.Data
{
    public class CarsRepository(AutoDBContext dbcontext) : ICarsRepository
    {
        private AutoDBContext _dbcontext = dbcontext;

        public IEnumerable<Car> GetAllCars()
        {
            return _dbcontext.Cars.ToList();
        }

        public void AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
