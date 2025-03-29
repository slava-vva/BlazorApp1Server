using Blazor_Models.Data;
using Blazor_Models.Interfaces;
using Blazor_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Models.Services
{
    public class CarService
    {
        private readonly ICarsRepository _carsRepository;

        public CarService(ICarsRepository carsrepository)
        {
            _carsRepository = carsrepository;
        }

        public IEnumerable<Car> GetAllCars()
        {
            // Example of business logic
            return _carsRepository.GetAllCars().OrderBy(c => c.Model);
        }
    }
}
