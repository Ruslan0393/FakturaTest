using FakturaTest.Domains.Entities;
using FakturaTest.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FakturaTest.Service.Interfaces
{
    public interface ICarService
    {
        ValueTask<Car> CreateAsync(AddCarDto car);
        Task<Car> GetAsync(Expression<Func<Car, bool>> expression);
        IQueryable<Car> GetAll(Expression<Func<Car, bool>> expression = null, string max = null, string min = null, string sort = "Name");
        Task<Car> UpdateAsync(Car car);
        void Delete(Expression<Func<Car, bool>> expression);
    }
}
