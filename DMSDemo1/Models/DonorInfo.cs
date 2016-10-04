using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMSDemo1.Models
{
    public class DonorInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Suffix { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
        public string Identity { get; set; }
    }
}