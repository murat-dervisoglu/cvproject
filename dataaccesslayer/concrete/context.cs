using entitylayer.concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataaccesslayer.concrete
{
    public class context: IdentityDbContext<WriterUser,WriterRole,int>
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=coreprojeDb;integrated security=true");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<about> abouts { get; set; } 
        public DbSet<contact> contacts { get; set; }
        public DbSet<experience> experiences { get; set; }
        public DbSet<feature> features { get; set; }
        public DbSet<message> messages { get; set; }
        public DbSet<portfolio> portfolios { get; set; }
        public DbSet<service> services { get; set; }
        public DbSet<skill> skills { get; set; }
        public DbSet<socialmedia> socialmedias { get; set; }
        public DbSet<testimonial> testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<WriterMessage> WriterMessages { get; set; }
    }
}
