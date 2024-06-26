﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories
{
    public interface IRepository <TModel, TViewModel> 
    {
        List<TViewModel> GetAll(bool isDesc);
        TViewModel GetById(int id);
        int Add(TModel model);
        void Update(TViewModel model);
        bool Delete(int id);
    }
}
