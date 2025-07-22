using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ymyp67CvEntity.Concrete;



namespace Ymyp67CvDataAccess.Contexts
{
    public sealed class Ymyp67CvProjectDbContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Contact> Contacts { get; set; }


    }
}
