using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IAccountRepository: IRepository<Account>
    {
        IList<Account> FindBy(string code);
        IList<Account> FindAll();
    }
}
