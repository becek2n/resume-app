using Microsoft.EntityFrameworkCore;
using Resume.Repositories.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Repositories
{
    public class ResumeContext : DbContext
    {
        public ResumeContext(DbContextOptions<ResumeContext> options) : base(options) 
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=resume;Username=root;Password=1q2w3e");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => {

                entity.Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");

                entity.HasIndex(u => new { u.Email, u.UserName })
                    .IsUnique();

                entity.HasIndex(e => e.Email).IsUnique();
                
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Employment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");

            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Social>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<SkillSet>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Licence>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<GroupType>(entity => {

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasIdentityOptions(startValue:16);

            });

            modelBuilder.Entity<Skill>(entity => {

                entity.Property(e => e.Id).HasIdentityOptions(startValue: 16);

            });




            //seed
            modelBuilder.Entity<GroupType>().HasData(
                new GroupType { Id = 1, Group = "Employment", Title = "Employment",  },    
                new GroupType { Id = 2, Group = "Employment", Title = "Internship", },
                new GroupType { Id = 3, Group = "Education", Title = "Formal", },
                new GroupType { Id = 4, Group = "Education", Title = "Non Formal", },
                new GroupType { Id = 5, Group = "Language", Title = "Native Speaker", },
                new GroupType { Id = 6, Group = "Language", Title = "Highly Proficient", },
                new GroupType { Id = 7, Group = "Language", Title = "Very Good Command", },
                new GroupType { Id = 8, Group = "Social", Title = "Youtube", },
                new GroupType { Id = 9, Group = "Social", Title = "Facebook", },
                new GroupType { Id = 11, Group = "Social", Title = "LinkedIn", },
                new GroupType { Id = 12, Group = "Social", Title = "Instagram", },
                new GroupType { Id = 13, Group = "Level", Title = "Beginner", },
                new GroupType { Id = 14, Group = "Level", Title = "Advance", },
                new GroupType { Id = 15, Group = "Level", Title = "Expert", }
            );

            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Title = "Python", },
                new Skill { Id = 2, Title = "Golang", },
                new Skill { Id = 3, Title = "C", },
                new Skill { Id = 4, Title = "C++", },
                new Skill { Id = 5, Title = "C#", },
                new Skill { Id = 6, Title = "VB.NET", },
                new Skill { Id = 7, Title = ".NET", },
                new Skill { Id = 8, Title = "Netcore", },
                new Skill { Id = 9, Title = "Net Frameword", },
                new Skill { Id = 10, Title = "SQL Server", },
                new Skill { Id = 11, Title = "Mysql", },
                new Skill { Id = 12, Title = "Oracle", },
                new Skill { Id = 13, Title = "PostgreSQL", },
                new Skill { Id = 14, Title = "Informix", },
                new Skill { Id = 15, Title = "DB2", }
            );

            //DATA
            Guid userGuid = Guid.NewGuid();
            Guid profileGuid = Guid.NewGuid();

            modelBuilder.Entity<User>().HasData(
                new User { Id = userGuid, FirstName = "Januar", LastName = "Aransyah", UserName ="djanuar", Email = "januar.aransyah@gmail.com", IsActive = true }
            );

            //profile
            modelBuilder.Entity<Profiles>().HasData(
                new Profiles
                {
                    Id = profileGuid,
                    UserId = userGuid,
                    JobTitle = "IT Developer",
                    DOBPlace = "Bogor",
                    DOB = DateTime.Parse("1922-01-05"),
                    Phone = "1233321",
                    Address = "Pondok Sukmajaya Permai",
                    Description = "saya seorang IT developer memiliki pengalaman lebih dari 7 tahun"
                }
            );

            //employment
            modelBuilder.Entity<Employment>().HasData(new[] {
                new Employment
                {
                    Id = Guid.NewGuid(),
                    GroupTypeId = 1,
                    ProfileId = profileGuid,
                    Company = "PT Asuransi Takaful Keluarga",
                    Title = "Manager Head of Business Analyst",
                    Phone = "1233321",
                    Address = "Mampang Prapatan No. 100",
                    Description = "Analisa system, review project pengajuan",
                    StartDate = DateTime.Parse("2019-06-01"),
                    EndDate = DateTime.Parse("2023-12-31"),
                },
                new Employment
                {
                    Id = Guid.NewGuid(),
                    GroupTypeId = 1,
                    ProfileId = profileGuid,
                    Company = "PT Heksa Solution Insurance",
                    Title = "Senior Officer - Developer",
                    Phone = "1233321",
                    Address = "Kuningan",
                    Description = "Membuat aplikasi baru, mengembangkan aplikasi yang ada pada core system",
                    StartDate = DateTime.Parse("2014-06-01"),
                    EndDate = DateTime.Parse("2019-12-31"),
                }
            });

        }

        //entities
        public DbSet<User> Users { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SkillSet> SkillSets { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Licence> Licences { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<GroupType> GroupTypes { get; set; }
    }
}
