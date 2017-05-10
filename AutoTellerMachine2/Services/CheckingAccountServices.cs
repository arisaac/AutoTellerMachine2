using AutoTellerMachine2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTellerMachine2.Services
{
    public class CheckingAccountServices
    {
        private ApplicationDbContext db;
        private object model;

        public CheckingAccountServices(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreateCheckingAccount(string firstName, string lastName, string userId, decimal initialBalance)
        {
            var accountNumber = (123457 + db.CheckingAccounts.Count()).
                ToString().PadLeft(10, '0');
            var checkingAccount = new CheckingAccount
            {
                FirstName = firstName,
                LastName = lastName,
                AccountNumber = accountNumber,
                Balance = initialBalance,
                ApplicationUserId = userId
            };
            db.CheckingAccounts.Add(checkingAccount);
            db.SaveChanges();
        }

        public void UpdateBalance(int checkingAccountId)
        {
            var checkingAccount = db.CheckingAccounts.Where(c => c.Id == checkingAccountId).First();
            checkingAccount.Balance = db.Transactions.Where(c =>
            c.Id == checkingAccountId).Sum(c => c.Amount);
            db.SaveChanges();
        }
    }
}