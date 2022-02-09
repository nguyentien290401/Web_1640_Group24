using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Web_1640_Group24.Models
{
    public class IdeasDbContext : DbContext
    {
        public IdeasDbContext() : base("IdeasConnectionString")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<User> Users { get; set; }
    }
}