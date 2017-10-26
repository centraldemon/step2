using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity
{
    public class Context:DbContext
    {
        public Context():base("UserCon")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
