﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories
{
    public interface IRepository <TModel, TViewModel> 
    {
        List<TViewModel> GetAll();
        TViewModel GetById(int id);
        bool Add(TModel model);
        bool Update(TModel model);
        bool Delete(int id);
    }
}
