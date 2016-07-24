namespace SwamaanShaadi.DomainClasses
{
    public class PartnerDistrict : IObjectWithState
    {
        public int PartnerDistrictId { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int DistrictId { get; set; }
        public District District { get; set; }

        public State State { get; set; }
    }
}