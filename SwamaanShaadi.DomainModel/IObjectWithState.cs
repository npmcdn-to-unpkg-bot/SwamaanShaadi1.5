using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainClasses
{
    public interface IObjectWithState
    {
        State State { get; set; }
    }

    public enum State
    {
        Added,
        Unchanged,
        Modified,
        Deleted
    }
}
