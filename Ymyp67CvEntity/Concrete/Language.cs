using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Concrete
{
    public sealed class Language : BaseEntity
    {
        public string Name { get; set; }
        public byte Level { get; set; } 
       
    }
}
