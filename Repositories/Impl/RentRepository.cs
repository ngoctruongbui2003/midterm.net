using Microsoft.EntityFrameworkCore;
using Midterm_CarRental.Data;
using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace Midterm_CarRental.Repositories.Impl
{
    public class RentRepository : IRentRepository
    {
        private readonly MyDbContext _context;
        ComboBoxData data = new ComboBoxData();

        public RentRepository(MyDbContext context)
        {
            _context = context;
        }
        public int Add(RentModel model)
        {
            try
            {
                Rent rent = new Rent();
                rent.SetRentByModel(model);
                _context.Add(rent);
                _context.SaveChanges();

                return rent.Id;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");

                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                return -1;
            }
        }

        public bool ChangeStatus(int id)
        {
            try
            {
                var rent = _context.Rents.SingleOrDefault(c => c.Id == id);

                if (rent == null)
                {
                    return false;
                }

                var car = _context.Cars.SingleOrDefault(c => c.Id == rent.CarId);

                car.Status = data.StatusCar[0];

                rent.Status = data.StatusRent[1];

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
                var rent = _context.Rents.SingleOrDefault(c => c.Id == id);

                if (rent == null)
                {
                    return false;
                }

                var car = _context.Cars.SingleOrDefault(c => c.Id == rent.CarId);

                car.Status = data.StatusCar[0];

                _context.Remove(rent);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<RentMV> GetAll(bool isDesc)
        {
            try
            {
                List<RentMV> res = new List<RentMV>();

                var rents = _context.Rents
                    .Include(r => r.Customer)
                    .Include(r => r.Car)
                    .Include(r => r.RentDetails).ToList();

                foreach (var rent in rents)
                {
                    List<FeatureMV> features = new List<FeatureMV>();
                    RentMV rentMV = new RentMV();

                    foreach (var rentDetail in rent.RentDetails)
                    {
                        var temp = _context.Features.SingleOrDefault(f => f.Id == rentDetail.FeatureId);
                        features.Add(new FeatureMV()
                        {
                            Id = temp.Id,
                            Name = temp.Name,
                            Price = temp.Price,
                        });
                    }

                    rentMV.SetRentMVByRent(rent);
                    rentMV.Features = features;

                    res.Add(rentMV);
                }


                res.Reverse();

                return res;
            }
            catch
            {
                throw new Exception("Get all rent not successfully!");
            }
        }

        public long GetRemainingPriceById(int id)
        {
            try
            {
                var rent = _context.Rents.SingleOrDefault(c => c.Id == id);

                if (rent == null)
                {
                    return 0;
                }


                return rent.GetRemainingPrice();
            }
            catch
            {
                return 0;
            }
        }

        public RentMV GetById(int id)
        {
            try
            {

                var rent = _context.Rents.Include(r => r.Customer).SingleOrDefault(x => x.Id == id);

                List<FeatureMV> features = new List<FeatureMV>();
                RentMV rentMV = new RentMV();

                foreach (var rentDetail in rent.RentDetails)
                {
                    var temp = _context.Features.SingleOrDefault(f => f.Id == rentDetail.FeatureId);
                    features.Add(new FeatureMV()
                    {
                        Id = temp.Id,
                        Name = temp.Name,
                        Price = temp.Price,
                    });
                }

                rentMV.SetRentMVByRent(rent);
                rentMV.Features = features;
                

                return rentMV;
            }
            catch
            {
                throw new Exception("Get all rent not successfully!");
            }
        }

        public void Update(RentMV model)
        {
            throw new NotImplementedException();
        }
    }
}
