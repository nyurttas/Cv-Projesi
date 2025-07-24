using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Ymyp67CvDataAccess.Abstract;
using Ymyp67CvDataAccess.Contexts;
using Ymyp67CvEntity.Concrete;

namespace Ymyp67CvDataAccess.Concrete
{
    public sealed class EfContactRepository : EfGenericRepository<Contact, Ymyp67CvProjectDbContext>, IContactRepository
    {
        public EfContactRepository(Ymyp67CvProjectDbContext context) : base(context)
        {
        }
    }
}
