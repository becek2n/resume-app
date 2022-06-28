﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Resume.Repositories;

namespace Resume.API.Migrations
{
    [DbContext(typeof(ResumeContext))]
    partial class ResumeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Resume.Repositories.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Institution")
                        .HasColumnType("text");

                    b.Property<bool>("IsCertified")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Degree")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GroupTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("School")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("GroupTypeId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Employment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GroupTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Employments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("836d32c4-7621-48bf-bcf2-92a8d0c404fe"),
                            Address = "Mampang Prapatan No. 100",
                            Company = "PT Asuransi Takaful Keluarga",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Analisa system, review project pengajuan",
                            EndDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupTypeId = 1,
                            Phone = "1233321",
                            ProfileId = new Guid("c703219e-073e-406b-b1f0-ed689574e407"),
                            StartDate = new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Manager Head of Business Analyst"
                        },
                        new
                        {
                            Id = new Guid("a49245ad-924a-4458-8dcd-f87fa6a7532e"),
                            Address = "Kuningan",
                            Company = "PT Heksa Solution Insurance",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Membuat aplikasi baru, mengembangkan aplikasi yang ada pada core system",
                            EndDate = new DateTime(2019, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupTypeId = 1,
                            Phone = "1233321",
                            ProfileId = new Guid("c703219e-073e-406b-b1f0-ed689574e407"),
                            StartDate = new DateTime(2014, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Senior Officer - Developer"
                        });
                });

            modelBuilder.Entity("Resume.Repositories.Models.GroupType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasIdentityOptions(16L, null, null, null, null, null)
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Group")
                        .HasColumnType("text");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GroupTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Group = "Employment",
                            Title = "Employment"
                        },
                        new
                        {
                            Id = 2,
                            Group = "Employment",
                            Title = "Internship"
                        },
                        new
                        {
                            Id = 3,
                            Group = "Education",
                            Title = "Formal"
                        },
                        new
                        {
                            Id = 4,
                            Group = "Education",
                            Title = "Non Formal"
                        },
                        new
                        {
                            Id = 5,
                            Group = "Language",
                            Title = "Native Speaker"
                        },
                        new
                        {
                            Id = 6,
                            Group = "Language",
                            Title = "Highly Proficient"
                        },
                        new
                        {
                            Id = 7,
                            Group = "Language",
                            Title = "Very Good Command"
                        },
                        new
                        {
                            Id = 8,
                            Group = "Social",
                            Title = "Youtube"
                        },
                        new
                        {
                            Id = 9,
                            Group = "Social",
                            Title = "Facebook"
                        },
                        new
                        {
                            Id = 11,
                            Group = "Social",
                            Title = "LinkedIn"
                        },
                        new
                        {
                            Id = 12,
                            Group = "Social",
                            Title = "Instagram"
                        },
                        new
                        {
                            Id = 13,
                            Group = "Level",
                            Title = "Beginner"
                        },
                        new
                        {
                            Id = 14,
                            Group = "Level",
                            Title = "Advance"
                        },
                        new
                        {
                            Id = 15,
                            Group = "Level",
                            Title = "Expert"
                        });
                });

            modelBuilder.Entity("Resume.Repositories.Models.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("GroupTypeId")
                        .HasColumnType("text");

                    b.Property<int?>("GroupTypeId1")
                        .HasColumnType("integer");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GroupTypeId1");

                    b.HasIndex("ProfileId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Licence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Licences");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Profiles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DOBPlace")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Hobbies")
                        .HasColumnType("text");

                    b.Property<string>("JobTitle")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("NationalityId")
                        .HasColumnType("integer");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c703219e-073e-406b-b1f0-ed689574e407"),
                            Address = "Pondok Sukmajaya Permai",
                            CityId = 0,
                            CountryId = 0,
                            DOB = new DateTime(1922, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DOBPlace = "Bogor",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "saya seorang IT developer memiliki pengalaman lebih dari 7 tahun",
                            JobTitle = "IT Developer",
                            NationalityId = 0,
                            Phone = "1233321",
                            UserId = new Guid("365250ec-2eb5-4ae4-946e-19776b42e46b")
                        });
                });

            modelBuilder.Entity("Resume.Repositories.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasIdentityOptions(16L, null, null, null, null, null)
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Python"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Golang"
                        },
                        new
                        {
                            Id = 3,
                            Title = "C"
                        },
                        new
                        {
                            Id = 4,
                            Title = "C++"
                        },
                        new
                        {
                            Id = 5,
                            Title = "C#"
                        },
                        new
                        {
                            Id = 6,
                            Title = "VB.NET"
                        },
                        new
                        {
                            Id = 7,
                            Title = ".NET"
                        },
                        new
                        {
                            Id = 8,
                            Title = "Netcore"
                        },
                        new
                        {
                            Id = 9,
                            Title = "Net Frameword"
                        },
                        new
                        {
                            Id = 10,
                            Title = "SQL Server"
                        },
                        new
                        {
                            Id = 11,
                            Title = "Mysql"
                        },
                        new
                        {
                            Id = 12,
                            Title = "Oracle"
                        },
                        new
                        {
                            Id = 13,
                            Title = "PostgreSQL"
                        },
                        new
                        {
                            Id = 14,
                            Title = "Informix"
                        },
                        new
                        {
                            Id = 15,
                            Title = "DB2"
                        });
                });

            modelBuilder.Entity("Resume.Repositories.Models.SkillSet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GroupTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<int?>("SkillId")
                        .HasColumnType("integer");

                    b.Property<int>("SklillId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillSets");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Social", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("AccountName")
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GroupTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GroupTypeId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Socials");
                });

            modelBuilder.Entity("Resume.Repositories.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("Token")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("UserName")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Email", "UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("365250ec-2eb5-4ae4-946e-19776b42e46b"),
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "januar.aransyah@gmail.com",
                            FirstName = "Januar",
                            IsActive = true,
                            LastName = "Aransyah",
                            UserName = "djanuar"
                        });
                });

            modelBuilder.Entity("Resume.Repositories.Models.Course", b =>
                {
                    b.HasOne("Resume.Repositories.Models.Profiles", "Profile")
                        .WithMany("Courses")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Education", b =>
                {
                    b.HasOne("Resume.Repositories.Models.GroupType", "GroupType")
                        .WithMany()
                        .HasForeignKey("GroupTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Resume.Repositories.Models.Profiles", "Profile")
                        .WithMany("Educations")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupType");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Employment", b =>
                {
                    b.HasOne("Resume.Repositories.Models.Profiles", "Profile")
                        .WithMany("Employments")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Language", b =>
                {
                    b.HasOne("Resume.Repositories.Models.GroupType", "GroupType")
                        .WithMany()
                        .HasForeignKey("GroupTypeId1");

                    b.HasOne("Resume.Repositories.Models.Profiles", "Profile")
                        .WithMany("Languages")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupType");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Licence", b =>
                {
                    b.HasOne("Resume.Repositories.Models.Profiles", "Profile")
                        .WithMany("Licences")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Profiles", b =>
                {
                    b.HasOne("Resume.Repositories.Models.User", "User")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Resume.Repositories.Models.SkillSet", b =>
                {
                    b.HasOne("Resume.Repositories.Models.Profiles", "Profile")
                        .WithMany("SkillSets")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Resume.Repositories.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId");

                    b.Navigation("Profile");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Social", b =>
                {
                    b.HasOne("Resume.Repositories.Models.GroupType", "GroupType")
                        .WithMany()
                        .HasForeignKey("GroupTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Resume.Repositories.Models.Profiles", "Profile")
                        .WithMany("Socials")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupType");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Resume.Repositories.Models.Profiles", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Educations");

                    b.Navigation("Employments");

                    b.Navigation("Languages");

                    b.Navigation("Licences");

                    b.Navigation("SkillSets");

                    b.Navigation("Socials");
                });

            modelBuilder.Entity("Resume.Repositories.Models.User", b =>
                {
                    b.Navigation("Profiles");
                });
#pragma warning restore 612, 618
        }
    }
}
