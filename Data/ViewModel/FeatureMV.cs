using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data.ViewModel
{
    public class FeatureMV
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }

        public void SetFeatureMVByFeature(Feature feature)
        {
            this.Id = feature.Id;
            this.Name = feature.Name;
            this.Price = feature.Price;
        }
    }
}
