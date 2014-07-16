using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Infrastructure
{
    public static class RepositoryFactory
    {
        private static Dictionary<string, object> repositories = new Dictionary<string, object>();
        public static TRepository GetRepository < TRepository, TEntity > ()
where TRepository : class, IRepository < TEntity >
where TEntity : EntityBase
        {
            return null;
        }
    }
}
