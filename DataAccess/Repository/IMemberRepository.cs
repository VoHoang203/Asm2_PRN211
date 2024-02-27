using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        List<Member> GetMembers();

        void Update();

        void Create(Member member);

        void Delete(string email);

        Member GetMember(string email);
    }
}
