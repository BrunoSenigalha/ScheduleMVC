using Microsoft.EntityFrameworkCore;
using ScheduleMVC.Models;

namespace ScheduleMVC.Context
{
    public class ScheduleMvcContext : DbContext
    {
        public ScheduleMvcContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
