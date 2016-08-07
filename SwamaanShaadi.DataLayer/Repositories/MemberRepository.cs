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
    public class MemberRepository : IDisposable
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

        #region IDisposable
        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ~MemberRepository()
        {
            Dispose(false);
        }
        #endregion

    }
}
