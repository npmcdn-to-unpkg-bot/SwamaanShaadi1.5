using System.Collections.Generic;

namespace SwamaanShaadi.DomainClasses
{
    public class HomeState : IObjectWithState
    {
        public HomeState()
        {
            this.Districts = new List<District>();
        }

        public int HomeStateId { get; set; }
        public string StateName { get; set; }
        public virtual IList<District> Districts { get; set; }

        public State State { get; set; }
    }
}
