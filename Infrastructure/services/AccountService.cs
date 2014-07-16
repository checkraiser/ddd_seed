using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Infrastructure.services
{
    public static class AccountService
    {
        public static IList<Account> GetAllProjects()
        {
            IAccountRepository repository =
            RepositoryFactory.GetRepository<IAccountRepository, Account>();
            return repository.FindAll();
        }
    }
}
