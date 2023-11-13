using Microsoft.EntityFrameworkCore;
using Midterm_CarRental.Data;
using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using Midterm_CarRental.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly MyDbContext _context;

        public CarRepository(MyDbContext context)
        {
            _context = context;
        }
        public bool Add(CarModel model)
        {
            try
            {
                _context.Add(new Car(model));
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var car = _context.Cars.SingleOrDefault(c => c.Id == id);

                if (car == null)
                {
                    return false;
                }
                _context.Remove(car);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<CarMV> GetAll(bool isDesc)
        {
            try
            {
                List<Car> cars = _context.Cars.ToList();

                var res = cars.Select(x => new CarMV(x)).ToList();

                if (isDesc)
                {
                    res.Reverse();
                }

                return res;
            }
            catch
            {
                throw new Exception("Get all cars not successfully!");
            }
        }

        public CarMV GetById(int id)
        {
            try
            {
                var car = _context.Cars.SingleOrDefault(c => c.Id == id);

                if (car == null) return null;
                return new CarMV(car);
            }
            catch
            {
                throw new Exception("Get by id car not successfully!");
            }
        }

        public void Update(CarMV model)
        {
            try
            {
                var car = _context.Cars.SingleOrDefault(c => c.Id == model.Id);

                if (car == null) return;

                car.SetCarByMV(model);
                _context.SaveChanges();

            } catch
            {
                throw new Exception("Update car not successfully!");
            }
        }
    }
}
