using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace FinalBuild
{
    class InfoContext : DbContext
    {
        public InfoContext() : base("DbConnection") { }

        public DbSet<Info> Info { get; set; }
    }
}
