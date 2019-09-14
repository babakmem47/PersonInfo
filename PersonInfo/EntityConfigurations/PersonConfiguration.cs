using PersonInfo.Models;
using System.Data.Entity.ModelConfiguration;

namespace PersonInfo.EntityConfigurations
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(20);

            Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.TelDirect)
                .IsFixedLength().HasMaxLength(11);

            Property(p => p.TelDakheli)
                .HasMaxLength(4);

            Property(p => p.Mobile)
                .IsFixedLength()
                .HasMaxLength(11);


            // Many-To-(0..1) with Semat
            HasOptional(p => p.Semat)
                .WithMany(s => s.Persons)
                .HasForeignKey(p => p.SematId);
        }
    }
}