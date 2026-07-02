using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SummerPractice2026Blazor.Repository.Entities;

namespace SummerPractice2026Blazor.Repository
{
  public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
  {
    public DbSet<ArticleCategory> ArticleCategories => Set<ArticleCategory>();

    public DbSet<Article> Articles => Set<Article>();
  }
}
