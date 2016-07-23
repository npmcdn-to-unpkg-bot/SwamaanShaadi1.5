namespace SwamaanShaadi.DomainClasses
{
    public class District
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int HomeStateId { get; set; }
        public virtual HomeState HomeState { get; set; }
    }
}