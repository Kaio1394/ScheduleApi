using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ScheduleApi.Model.User;

namespace ScheduleApi.Data
{
    public partial class ScheduleApiDbContext : IdentityDbContext<ApiUser>
    {
        public ScheduleApiDbContext()
        {
        }

        public ScheduleApiDbContext(DbContextOptions<ScheduleApiDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<JobExecution> JobExecutions { get; set; }
        public virtual DbSet<JobHistoryExecution> JobHistoryExecutions { get; set; }
        public virtual DbSet<JobHistoryModified> JobHistoryModifieds { get; set; }
        public virtual DbSet<JobStatus> JobStatuses { get; set; }
        public virtual DbSet<Server> Servers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ScheduleApiDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<JobExecution>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07A879D89C");

                entity.ToTable("JobExecution");

                entity.HasIndex(e => e.Name, "UQ__JobExecu__737584F683F6B7AC").IsUnique();

                entity.HasIndex(e => e.GuidJob, "UQ__JobExecu__E80EE384BB3B7228").IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Description).HasMaxLength(255);
                entity.Property(e => e.GuidJob).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Name).HasMaxLength(255);
                entity.Property(e => e.Script).HasMaxLength(255);
                entity.Property(e => e.Tag).HasMaxLength(50);

                entity.HasOne(d => d.GuidServerNavigation).WithMany(p => p.JobExecutions)
                    .HasPrincipalKey(p => p.GuidServer)
                    .HasForeignKey(d => d.GuidServer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobExecution_ToServer");
            });

            modelBuilder.Entity<JobHistoryExecution>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__JobHisto__3214EC074A015E44");

                entity.ToTable("JobHistoryExecution");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.ErrorMessage).HasMaxLength(255);
                entity.Property(e => e.LastExecution).HasColumnType("datetime");
                entity.Property(e => e.NameJob).HasMaxLength(255);
            });

            modelBuilder.Entity<JobHistoryModified>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__JobHisto__3214EC07201CB68A");

                entity.ToTable("JobHistoryModified");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");
                entity.Property(e => e.LastUpdated)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.NameJob).HasMaxLength(255);
            });

            modelBuilder.Entity<JobStatus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__JobStatu__3214EC07DEDD8195");

                entity.ToTable("JobStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Server__3214EC076AA2AB77");

                entity.ToTable("Server");

                entity.HasIndex(e => e.TagName, "UQ__Server__BDE0FD1D1A7B2240").IsUnique();

                entity.HasIndex(e => e.GuidServer, "UQ__Server__DCCC6CDC76E84F4B").IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.GuidServer).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(45)
                    .HasColumnName("IPAddress");
                entity.Property(e => e.TagName).HasMaxLength(100);
            });

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "UserExecutor",
                    NormalizedName = "USER_EXECUTOR",
                    Id = "85fc8893-00c4-4459-a917-52fcd2370cc1"
                },
                new IdentityRole
                {
                    Name = "UserRunner",
                    NormalizedName = "USER_RUNNER",
                    Id = "f153e55c-2405-40d7-94b0-82cebebe96e4"
                },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADM",
                    Id = "85cfbc9b-a2ba-4836-a384-d56f98504729"
                }
            );

            var hasher = new PasswordHasher<ApiUser>();
            modelBuilder.Entity<ApiUser>().HasData(
                new ApiUser
                {
                    Id = "631ac7af-a965-4c1f-9b05-f40d426c8ad4",
                    Email = "admin@schedule.com",
                    NormalizedEmail = "ADMIN@SCHEDULE.COM",
                    UserName = "admin@schedule.com",
                    NormalizedUserName = "ADMIN@SCHEDULE.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApiUser
                {
                    Id = "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                    Email = "user_runner@schedule.com",
                    NormalizedEmail = "USER_RUNNER@SCHEDULE.COM",
                    UserName = "user_runner@schedule.com",
                    NormalizedUserName = "USER_RUNNER@SCHEDULE.COM",
                    FirstName = "System",
                    LastName = "UserRunner",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApiUser
                {
                    Id = "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127",
                    Email = "user_executor@schedule.com",
                    NormalizedEmail = "USER_EXECUTOR@SCHEDULE.COM",
                    UserName = "user_executor@schedule.com",
                    NormalizedUserName = "USER_EXECUTOR@SCHEDULE.COM",
                    FirstName = "System",
                    LastName = "UserExecutor",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                }
            );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "85fc8893-00c4-4459-a917-52fcd2370cc1",
                    UserId = "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "f153e55c-2405-40d7-94b0-82cebebe96e4",
                    UserId = "51c3aa5c-cc8b-4db0-b0d4-0a8161408463"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "85cfbc9b-a2ba-4836-a384-d56f98504729",
                    UserId = "631ac7af-a965-4c1f-9b05-f40d426c8ad4"
                }
            );
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
