namespace SwamaanShaadi.DomainModel
{
    public class Caste
    {
        public int CasteId { get; set; }
        public string CasteName { get; set; }
        public int ReligionId { get; set; }
        public virtual Religion Religion { get; set; }
    }
}