using Midterm_CarRental.Data;
using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories
{
    public interface IRentRepository : IRepository<RentModel, RentMV>
    {
        bool ChangeStatus(int id);
        long GetRemainingPriceById(int id);
        List<StatisticalClass> GetStatisticalToDate(DateTime dateStart, DateTime dateEnd);
    }
}
