using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using web.Models;

namespace web.DataAccess
{
    public class AppContext : DbContext
    {
        static AppContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AppContext>());
        }

        // add dbset
        public DbSet<User> User { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Car> Car { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // tilføj primary keys .hasKey()

            base.OnModelCreating(modelBuilder);
        }

    }
}