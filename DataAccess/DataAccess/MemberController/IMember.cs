using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.MemberController
{
    public interface IMember
    {
        public MemberObject Login(string email, string password);
        public void CreateMember(MemberObject member);
        public void UpdateMember(MemberObject member);
        public void DeleteMember(int memberId);
        public MemberObject SearchMemberByID(int memberId);
        public IEnumerable<MemberObject> SearchMemberByName(string name);
        public IEnumerable<MemberObject> FilterMemberByCity(string City);
        public IEnumerable<MemberObject> FilterMemberByCountry(string Country);

    }
}
