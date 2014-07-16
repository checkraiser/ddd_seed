using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T>, IUnitOfWorkRepository  where T : EntityBase
    {
        private IUnitOfWork _unitOfWork;
        protected RepositoryBase() : this(null) { }
        public RepositoryBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public abstract T FindBy(object key);
        public void Add(T item)
        {
            if (this._unitOfWork != null)
            {
                this._unitOfWork.RegisterNew(item, this);
            }
        }
        public T this[object key] 
        {
            get
            {
                return this.FindBy(key);
            }
            set
            {
                if (this.FindBy(key) == null)
                {
                    this.Add(value);
                }
                else
                {
                    this._unitOfWork.RegisterAmended(value, this);
                }
            }
        }
        void Remove(T item)
        {
            if (this._unitOfWork != null)
            {
                this._unitOfWork.RegisterRemoved(item, this);
            }
        }
        public void PersistUpdateOf(EntityBase entity)
        {
            this.PersistUpdatedItem((T)entity);
        }
        public void PersistCreationOf(EntityBase entity)
        {
            this.PersistNewItem((T)entity);
        }
        public void PersistDeletionOf(EntityBase entity)
        {
            this.PersistDeletedItem((T)entity);
        }
        protected abstract void PersistNewItem(T item);
        protected abstract void PersistUpdatedItem(T item);
        protected abstract void PersistDeletedItem(T item);
    }
}
