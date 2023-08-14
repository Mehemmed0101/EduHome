namespace EduHome.DataAccessLayer.Entity
{
    public class Alert
    {
        public int Id { get; set; }
        public int LetterId { get; set; }
        public Letter Letter { get; set; }
        public string Title { get; set; }
    }
}