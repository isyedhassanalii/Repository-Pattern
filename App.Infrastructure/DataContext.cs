using App.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure
{
   public class DataContext:DbContext
    {
        public DataContext():base("db")
        {}
        public DbSet<WhatsNew> WhatsNews { get; set; }
    }
}
