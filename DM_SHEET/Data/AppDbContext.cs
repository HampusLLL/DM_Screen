using DM_SHEET.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DM_SHEET.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
