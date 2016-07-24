using System;

namespace SwamaanShaadi.DomainClasses
{
    public class PartnerCaste : IObjectWithState
    {
        public int PartnerCasteId { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int CasteId { get; set; }
        public Caste Caste { get; set; }

        public State State { get; set; }
    }
}