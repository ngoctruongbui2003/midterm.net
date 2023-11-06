using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories
{
    public interface IAccountRepository
    {
        int isLogin(string userName, string password);
        string GetDisplayName(string userName);
    }
}
