namespace EduHome.DataAccessLayer.Entity
{
    public class UsefulLinks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}
