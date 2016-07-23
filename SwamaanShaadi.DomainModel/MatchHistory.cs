using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainClasses
{
    public class MatchHistory
    {
        public int MatchHistoryId { get; set; }
        public int MemberID { get; set; }
        public int MatchID { get; set; }
        public DateTime? EmailAlertSentOn { get; set; }
        public DateTime? MobileAlertSentOn { get; set; }
        public DateTime MatchedBySystemOn { get; set; }

        public virtual Member Member { get; set; }
    }
}
