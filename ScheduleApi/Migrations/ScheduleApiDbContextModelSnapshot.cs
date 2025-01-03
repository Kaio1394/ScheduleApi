﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScheduleApi.Data;

#nullable disable

namespace ScheduleApi.Migrations
{
    [DbContext(typeof(ScheduleApiDbContext))]
    partial class ScheduleApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "USER_EXECUTOR-85fc8893-00c4-4459-a917-52fcd2370cc1",
                            Name = "UserExecutor",
                            NormalizedName = "USER_EXECUTOR"
                        },
                        new
                        {
                            Id = "USER_JOB_CREATOR-f153e55c-2405-40d7-94b0-82cebebe96e4",
                            Name = "UserJobCreator",
                            NormalizedName = "USER_JOB_CREATOR"
                        },
                        new
                        {
                            Id = "ADMIN-85cfbc9b-a2ba-4836-a384-d56f98504729",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127",
                            RoleId = "USER_EXECUTOR-85fc8893-00c4-4459-a917-52fcd2370cc1"
                        },
                        new
                        {
                            UserId = "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                            RoleId = "USER_JOB_CREATOR-f153e55c-2405-40d7-94b0-82cebebe96e4"
                        },
                        new
                        {
                            UserId = "631ac7af-a965-4c1f-9b05-f40d426c8ad4",
                            RoleId = "ADMIN-85cfbc9b-a2ba-4836-a384-d56f98504729"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ScheduleApi.Data.JobExecution", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("DataExec")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("GuidJob")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Script")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ServerId")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Timeout")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__tmp_ms_x__3214EC07A879D89C");

                    b.HasIndex("ServerId");

                    b.HasIndex(new[] { "Name" }, "UQ__JobExecu__737584F683F6B7AC")
                        .IsUnique();

                    b.HasIndex(new[] { "GuidJob" }, "UQ__JobExecu__E80EE384BB3B7228")
                        .IsUnique();

                    b.ToTable("JobExecution", (string)null);
                });

            modelBuilder.Entity("ScheduleApi.Data.JobHistoryExecution", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("ErrorMessage")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("GuidJob")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastExecution")
                        .HasColumnType("datetime");

                    b.Property<string>("NameJob")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("StatusEnd")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__JobHisto__3214EC074A015E44");

                    b.ToTable("JobHistoryExecution", (string)null);
                });

            modelBuilder.Entity("ScheduleApi.Data.JobHistoryModified", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<Guid>("GuidJob")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("NameJob")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id")
                        .HasName("PK__JobHisto__3214EC07201CB68A");

                    b.ToTable("JobHistoryModified", (string)null);
                });

            modelBuilder.Entity("ScheduleApi.Data.JobStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<Guid>("GuidJob")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__JobStatu__3214EC07DEDD8195");

                    b.ToTable("JobStatus", (string)null);
                });

            modelBuilder.Entity("ScheduleApi.Data.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ipaddress")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("IPAddress");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK__Server__3214EC076AA2AB77");

                    b.HasIndex(new[] { "TagName" }, "UQ__Server__BDE0FD1D1A7B2240")
                        .IsUnique();

                    b.ToTable("Server", (string)null);
                });

            modelBuilder.Entity("ScheduleApi.Model.User.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "631ac7af-a965-4c1f-9b05-f40d426c8ad4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "892d2982-5bb3-4473-8609-96ef1d3e5180",
                            Email = "admin@schedule.com",
                            EmailConfirmed = false,
                            FirstName = "System",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@SCHEDULE.COM",
                            NormalizedUserName = "ADMIN@SCHEDULE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEBGVUTwrbhO4SVkgCwHMS1gHFc2zKRkPhI7DZyQ4bS7Nbve6Eu2wXCb1COEerLb4FQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a3aa3123-801b-4428-8f0e-e54c625bfb31",
                            TwoFactorEnabled = false,
                            UserName = "admin@schedule.com"
                        },
                        new
                        {
                            Id = "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "043a5e86-e917-4d1c-b4d5-6b40973363a2",
                            Email = "user_job_creator@schedule.com",
                            EmailConfirmed = false,
                            FirstName = "System",
                            LastName = "UserjobCreator",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER_JOB_CREATOR@SCHEDULE.COM",
                            NormalizedUserName = "USER_JOB_CREATO@SCHEDULE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPWJGh1e07Ayrk+81zKE3UjiqS0Bm8VZysqQIES2Mz1l4BGqUto8ePIspM+7JNCBMA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "595d9518-2e9e-4731-a3f9-ec0409141f03",
                            TwoFactorEnabled = false,
                            UserName = "user_job_creator@schedule.com"
                        },
                        new
                        {
                            Id = "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b5755e31-8f9a-409e-9cd5-6e04a625c6b4",
                            Email = "user_executor@schedule.com",
                            EmailConfirmed = false,
                            FirstName = "System",
                            LastName = "UserExecutor",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER_EXECUTOR@SCHEDULE.COM",
                            NormalizedUserName = "USER_EXECUTOR@SCHEDULE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAZO0ghD/bceAZBaqvljbR+Hm6Apea9go6F6ogLTRlDCMoRjbkXjT64k8KJZWGpwgQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ef0076e1-2ce9-4eeb-812a-97ea426bdb34",
                            TwoFactorEnabled = false,
                            UserName = "user_executor@schedule.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ScheduleApi.Model.User.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ScheduleApi.Model.User.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScheduleApi.Model.User.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ScheduleApi.Model.User.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScheduleApi.Data.JobExecution", b =>
                {
                    b.HasOne("ScheduleApi.Data.Server", "Server")
                        .WithMany("JobExecutions")
                        .HasForeignKey("ServerId")
                        .IsRequired()
                        .HasConstraintName("FK_JobExecution_ToServer");

                    b.Navigation("Server");
                });

            modelBuilder.Entity("ScheduleApi.Data.Server", b =>
                {
                    b.Navigation("JobExecutions");
                });
#pragma warning restore 612, 618
        }
    }
}
