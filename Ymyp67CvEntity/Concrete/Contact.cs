using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Concrete
{
    public sealed class Contact :BaseEntity
    {
        public string Address { get; set; } 

        public string Town { get; set; } 
        public string City { get; set; } 
       
        public string Phone { get; set; }
        public string Email { get; set; }


    }
}
