namespace SwamaanShaadi.DomainClasses
{
    public class Caste : IObjectWithState
    {
        public int CasteId { get; set; }
        public string CasteName { get; set; }
        public int ReligionId { get; set; }
        public virtual Religion Religion { get; set; }

        public State State { get; set; }
    }
}