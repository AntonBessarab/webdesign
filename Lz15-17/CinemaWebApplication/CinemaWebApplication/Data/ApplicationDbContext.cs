using CinemaWebApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Film> Films { get; set; }


        public DbSet<Purchase> Purchase { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}