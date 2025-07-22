using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Concrete
{
    public sealed class SocialAccount : BaseEntity  
    {
        public string Name { get; set; }
        public string WebUrl { get; set; }
        public string UserName { get; set; }
        public string Icon { get; set; }
       
      
    }
}
