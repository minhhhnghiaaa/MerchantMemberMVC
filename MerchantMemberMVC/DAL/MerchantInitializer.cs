using System.Collections.Generic;
using MerchantMemberMVC.Models;

namespace MerchantMemberMVC.DAL
{

    public class MerchantInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MerchantContext>
    {
        protected override void Seed(MerchantContext context)
        {
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
            var members = new List<Member>
                {
                    new Member
                    {
                        Name = "Member1", Address = "Address1", Age = 1, Email = "Email1", Phone = "Phone1",
                    },
                    new Member
                    {
                        Name = "Member2", Address = "Address2", Age = 2, Email = "Email2", Phone = "Phone2",
                    },
                    new Member
                    {
                        Name = "Member3", Address = "Address3", Age = 3, Email = "Email3", Phone = "Phone3",
                    }

                };
            members.ForEach(s => context.Members.Add(s));
            context.SaveChanges();

        }
    }
}
