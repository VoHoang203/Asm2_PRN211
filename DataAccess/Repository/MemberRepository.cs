using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {

        public void Create(Member member)
        {
            PRN221_Assignment02Context.Instance.Add(member);
            PRN221_Assignment02Context.Instance.SaveChanges();
        }

        public void Delete(string email)
        {
            Member member = GetMember(email);
            PRN221_Assignment02Context.Instance.Remove(member);
            PRN221_Assignment02Context.Instance.SaveChanges();
        }

        public Member GetMember(string email)
        {
            return PRN221_Assignment02Context.Instance.Members.ToList().FirstOrDefault(c => c.Email.Equals(email));
        }

        public List<Member> GetMembers() => PRN221_Assignment02Context.Instance.Members.ToList();

        public void Update()
        {
            PRN221_Assignment02Context.Instance.SaveChanges();
        }
    }
}
