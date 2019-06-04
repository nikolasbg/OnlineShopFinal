using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Domain.Concrete
{
    public class EFDbContext : DbContext //isto ime klase EFDbContext kao i string konekcije u web config-u da entiti direktno poveze bazuu
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
