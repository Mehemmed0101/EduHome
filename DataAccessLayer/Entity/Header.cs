namespace EduHome.DataAccessLayer.Entity
{
    public class Header
    {
        public int Id { get; set; }
        public string LogoUrl { get; set; }
        public ICollection<Navigation> Navigation { get; set; }
    }
}