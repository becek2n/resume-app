using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Repositories.Models
{
    public class User : BaseModel
    {
        [Key, Required]
        public Guid Id { get; set; }
        [MaxLength(10)]
        public string UserName { get; set; }
        public string Password { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(300)]
        public string Token { get; set; }
        [MaxLength(300)]
        public string RefreshToken { get; set; }
        public bool IsActive { get; set; }

        public List<Profiles> Profiles { get; set; }

    }

    public class BaseModel {
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
