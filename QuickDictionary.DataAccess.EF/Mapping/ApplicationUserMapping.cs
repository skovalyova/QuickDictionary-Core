using QuickDictionary.DataAccess.Models;
using System.Data.Entity.ModelConfiguration;

namespace QuickDictionary.DataAccess.EF.Mapping
{
    internal class ApplicationUserMapping : EntityTypeConfiguration<ApplicationUser>
    {
        internal ApplicationUserMapping()
        {
            ToTable("ApplicationUsers");

            Property(u => u.Token)
                .IsRequired()
                .HasMaxLength(24);
        }
    }
}
