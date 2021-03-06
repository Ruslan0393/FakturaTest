using FakturaTest.Data.IRepository;
using FakturaTest.Domains.Entities;
using FakturaTest.Service.DTOs;
using FakturaTest.Service.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FakturaTest.Service.Services
{
    public class CarService : ICarService
    {
        private ICarRepository carRepository;

        public CarService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public ValueTask<Car> CreateAsync(AddCarDto car)
        {
            var newCar = new Car
            {
                Name = car.Name,
                Model = car.Model,
                Price = car.Price,
                Color = car.Color
            };
            newCar.Create();
            return carRepository.CreateAsync(newCar);
        }

        public void Delete(Expression<Func<Car, bool>> expression)
            => carRepository.Delete(expression);

        public IQueryable<Car> GetAll(Expression<Func<Car, bool>> expression = null, string max = null, string min = null, string sort = "Name")
        {
            if (!string.IsNullOrEmpty(max) && !string.IsNullOrEmpty(min))
                return carRepository.GetAll(p => p.Price <= decimal.Parse(max) && p.Price >= decimal.Parse(min)).OrderBy(p => sort);
            else if (!string.IsNullOrEmpty(max) && string.IsNullOrEmpty(min))
                return carRepository.GetAll(p => p.Price <= decimal.Parse(max)).OrderBy(p => sort);
            else if (!string.IsNullOrEmpty(min) && string.IsNullOrEmpty(max))
                return carRepository.GetAll(p => p.Price >= decimal.Parse(min)).OrderBy(p => sort);
            else
                return carRepository.GetAll().OrderBy(p => sort);
        }

        public Task<Car> GetAsync(Expression<Func<Car, bool>> expression)
            => carRepository.GetAsync(expression);

        public Task<Car> UpdateAsync(Car car)
            => carRepository.UpdateAsync(car);

    }
}
