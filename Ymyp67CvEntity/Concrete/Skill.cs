using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Concrete
{
    public sealed class Skill : BaseEntity
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public bool IsProgramLanguageAndTool { get; set; } 
        
    }
}
