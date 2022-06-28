using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Repositories.Models
{
    public class Education : BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public int GroupTypeId { get; set; }
        public string School { get; set; }
        public string Degree { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public Profiles Profile { get; set; }
        public GroupType GroupType { get; set; }

    }
}
