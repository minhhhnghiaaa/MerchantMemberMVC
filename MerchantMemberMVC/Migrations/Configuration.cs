using System.Collections.Generic;
using MerchantMemberMVC.Models;

namespace MerchantMemberMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MerchantMemberMVC.DAL.MerchantContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MerchantMemberMVC.DAL.MerchantContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var merchants = new List<Merchant>
            {
                new Merchant
                {
                    AccountNumber = "Merchant1", Balance = 10000, BankName = "Bank1", Name = "Merchant1", SwiftCode = "11111111"
                },
                new Merchant
                {
                    AccountNumber = "Merchant2", Balance = 20000, BankName = "Bank2", Name = "Merchant2", SwiftCode = "22222222"
                },
                new Merchant
                {
                    AccountNumber = "Merchant3", Balance = 30000, BankName = "Bank3", Name = "Merchant3", SwiftCode = "33333333"
                }
            };

            merchants.ForEach(s => context.Merchants.Add(s));
            context.SaveChanges();
            
        }
    }
}
