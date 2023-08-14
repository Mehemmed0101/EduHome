using EduHome.DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EduHome.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Footer> Footer { get; set; }
        public DbSet<GetInTouch> GetInTouch { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<UsefulLinks> UsefulLinks { get; set; }
        public DbSet<Header> Header { get; set; }
        public DbSet<Navigation> Navigations { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<NoticeLeft> NoticeLeft { get; set; }
        public DbSet<NoticeRight> NoticeRight { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Letter> Letters { get; set; }
        public DbSet<Alert> Alert { get; set; }
        public DbSet<TopNavigation> TopNavigations { get; set; }
        public DbSet<HeaderTop> HeaderTop { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Carusel> Carusels { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<PageCount> PageCounts { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<AboutBanner> AboutBanners { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}