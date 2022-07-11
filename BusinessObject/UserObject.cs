using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Models;
namespace BusinessObject
{
    public class UserObject : UserDAO
    {

        private FStoreContext context = new FStoreContext();
        public TblMember Login(string email, string password)
        {
            FStoreContext db = new FStoreContext();
            TblMember user = (from c in db.TblMembers
                                where c.Email == email && c.Password == password
                                select c).FirstOrDefault();


            return user;
        }

        public bool AddMember(TblMember user)
        {
            context.TblMembers.Add(user);
            int row = context.SaveChanges();
            return row > 0;
        }

        public bool DeleteMember(int userID)
        {
            TblMember user = context.TblMembers.Find(userID);
            context.TblMembers.Remove(user);
            int row = context.SaveChanges();
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        public List<TblMember> getMemberDTO()
        {
            var result = from p in context.TblMembers
                         select new TblMember(p.MemberId, p.Email, p.Password, p.Country, p.City, p.CompanyName);

            return result.ToList();
        }
        public bool UpdateMember(TblMember user)
        {
            TblMember result = (from p in context.TblMembers
                                where p.MemberId == user.MemberId
                                select p).FirstOrDefault();
            if (result != null)
            {
                result.MemberId = user.MemberId;
                result.Email = user.Email;
                result.Password = user.Password;
                result.Country = user.Country;
                result.City = user.City;
                result.CompanyName = user.CompanyName;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public TblMember searchMememberByID(int userID)
        {
            TblMember result = (from p in context.TblMembers
                                where p.MemberId == userID
                                select p).FirstOrDefault();
            return result;
        }
    }
}
