using System.Collections.Generic;

namespace SwamaanShaadi.DomainModel
{
    public class HomeState
    {
        public HomeState()
        {
            this.Districts = new List<District>();
        }

        public int HomeStateId { get; set; }
        public string StateName { get; set; }
        public virtual IList<District> Districts { get; set; }
    }
}
