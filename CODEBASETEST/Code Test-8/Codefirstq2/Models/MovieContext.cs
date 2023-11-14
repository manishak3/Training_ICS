using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Codefirstq2.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<movie> movies { get; set; }

    }
}