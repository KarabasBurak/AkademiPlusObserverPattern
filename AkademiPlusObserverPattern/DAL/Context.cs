using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AkademiPlusObserverPattern.DAL
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NODIFQV\\SQLEXPRESS;initial catalog=AkademiPlusObserver;integrated security=true");
        }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
    }
}
