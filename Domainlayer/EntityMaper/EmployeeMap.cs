using Domainlayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Domainlayer.EntityMaper
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_empId");
            builder.Property(x => x.Id).ValueGeneratedOnAdd()
               .HasColumnName("Id")
               .HasColumnType("int");

            builder.Property(x => x.Name)
                .HasColumnName("Employee_Name")
                .HasColumnType("Varchar(100)");
            builder.Property(x => x.Department)
                .HasColumnName("Employee_Department")
                .HasColumnType("Varchar(100)");
            builder.Property(x => x.EntryDate)
                .HasColumnName("EntryDate")
                .HasColumnType("datetime");

            builder.Property(x => x.UpdateDate)
                .HasColumnName("UpdateDate")
                .HasColumnType("datetime");
            builder.Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit");
        }
    }
}
