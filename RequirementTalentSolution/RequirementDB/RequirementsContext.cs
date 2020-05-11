using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RequirementDB
{
    public partial class RequirementsContext : DbContext
    {
        public RequirementsContext()
        {
        }

        public RequirementsContext(DbContextOptions<RequirementsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Requirement> Requirement { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Requirements;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Requirement>(entity =>
            {
                entity.Property(e => e.AdditionalSkillSet)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Billing).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ContractorRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DeliveryOwner)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fterate)
                    .HasColumnName("FTERate")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Jd)
                    .IsRequired()
                    .HasColumnName("JD");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.PositionQuantity).HasDefaultValueSql("((1))");

                entity.Property(e => e.PrimarySkills)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Qualification).IsRequired();

                entity.Property(e => e.RecruiterOwner)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RequirementCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesOwner)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sonumber)
                    .HasColumnName("SONumber")
                    .HasMaxLength(1000);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
