using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Siteshop.DAL.Entities
{
    public class EFContext : DbContext

    {
        public EFContext() : base("userConnection")
        {



        }

        public DbSet<User> Users { get; set; }



    }
}
