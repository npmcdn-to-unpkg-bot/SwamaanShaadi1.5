namespace SwamaanShaadi.DomainClasses
{
    public class PartnerEducation : IObjectWithState
    {
        public int PartnerEducationId { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int EducationId { get; set; }
        public Education Education { get; set; }

        public State State { get; set; }
    }
}