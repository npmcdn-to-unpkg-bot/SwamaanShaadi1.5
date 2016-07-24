namespace SwamaanShaadi.DomainClasses
{
    public class Education : IObjectWithState
    {
        public int EducationId { get; set; }
        public string Degree { get; set; }

        public State State { get; set; }
    }
}