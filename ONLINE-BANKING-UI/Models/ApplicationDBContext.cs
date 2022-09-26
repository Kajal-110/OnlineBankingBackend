using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ONLINE_BANKING_UI.Models;

namespace ONLINE_BANKING_UI.Models
{
    public class ApplicationDBContext : DbContext
    {
        string connectionString = "Server=.;Database=ONLINE-BANKING-UI; integrated security=SSPI;trustservercertificate=True;MultipleActiveResultSets=true";
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Register> Register { get; set; }
        public DbSet<Account> Accounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<ONLINE_BANKING_UI.Models.Depositeamount> Depositeamount { get; set; }
        public DbSet<ONLINE_BANKING_UI.Models.CreateAccount> CreateAccount { get; set; }
        public DbSet<ONLINE_BANKING_UI.Models.Request> Request { get; set; }
        public DbSet<ONLINE_BANKING_UI.Models.Loan> Loan { get; set; }
        public DbSet<ONLINE_BANKING_UI.Models.CheckBook> CheckBook { get; set; }
        public DbSet<ONLINE_BANKING_UI.Models.DebitCard> DebitCard { get; set; }

        public DbSet<ONLINE_BANKING_UI.Models.Transferamount> Transferamount { get; set; }
        public DbSet<ONLINE_BANKING_UI.Models.ChangePin> ChangePin { get; set; }
        public DbSet<ONLINE_BANKING_UI.Models.StopCheque> StopCheque { get; set; }
        public DbSet<ONLINE_BANKING_UI.Models.CreatePassword> CreatePassword { get; set; }
    }
}
