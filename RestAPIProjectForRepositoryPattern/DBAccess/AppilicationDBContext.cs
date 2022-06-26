using System;
using Microsoft.EntityFrameworkCore;
using RestAPIProjectForRepositoryPattern.Entities;

namespace RestAPIProjectForRepositoryPattern.DBAccess
{
    public class AppilicationDBContext : DbContext
    {
        public AppilicationDBContext(DbContextOptions<AppilicationDBContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Developer> developers { get; set; }
        public DbSet<Project> projects { get; set; }

    }
}

