using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
namespace DataAccess
{
    public interface UserDAO
    {
        public TblMember Login(string email, string password);
        public List<TblMember> getMemberDTO();

        public bool AddMember(TblMember user);
        public bool DeleteMember(int userID);
        public bool UpdateMember(TblMember user);


        public TblMember searchMememberByID(int memberID);
    }
}
