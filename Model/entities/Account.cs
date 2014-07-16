using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
namespace Model
{
    public class Account: EntityBase
    {
        public decimal balance { get; set;  }
    }
}
