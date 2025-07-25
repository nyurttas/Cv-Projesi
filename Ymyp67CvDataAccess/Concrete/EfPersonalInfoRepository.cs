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
    public class EfPersonalInfoRepository : EfGenericRepository<PersonalInfo, Ymyp67CvProjectDbContext>, IPersonalInfoRepository
    {
        public EfPersonalInfoRepository(Ymyp67CvProjectDbContext context) : base(context)
        {
        }
    }
}
