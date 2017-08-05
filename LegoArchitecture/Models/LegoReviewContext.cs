using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LegoArchitecture.Models
{
    public class LegoReviewContext : DbContext
    {
        public DbSet<Lego> Legos { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}