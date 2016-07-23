using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainClasses
{
    public class MemberPhotograph
    {
        public int MemberPhotographId { get; set; }
        public int MemberId { get; set; }
        public bool IsProfilePhoto { get; set; }
        public string PhotographPath { get; set; }

        public Member Member { get; set; }

    }
}
