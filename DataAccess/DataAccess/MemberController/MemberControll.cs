using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;

namespace DataAccess.MemberController
{
    public class MemberControll : IMember
    {
        MemberRepository memberRepository = new MemberRepository();

        private bool checkAdminLogin(string email, string password)
        {
            bool checkAdminLogin = false;

            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", true, true)
                .Build();

            string adminEmail = config["DefaultAccounts:Email"];
            string adminPassword = config["DefaultAccounts:Password"];
            checkAdminLogin = (email == adminEmail) && (password == adminPassword);

            return checkAdminLogin;
        }

        public void CreateMember(MemberObject member)
        {
            
            memberRepository.CreateMember(member);
        }

        public void DeleteMember(int memberId)
        {
            
            memberRepository.DeleteMember(memberId);
        }

        public IEnumerable<MemberObject> FilterMemberByCity(string City)
        {
            
            IEnumerable<MemberObject> list = memberRepository.GetMemberList();
            IEnumerable<MemberObject> result = from member in list
                                         where member.City.Contains(City)
                                         select member;
            return result;
        }

        public IEnumerable<MemberObject> FilterMemberByCountry(string Country)
        {
            
            IEnumerable<MemberObject> list = memberRepository.GetMemberList();
            IEnumerable<MemberObject> result = from member in list
                                         where member.Country.Contains(Country)
                                         select member;
            return result;
        }

        public MemberObject Login(string email, string password)
        {
            
            MemberObject loginMember = null;
            if (checkAdminLogin(email, password) == false)
            {
                try
                {
                    IEnumerable<MemberObject> list = memberRepository.GetMemberList();
                    loginMember = (from member in list
                                   where (member.Email == email)
                                   && (member.Password == password)
                                   select member).First();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("no elements"))
                    {
                        throw new Exception("Incorrect Username or Password!");
                    }
                }

            }
            else
            {
                loginMember = new MemberObject
                {
                    MemberID = 0,
                    MemberName = "Admin",
                    Email = email,
                    Password = password,
                    City = string.Empty,
                    Country = string.Empty,
                };
            }
            return loginMember;
        }

        public MemberObject SearchMemberByID(int memberId)
        {
            
            return memberRepository.GetMember(memberId);
        }

        public IEnumerable<MemberObject> SearchMemberByName(string name)
        {
            
            IEnumerable<MemberObject> list = memberRepository.GetMemberList();
            IEnumerable<MemberObject> result = from member in list
                                         where member.MemberName.Contains(name)
                                         select member;
            return result;
        }

        public void UpdateMember(MemberObject member)
        {
            
            memberRepository.UpdateMember(member);
        }

        public IEnumerable<MemberObject> GetMemberList()
        {
            return memberRepository.GetMemberList();
        }
    }
}
