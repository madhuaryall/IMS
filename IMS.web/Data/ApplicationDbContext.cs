
using IMS.web.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;


namespace IMS.web.Data
{
    public class ApplicationDbContext:Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> madhu) : base(madhu) //instance create garako (options) rakhda ni vayo
        
        { 
        
        
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<AppplicationUser>()
                .Property(e => e.FirstName)
                .HasMaxLength(100);

            builder.Entity<AppplicationUser>()
                .Property(e => e.MiddleName)
                .HasMaxLength(100);

            builder.Entity<AppplicationUser>()
                .Property(e => e.LastName)
                .HasMaxLength(100);

            builder.Entity<AppplicationUser>()
                .Property(e => e.Address)

            .HasMaxLength(100);


            builder.Entity<AppplicationUser>()
                .Property(e=>e.ProfilePictureUrl)
                .HasMaxLength(100);

            builder.Entity<AppplicationUser>()
                .Property(e => e.CreatedDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE)");


            builder.Entity<AppplicationUser>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);


            builder.Entity<AppplicationUser>()
                .Property(e => e.StoreId)
                .IsRequired();


            builder.Entity<AppplicationUser>()
                .Property(e => e.LastModifiedDate)
                .IsRequired();

            builder.Entity<AppplicationUser>()
                .Property (e => e.ModifiedBy)
                .IsRequired();




            builder.Entity<IdentityRole>()
                .ToTable("Roles")
                .Property(p => p.Name)
                .HasColumnName("RoleId");

            
                

         



        }
    }
}
