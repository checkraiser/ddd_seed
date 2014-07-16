using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class EntityBase: IAggregateRoot
    {
        public int Version { get; set; }
    }
}
