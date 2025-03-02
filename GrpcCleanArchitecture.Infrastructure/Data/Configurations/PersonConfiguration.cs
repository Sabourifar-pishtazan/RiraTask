using GrpcCleanArchitecture.Domain.Common;
using GrpcCleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace GrpcCleanArchitecture.Infrastructure.Data.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("Persons"); 

        builder.HasKey(p => p.Id); 

        builder.Property(p => p.FirstName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.LastName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.NationalCode)
            .HasMaxLength(10)
            .IsRequired();
        builder.Property(p => p.BirthDate)
            .IsRequired();

        builder
        .Property(b => b.RegisterDateTime)
        .HasDefaultValueSql("GETDATE()"); 
    }
}
