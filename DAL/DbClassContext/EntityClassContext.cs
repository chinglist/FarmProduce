using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbClassContext
{
    internal class EntityClassContext : DbContext
    {
        public EntityClassContext() : base("name=DBConnectionString")
        {
        }
        public DbSet<t_user> user { get; set; }
    }
}

