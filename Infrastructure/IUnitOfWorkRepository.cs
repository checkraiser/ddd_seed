using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Infrastructure
{
    public interface IUnitOfWorkRepository
    {
        void PersistCreationOf(EntityBase entity);
        void PersistUpdateOf(EntityBase entity);
        void PersistDeletionOf(EntityBase entity);
    }
}
