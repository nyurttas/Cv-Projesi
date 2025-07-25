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
    public class EfCertificateRepository : EfGenericRepository<Certificate, Ymyp67CvProjectDbContext>, ICertificateRepository
    {
        public EfCertificateRepository(Ymyp67CvProjectDbContext context) : base(context)
        {
        }
    }
}
