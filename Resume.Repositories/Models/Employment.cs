using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Repositories.Models
{
    public class Employment : BaseModel
    {
        [Key, Required]
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public int GroupTypeId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Company { get; set; }
        public string Address { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public Profiles Profile { get; set; }
        public GroupType GroupType { get; set; }
    }
}
