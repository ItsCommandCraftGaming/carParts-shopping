using Microsoft.EntityFrameworkCore;
using SummerPractice2026Blazor.Repository.Entities;
using SummerPractice2026Blazor.Repository.Interfaces;

namespace SummerPractice2026Blazor.Repository
{
  public class ArticleCategoryRepository(ApplicationDbContext dbContext) : IArticleCategoryRepository
  {
    public async Task<ArticleCategory> CreateArticleCategory(ArticleCategory articleCategory)
    {
      dbContext.ArticleCategories.Add(articleCategory);
      await dbContext.SaveChangesAsync();
      return articleCategory;
    }

    public async Task<bool> DeleteArticleCategory(Guid id)
    {
      var articleCategoryFromDb = await dbContext.ArticleCategories.FirstOrDefaultAsync(x => x.Id == id);
      if (articleCategoryFromDb is null)
      {
        return false;
      }

      dbContext.ArticleCategories.Remove(articleCategoryFromDb);
      await dbContext.SaveChangesAsync();
      return true;
    }

    public async Task<List<ArticleCategory>> GetAllArticleCategories()
    {
      return await dbContext.ArticleCategories.AsNoTracking().ToListAsync();
    }

    public async Task<ArticleCategory> GetArticleCategoryById(Guid id)
    {
      var articleCategoryFromDb = await dbContext.ArticleCategories.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
      return articleCategoryFromDb ?? new ArticleCategory();
    }

    public async Task<ArticleCategory> UpdateArticleCategory(ArticleCategory articleCategory)
    {
      dbContext.ArticleCategories.Update(articleCategory);
      await dbContext.SaveChangesAsync();
      return articleCategory;
    }
  }
}
