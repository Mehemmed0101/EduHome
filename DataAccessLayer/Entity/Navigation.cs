namespace EduHome.DataAccessLayer.Entity
{
    public class Navigation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Link { get; set; }
        public int? ParentId { get; set; }
        public bool isMain { get; set; }
        public int HeaderId { get; set; }
        public Header Header { get; set; }
    }
}