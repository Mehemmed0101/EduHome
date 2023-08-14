using EduHome.DataAccessLayer.Entity;

namespace EduHome.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Slider { get; set; }
        public List<NoticeLeft> NoticeLeft { get; set; }
        public List<NoticeRight> NoticeRight { get; set; }
        public List<Banner> Banner { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
        public List<Carusel> Carusels { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
