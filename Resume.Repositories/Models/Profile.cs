using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Repositories.Models
{
    public class Profiles : BaseModel
    {
        [Key, Required]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int NationalityId { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public string DOBPlace { get; set; }
        public string Photo { get; set; }
        public string Hobbies { get; set; }

        public User User { get; set; }
        public List<Employment> Employments { get; set; }
        public List<Education> Educations { get; set; }
        public List<Course> Courses { get; set; }
        public List<Social> Socials { get; set; }
        public List<SkillSet> SkillSets { get; set; }
        public List<Licence> Licences { get; set; }
        public List<Language> Languages { get; set; }
    }
}
