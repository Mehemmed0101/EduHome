namespace EduHome.DataAccessLayer.Entity
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Address { get; set; }
    }
}