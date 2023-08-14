using EduHome.DataAccessLayer.Entity;

namespace EduHome.ViewModels
{
    public class AboutViewModel
    {
        public List<AboutBanner> AboutBanners { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Carusel> Carusels { get; set; }
        public List<Video> Videos { get; set; }
        public List<NoticeLeft> NoticeLefts { get; set; }

    }
}