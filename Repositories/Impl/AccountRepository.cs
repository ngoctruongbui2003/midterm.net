using Midterm_CarRental.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories.Impl
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MyDbContext _context;

        public AccountRepository(MyDbContext context)
        {
            _context = context;
        }

        public int isLogin(string userName, string password)
        {
            var account = _context.Accounts.SingleOrDefault(x => x.UserName == userName && x.Password == password);

            if (account == null)
            {
                return -1;
            }

            return account.Role;
        }

        public string GetDisplayName(string userName)
        {
            var account = _context.Accounts.SingleOrDefault(x => x.UserName == userName);

            if (account != null)
            {
                return account.DisplayName;
            }

            throw new Exception("Account not found for username: " + userName);
        }
    }
}
