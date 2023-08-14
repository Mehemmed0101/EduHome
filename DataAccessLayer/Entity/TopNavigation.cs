namespace EduHome.DataAccessLayer.Entity
{
    public class TopNavigation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public int HeaderTopId { get; set; }
        public HeaderTop HeaderTop { get; set; }
    }
}
