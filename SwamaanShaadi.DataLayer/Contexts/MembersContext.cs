using SwamaanShaadi.DomainClasses;
using System.Data.Entity;

namespace SwamaanShaadi.DataLayer
{
    public class MembersContext : DbContext
    {
        public DbSet<Member> Members { get; set; }

    }
}
