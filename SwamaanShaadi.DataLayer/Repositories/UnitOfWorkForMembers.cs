using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DataLayer
{
    public class UnitOfWorkForMembers : IDisposable
    {
        private readonly MembersContext _context;

        public UnitOfWorkForMembers()
        {
            _context = new MembersContext();
        }

        public UnitOfWorkForMembers(MembersContext context)
        {
            _context = context;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public MembersContext Context
        {
            get { return _context; }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
