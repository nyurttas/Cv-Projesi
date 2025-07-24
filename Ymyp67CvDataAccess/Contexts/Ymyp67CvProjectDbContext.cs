using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ymyp67CvEntity.Concrete;



namespace Ymyp67CvDataAccess.Contexts
{
    public sealed class Ymyp67CvProjectDbContext(DbContextOptions<Ymyp67CvProjectDbContext> options) : DbContext(options)
    {
        //primary constructor nedir?
        //primary constructor, classın kendisi ile aynı isme sahip olan bir constructor'dır.

        //public Ymyp67CvProjectDbContext(DbContextOptions<Ymyp67CvProjectDbContext> options) : base(options)
        //{

        //}
        //Burada modelBuilder ile yaptığımız konfigürasyonları Configuration klasöründeki ilgili classlar yardımıyla yaptık.
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Education>().Property(e => e.School).HasMaxLength(100);
        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //IEntityTypeConfiguration<T> interface'ini implement eden classları otomatik olarak bulur ve uygular.
            //Bu sayede her bir entity için ayrı ayrı konfigürasyon classları oluşturabiliriz.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<About> Abouts { get; set; }
       
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialAccount> SocialAccounts { get; set; }







    }
}
