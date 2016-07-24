using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainClasses
{
    public class AccountStatus : IObjectWithState
    {
        public int AccountStatusId { get; set; }
        public string Status { get; set; }

        public State State { get; set; }
    }
}
