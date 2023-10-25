using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MerchantMemberMVC.Models;

namespace MerchantMemberMVC.DAL
{
    public class MerchantContext : DbContext
    {

        public MerchantContext() : base("MerchantContext")
        {
        }

        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}