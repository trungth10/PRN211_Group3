using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public MemberObject GetMember(int memberID) => MemberDAO.Instance.GetMemberByID(memberID);
        public IEnumerable<MemberObject> GetMemberList() => MemberDAO.Instance.GetMemberList();
        public void CreateMember(MemberObject member) => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int memberID) => MemberDAO.Instance.Remove(memberID);
        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);

        
    }
}
