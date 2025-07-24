using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ymyp67CvEntity.Concrete;

namespace Ymyp67CvDataAccess.Configurations
{
    internal class InterestConfiguration : IEntityTypeConfiguration<Interest>
    {
        public void Configure(EntityTypeBuilder<Interest> builder)
        {
            builder.Property(i => i.Description).HasMaxLength(500).IsRequired();
            builder.Property(i => i.Order).IsRequired();


        }
    }
}
