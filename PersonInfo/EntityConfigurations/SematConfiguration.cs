using PersonInfo.Models;
using System.Data.Entity.ModelConfiguration;

namespace PersonInfo.EntityConfigurations
{
    public class SematConfiguration : EntityTypeConfiguration<Semat>
    {
        public SematConfiguration()
        {
            HasKey(s => s.Id);

            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);

            // (0..1)-To-Many with Person
            HasMany(s => s.Persons)
                .WithOptional(p => p.Semat)
                .HasForeignKey(p => p.SematId)
                .WillCascadeOnDelete(false);
        }
    }
}