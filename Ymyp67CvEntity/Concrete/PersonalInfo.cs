using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Ymyp67CvEntity.Concrete
{
    public sealed class PersonalInfo :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; } 
        public bool MaritalStatus { get; set; } = false;
        public Gender Gender { get; set; }
        public string DrivingLicence { get; set; } =string.Empty;
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; } = string.Empty;
        public string Nationality { get; set; } ="Türkiye";


    }
}
