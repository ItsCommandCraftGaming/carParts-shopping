using SummerPractice2026Blazor.Repository.Entities;

namespace SummerPractice2026Blazor.Repository.Interfaces
{
  public interface IArticleRepository
  {
    Task<Article> CreateArticle(Article article);

    Task<bool> DeleteArticle(Guid id);

    Task<List<Article>> GetAllArticles();

    Task<Article> GetArticleById(Guid id);

    Task<Article> UpdateArticle(Article article);
  }
}
