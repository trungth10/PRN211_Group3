using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public MemberObject GetMember(int merberid);
        public IEnumerable<MemberObject> GetMemberList();
        public void CreateMember(MemberObject member);
        public void UpdateMember(MemberObject member);
        public void DeleteMember(int memberid);

    }
}
