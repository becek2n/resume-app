using System;

namespace Resume.DTO.Request
{
    public class ProfileRequest
    {
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
    }
}
