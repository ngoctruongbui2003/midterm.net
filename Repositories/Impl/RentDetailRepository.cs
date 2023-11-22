using Midterm_CarRental.Data;
using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories.Impl
{
    public class RentDetailRepository : IRentDetailRepository
    {
        private readonly MyDbContext _context;

        public RentDetailRepository(MyDbContext context) {
            _context = context;
        }
        public int Add(RentDetailModel model)
        {
            try
            {
                RentDetail rentDetail = new RentDetail();
                rentDetail.SetRentDetailByModel(model);
                _context.Add(rentDetail);
                _context.SaveChanges();

                return rentDetail.Id;
            }
            catch
            {
                return -1;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<RentDetailMV> GetAll(bool isDesc)
        {
            throw new NotImplementedException();
        }

        public RentDetailMV GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(RentDetailMV model)
        {
            throw new NotImplementedException();
        }
    }
}
