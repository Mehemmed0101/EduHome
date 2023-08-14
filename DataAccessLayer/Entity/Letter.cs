namespace EduHome.DataAccessLayer.Entity
{
    public class Letter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Alert> Alerts { get; set; }
    }
}