using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Concrete
{
    public sealed class Experience : BaseEntity
    {
        public string Title { get; set; }
        public string Company { get; set; } 
        public string Description { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
         
      
    }
}
