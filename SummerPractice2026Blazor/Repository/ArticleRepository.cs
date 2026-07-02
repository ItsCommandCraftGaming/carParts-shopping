using Microsoft.EntityFrameworkCore;
using SummerPractice2026Blazor.Repository.Entities;
using SummerPractice2026Blazor.Repository.Interfaces;

namespace SummerPractice2026Blazor.Repository
{
  public class ArticleRepository(ApplicationDbContext dbContext) : IArticleRepository
  {
    public async Task<Article> CreateArticle(Article article)
    {
      dbContext.Articles.Add(article);
      await dbContext.SaveChangesAsync();
      return article;
    }

    public async Task<bool> DeleteArticle(Guid id)
    {
      var article = await dbContext.Articles.FindAsync(id);
      if (article == null) return false;

      dbContext.Articles.Remove(article);
      await dbContext.SaveChangesAsync();
      return true;
    }

    public async Task<List<Article>> GetAllArticles()
    {
      return await dbContext.Articles.Include(a => a.ArticleCategory).AsNoTracking().ToListAsync();
    }

    public async Task<Article> GetArticleById(Guid id)
    {
      return await dbContext.Articles.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id) ?? new Article();
    }

    public async Task<Article> UpdateArticle(Article article)
    {
      var existingArticle = await dbContext.Articles.FindAsync(article.Id);
      if (existingArticle == null) return article;

      existingArticle.Name = article.Name;
      existingArticle.Price = article.Price;
      existingArticle.Description = article.Description;
      existingArticle.SpecialTag = article.SpecialTag;
      existingArticle.ArticleCategoryId = article.ArticleCategoryId;
      existingArticle.ImageUrl = article.ImageUrl;

      dbContext.Articles.Update(existingArticle);
      await dbContext.SaveChangesAsync();

      return existingArticle;
    }
  }
}
