using SwamaanShaadi.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer
{
    public class MemberRepository
    {
        public Member GetMemberProfile(int memberId)
        {
            Member member = null;
            using (MembersContext context = new MembersContext())
            {
                member = context.Members.Find(memberId);
            }
            return member;
        }

        public void UpdateMemberProfile(int memberId, Member member)
        {
            using (MembersContext context = new MembersContext())
            {
                if (memberId == 0)
                {
                    context.Members.Add(member);                    
                }
                else
                {
                    context.Members.Attach(member);
                    context.Entry(member).State = EntityState.Modified;
                }
                context.SaveChanges();
            }                
        }
    }
}
