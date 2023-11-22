using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Midterm_CarRental.Data;
using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using Midterm_CarRental.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories.Impl
{
    public class CarRepository : ICarRepository
    {
        private readonly MyDbContext _context;
        private ComboBoxData data = new ComboBoxData();
        public CarRepository(MyDbContext context)
        {
            _context = context;
        }
        public int Add(CarModel model)
        {
            try
            {
                Car car = new Car();
                car.SetCarByModel(model);
                _context.Add(car);
                _context.SaveChanges();

                return car.Id;
            }
            catch
            {
                return -1;
            }
        }

        public bool ChangeStatusToEmpty(int id)
        {
            try
            {
                var car = _context.Cars.SingleOrDefault(c => c.Id == id);

                if (car == null)
                {
                    return false;
                }

                car.Status = data.StatusCar[0];

                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ChangeStatusToRent(int id)
        {
            try
            {
                var car = _context.Cars.SingleOrDefault(c => c.Id == id);

                if (car == null)
                {
                    return false;
                }

                car.Status = data.StatusCar[1];

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
                

                var res = cars.Select(x =>
                {
                    CarMV car = new CarMV();
                    car.SetCarMVByCar(x);
                    return car;
                }).ToList();

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

        public List<CarMV> GetByBrand(string name, string brandName)
        {
            try
            {
                List<Car> cars = _context.Cars.ToList();
                
                if (name.Trim().IsNullOrEmpty())
                {
                    return cars.Where(car => car.Brand.ToLower() == brandName.ToLower())
                            .Select(x =>
                            {
                                CarMV car = new CarMV();
                                car.SetCarMVByCar(x);
                                return car;
                            }).ToList();
                }

                return cars.Where(car => car.Brand.ToLower() == brandName.ToLower()
                && car.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                            .Select(x =>
                            {
                                CarMV car = new CarMV();
                                car.SetCarMVByCar(x);
                                return car;
                            }).ToList();
            } catch
            {
                throw new Exception("Get car by name from brand car not successfully!");
            }
        }

        public List<CarMV> GetByCategory(string name, string categoryName)
        {
            try
            {
                List<Car> cars = _context.Cars.ToList();

                if (name.Trim().IsNullOrEmpty())
                {
                    return cars.Where(car => car.Category.ToLower() == categoryName.ToLower())
                            .Select(x =>
                            {
                                CarMV car = new CarMV();
                                car.SetCarMVByCar(x);
                                return car;
                            }).ToList();
                }

                return cars.Where(car => car.Category.ToLower() == categoryName.ToLower()
                && car.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                            .Select(x =>
                            {
                                CarMV car = new CarMV();
                                car.SetCarMVByCar(x);
                                return car;
                            }).ToList();
            }
            catch
            {
                throw new Exception("Get car by name from category not successfully!");
            }
        }

        public List<CarMV> GetByFuel(string name, string fuelName)
        {
            try
            {
                List<Car> cars = _context.Cars.ToList();

                var res = cars.Where(car => car.Fuel.ToLower() == fuelName.ToLower()
                && car.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                            .Select(x =>
                            {
                                CarMV car = new CarMV();
                                car.SetCarMVByCar(x);
                                return car;
                            }).ToList();
                return res;
            }
            catch
            {
                throw new Exception("Get car by name from fuel not successfully!");
            }
        }

        public CarMV GetById(int id)
        {
            try
            {
                var car = _context.Cars.SingleOrDefault(c => c.Id == id);

                if (car == null) return null;

                CarMV res = new CarMV();
                res.SetCarMVByCar(car);

                return res;
            }
            catch
            {
                throw new Exception("Get by id car not successfully!");
            }
        }

        public List<CarMV> GetByName(string name)
        {
            try
            {
                List<Car> cars = _context.Cars.ToList();

                var res = cars.Where(car => 
                car.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                            .Select(x =>
                            {
                                CarMV car = new CarMV();
                                car.SetCarMVByCar(x);
                                return car;
                            }).ToList();
                return res;
            }
            catch
            {
                throw new Exception("Get car by name not successfully!");
            }
        }

        public void Update(CarMV model)
        {
            try
            {
                var car = _context.Cars.SingleOrDefault(c => c.Id == model.Id);

                if (car == null) return;

                car.SetCarByMV(model);
                car.DateAdded = DateTime.Now;

                _context.SaveChanges();

            }
            catch
            {
                throw new Exception("Update car not successfully!");
            }
        }
    }
}
