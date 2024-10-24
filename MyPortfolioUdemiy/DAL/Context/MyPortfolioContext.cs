using Microsoft.EntityFrameworkCore;
using MyPortfolioUdemiy.DAL.Entities;

namespace MyPortfolioUdemiy.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        //Baglantı methodu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ASUS;initial Catalog=MyPortfolioDb;TrustServerCertificate=True; integrated Security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
