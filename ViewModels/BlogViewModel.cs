using EduHome.DataAccessLayer.Entity;

namespace EduHome.ViewModels
{
    public class BlogViewModel
    {
        public List<Blog> Blogs { get; set; }
        public List<PageCount> PageCounts { get; set; }
    }
}