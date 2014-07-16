using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Infrastructure
{
    public interface IUnitOfWork
    {
        void RegisterAmended(EntityBase entity, IUnitOfWorkRepository unitofWorkRepository);
        void RegisterNew(EntityBase entity, IUnitOfWorkRepository unitofWorkRepository);
        void RegisterRemoved(EntityBase entity, IUnitOfWorkRepository unitofWorkRepository);
        void Commit();
    }
}
