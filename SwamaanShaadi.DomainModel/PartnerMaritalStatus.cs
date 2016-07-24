namespace SwamaanShaadi.DomainClasses
{
    public class PartnerMaritalStatus : IObjectWithState
    {
        public int PartnerMaritalStatusId { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int MaritalStatusId { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

        public State State { get; set; }
    }
}