using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Repositories.Models
{
    public class Social : BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public int GroupTypeId { get; set; }
        public string AccountName { get; set; }
        public string Url { get; set; }
        public Profiles Profile { get; set; }
        public GroupType GroupType { get; set; }

    }
}
