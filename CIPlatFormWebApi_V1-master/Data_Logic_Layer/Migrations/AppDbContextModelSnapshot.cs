﻿// <auto-generated />
using System;
using Data_Logic_Layer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data_Logic_Layer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data_Logic_Layer.Entity.MissionDto", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MissionId"));

                    b.Property<int?>("Availability")
                        .HasColumnType("integer");

                    b.Property<string>("Challenge")
                        .HasColumnType("text");

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<int?>("CountryId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Introduction")
                        .HasColumnType("text");

                    b.Property<int?>("MissionAchieved")
                        .HasColumnType("integer");

                    b.Property<string>("MissionImage")
                        .HasColumnType("text");

                    b.Property<string>("MissionObject")
                        .HasColumnType("text");

                    b.Property<int?>("MissionType")
                        .HasColumnType("integer");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<int?>("SeatsLeft")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ThemeId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int?>("TotalSeats")
                        .HasColumnType("integer");

                    b.HasKey("MissionId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("Data_Logic_Layer.Entity.Skill", b =>
                {
                    b.Property<string>("SkillId")
                        .HasColumnType("text");

                    b.Property<string>("IsDeleted")
                        .HasColumnType("text");

                    b.Property<string>("SkillName")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.HasKey("SkillId");

                    b.ToTable("MissionSkills");
                });

            modelBuilder.Entity("Data_Logic_Layer.Entity.Theme", b =>
                {
                    b.Property<int>("ThemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ThemeId"));

                    b.Property<string>("ThemeDescription")
                        .HasColumnType("text");

                    b.Property<string>("ThemeImage")
                        .HasColumnType("text");

                    b.Property<string>("ThemeName")
                        .HasColumnType("text");

                    b.HasKey("ThemeId");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("Data_Logic_Layer.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Data_Logic_Layer.Entity.UserDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Avilability")
                        .HasColumnType("text");

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<int?>("CountryId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LinkdInUrl")
                        .HasColumnType("text");

                    b.Property<string>("Manager")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MyProfile")
                        .HasColumnType("text");

                    b.Property<string>("MySkills")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("UserImage")
                        .HasColumnType("text");

                    b.Property<string>("WhyIVolunteer")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
