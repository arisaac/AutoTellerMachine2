using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/*namespace AutoTellerMachine2.Models
{
        public interface IApplicationDbContext
        {
            IDbSet<CheckingAccount> CheckingAccounts { get; set; }
            IDbSet<Transaction> Transactions { get; set; }

            int SaveChanges();
        }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>,
        IApplicationDbContext
    {

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public string UserName { get; internal set; }

        public IDbSet<CheckingAccount> CheckingAccounts { get; set; }

        public IDbSet<Transaction> Transactions { get; set; }
    }

    public class FakeApplicacionDbContext : IApplicationDbContext
    {
        public IDbSet<CheckingAccount> CheckingAccounts { get; set; }

        public IDbSet<Transaction> Transactions { get; set; }

        public int SaveChanges()
        {
            return 0;
        }
    }
}*/