using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainClasses
{
    public class ProfileFor : IObjectWithState
    {
        public int ProfileForId { get; set; }
        public string Relation { get; set; }

        public State State { get; set; }
    }
}
