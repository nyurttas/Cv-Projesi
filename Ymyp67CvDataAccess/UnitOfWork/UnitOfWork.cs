using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.UnitOfWorks;
using Ymyp67CvDataAccess.Contexts;

namespace Ymyp67CvDataAccess.UnitOfWork
{
    public class UnitOfWork(Ymyp67CvProjectDbContext context) : IUnitOfWork
    {
        private readonly Ymyp67CvProjectDbContext _context = context;

        public void Commit()
        {
          _context.SaveChanges();
        }

        public  async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
