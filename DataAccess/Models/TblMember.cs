using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class TblMember
    {
        public TblMember()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int MemberId { get; set; }
        public string Email { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Password { get; set; } = null!;

        public TblMember(int memberId, string email, string password, string city, string country, string companyName)
        {
            MemberId = memberId;
            Email = email;
            CompanyName = companyName;
            City = city;
            Country = country;
            Password = password;

        }
        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
