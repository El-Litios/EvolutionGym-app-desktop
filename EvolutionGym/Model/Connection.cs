using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvolutionGym.Model
{
    public class Connection : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbgym;");

        public DbSet<Role> tblRole { get; set; }
        public DbSet<User> tblUser { get; set; }
        public DbSet<Client> tblClient { get; set; }
        public DbSet<PaymentMethod> tblPaymentMethod { get; set; }
        public DbSet<TypeMembership> tblTypeMembership { get; set; }
        public DbSet<Members> tblMembership { get; set; }
    }
}
