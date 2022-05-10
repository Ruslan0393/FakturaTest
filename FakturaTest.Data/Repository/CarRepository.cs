using FakturaTest.Data.DbContexts;
using FakturaTest.Data.IRepository;
using FakturaTest.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FakturaTest.Data.Repository
{
    public class CarRepository : ICarRepository
    {

        private readonly CarDbContext db;

        public CarRepository(CarDbContext db)
        {
            this.db = db;
        }

        public async ValueTask<Car> CreateAsync(Car car)
        {
            await db.Cars.AddAsync(car);
            db.SaveChanges();
            return car;
        }

        public void Delete(Expression<Func<Car, bool>> expression)
        {
            var resalt = db.Cars.FirstOrDefault(expression);

            db.Cars.Remove(resalt);
            db.SaveChanges();
        }

        public IQueryable<Car> GetAll(Expression<Func<Car, bool>> expression = null)
            => expression is null ? db.Cars : db.Cars.Where(expression);
        

        public async Task<Car> GetAsync(Expression<Func<Car, bool>> expression)
            => await db.Cars.FirstOrDefaultAsync(expression);

        public async Task<Car> UpdateAsync(Car car)
        {
            db.Entry(car).State = EntityState.Modified;

            await db.SaveChangesAsync();

            return car;
        }
    }
}
