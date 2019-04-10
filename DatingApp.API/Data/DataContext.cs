using Microsoft.EntityFrameworkCore;
using MyProjects_V2.Git.DatingApp.DatingApp.API.Models;

namespace MyProjects_V2.Git.DatingApp.DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    }
}