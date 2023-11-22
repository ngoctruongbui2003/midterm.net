using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories
{
    public interface ICarRepository : IRepository<CarModel, CarMV>
    {
        List<CarMV> GetByName(string name);
        List<CarMV> GetByFuel(string name, string fuelName);
        List<CarMV> GetByBrand(string name, string brandName);
        List<CarMV> GetByCategory(string name, string categoryName);
        bool ChangeStatusToEmpty(int id);
        bool ChangeStatusToRent(int id);
    }
}
