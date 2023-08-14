namespace EduHome.DataAccessLayer.Entity
{
    public class HeaderTop
    {
        public int Id { get; set; }
        public string Connection { get; set; }
        public ICollection<TopNavigation> TopNavigations { get; set; }
    }
}