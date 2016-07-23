using SwamaanShaadi.DomainClasses;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SwamaanShaadi.DataLayer
{
    public interface IMemberRepository : IDisposable
    {
        IQueryable<Member> All { get; }
        IQueryable<Member> AllIncluding(params Expression<Func<Member, object>>[] includeProperties);
        Member Find(int id);
        void InsertOrUpdate(Member member);
        void Delete(int id);
        void Save();
    }
}