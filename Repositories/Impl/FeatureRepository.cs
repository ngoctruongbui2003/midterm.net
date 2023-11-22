using Microsoft.EntityFrameworkCore;
using Midterm_CarRental.Data;
using Midterm_CarRental.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories.Impl
{
    public class FeatureRepository : IFeatureRepository
    {
        private readonly MyDbContext _context;

        public FeatureRepository(MyDbContext context) {
            _context = context;
        }
        public List<FeatureMV> GetAll()
        {
            try
            {
                var features = _context.Features.ToList();
                return features.Select(x =>
                {
                    FeatureMV featureMV = new FeatureMV();
                    featureMV.SetFeatureMVByFeature(x);

                    return featureMV;
                }).ToList();
            }
            catch
            {
                throw new Exception("Get all feature not successfully!");
            }
        }

        public FeatureMV GetById(int id)
        {
            try
            {
                var feature = _context.Features.SingleOrDefault(c => c.Id == id);

                if (feature == null) return null;

                FeatureMV res = new FeatureMV();
                res.SetFeatureMVByFeature(feature);

                return res;
            }
            catch
            {
                throw new Exception("Get by id feature not successfully!");
            }
        }
    }
}
