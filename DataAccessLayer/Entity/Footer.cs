namespace EduHome.DataAccessLayer.Entity
{
    public class Footer
    {
        public int Id { get; set; }
        public string LogoUrl { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public ICollection<SocialMedia> SocialMedia { get; set; }
        public ICollection<Information> Information { get; set; }
        public ICollection<UsefulLinks> UsefulLinks { get; set; }
        public ICollection<GetInTouch> GetInTouch { get; set; }
    }
}
