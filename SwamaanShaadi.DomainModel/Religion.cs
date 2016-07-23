using System.Collections.Generic;

namespace SwamaanShaadi.DomainClasses
{
    public class Religion
    {
        public Religion()
        {
            this.Castes = new List<Caste>();
        }

        public int ReligionId { get; set; }
        public string ReligionName { get; set; }
        public virtual IList<Caste> Castes { get; set; }
    }
}