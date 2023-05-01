using DB.Entity;
using InfraStructure.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.Data
{
   public class FreeBookDbContext:IdentityDbContext<AppUser>
    {
        public FreeBookDbContext(DbContextOptions<FreeBookDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //same schema --identity--
            //builder.Entity<IdentityUser>().ToTable("users", "Identity");
            //builder.Entity<IdentityRole>().ToTable("roles", "Identity");
            //builder.Entity<IdentityUserRole<string>>().ToTable("user_role", "Identity");
            //builder.Entity<IdentityUserClaim<string>>().ToTable("User_claim", "Identity");
            //builder.Entity<IdentityUserLogin<string>>().ToTable("user_login", "Identity");
            //builder.Entity<IdentityRoleClaim<string>>().ToTable("role_Claim", "Identity");
            //builder.Entity<IdentityUserToken<string>>().ToTable("user_token", "Identity");
            builder.Entity<Category>().Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Entity<LogCategory>().Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Entity<SubCategory>().Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Entity<LogSubCategory>().Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Entity<Book>().Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Entity<LogBook>().Property(x => x.Id).HasDefaultValueSql("(newid())");
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<LogCategory> log_categories { get; set; }
        public DbSet<SubCategory> sub_categories { get; set; }
        public DbSet<LogSubCategory> log_sub_categories { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<LogBook> log_books { get; set; }
    }
}
