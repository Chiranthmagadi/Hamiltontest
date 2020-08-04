using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamilton.Models
{
    public class AddressBookContext :DbContext
    {
        public AddressBookContext(DbContextOptions<AddressBookContext> options):base(options)
        {

        }

        public DbSet<AddressBook> AddressBooks { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AddressBook>(entity => {
                entity.HasIndex(e => e.Email).IsUnique();
            });
        }
    }
}
