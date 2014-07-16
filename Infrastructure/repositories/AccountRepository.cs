using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Model;
namespace Infrastructure.repositories
{
    public class AccountRepository: IRepository<Account>, IUnitOfWorkRepository
    {
        private IUnitOfWork _unitOfWork;
        public AccountRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Save(Account account)
        {
            _unitOfWork.RegisterAmended(account, this);
        }
        public void Add(Account account)
        {
            _unitOfWork.RegisterNew(account, this);
        }
        public void Remove(Account account)
        {
            _unitOfWork.RegisterRemoved(account, this);
        }
        public void PersistUpdateOf(IAggregateRoot entity)
        {
            // ADO.NET code to update the entity...
        }
        public void PersistCreationOf(IAggregateRoot entity)
        {
            // ADO.NET code to add the entity...
        }
        public void PersistDeletionOf(IAggregateRoot entity)
        {
            // ADO.NET code to delete the entity...
        }
    }
}
