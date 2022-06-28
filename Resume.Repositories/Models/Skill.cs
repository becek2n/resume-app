using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Repositories.Models
{
    public class Country
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public Province Province { get; set; }
        public City City { get; set; }
        public Nationality Nationality { get; set; }
    }

    public class Province
    {
        [Key]
        public string Id { get; set; }
        public string CountryId { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }
        public List<City> Cities { get; set; }
    }

    public class City
    {
        [Key]
        public string Id { get; set; }
        public string ProvinceId { get; set; }
        public string Name { get; set; }

        public Province Province { get; set; }
    }

    public class Nationality
    {
        [Key]
        public string Id { get; set; }
        public string CountyId { get; set; }
        public string Name { get; set; }
    }
}
