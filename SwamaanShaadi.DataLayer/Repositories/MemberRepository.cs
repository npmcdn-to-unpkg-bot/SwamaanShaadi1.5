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
    public class MemberRepository : IMemberRepository
    {
        MembersContext context = new MembersContext();

        public IQueryable<Member> All
        {
            get
            {
                return context.Members;
            }
        }

        public IQueryable<Member> AllIncluding(params Expression<Func<Member, object>>[] includeProperties)
        {
            IQueryable<Member> query = context.Members;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Member Find(int id)
        {
            return context.Members.Find(id);
        }


        /// <summary>
        /// For Member update alongwith related objects.
        /// When we do Add on root object, EF will mark all netsted objects as Add as well.
        /// Thus SaveChanges will INSERT complete object tree.
        /// </summary>
        /// <param name="member"></param>
        public void InsertGraph(Member member)
        {
            context.Members.Add(member);
        }

        //For Member only update, no update to related objects
        public void InsertOrUpdate(Member member)
        {
            if (member.MemberId == default(int))
            {
                //New entity
                context.Entry(member).State = EntityState.Added;
            }
            else
            {
                //Existing entity
                context.Entry(member).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var member = context.Members.Find(id);
            context.Members.Remove(member);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
