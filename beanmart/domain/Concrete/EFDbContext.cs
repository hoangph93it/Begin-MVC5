using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Entities;
using System.Data.Entity;

namespace domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Bean> Beans { get; set; }
    }
}
