using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainClasses
{
    public class MaritalStatus : IObjectWithState
    {
        public int MaritalStatusId { get; set; }
        public string Status { get; set; }

        public State State { get; set; }
    }
}
