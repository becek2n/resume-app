using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Repositories.Models
{
    public class Language : BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string GroupTypeId { get; set; }
        public string Title { get; set; }
        public Profiles Profile { get; set; }
        public GroupType GroupType { get; set; }

    }
}
