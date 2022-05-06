using FakturaTest.Domains.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FakturaTest.Data.IRepository
{
    public interface ICarRepository
    {
        ValueTask<Car> CreateAsync(Car car);
        Task<Car> GetAsync(Expression<Func<Car, bool>> expression);
        IQueryable<Car> GetAll(Expression<Func<Car, bool>> expression = null);
        Task<Car> UpdateAsync(Car car);
        void Delete(Expression<Func<Car, bool>> expression);
    }
}
