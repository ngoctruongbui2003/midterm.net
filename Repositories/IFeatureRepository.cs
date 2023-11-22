using Midterm_CarRental.Data;
using Midterm_CarRental.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories
{
    public interface IFeatureRepository
    {
        List<FeatureMV> GetAll();
        FeatureMV GetById(int id);
    }
}
