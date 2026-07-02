using System.ComponentModel.DataAnnotations.Schema;

namespace SummerPractice2026Blazor.Repository.Entities
{
  public class Article
  {
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public string? SpecialTag { get; set; }

    public Guid ArticleCategoryId { get; set; }

    [ForeignKey(nameof(ArticleCategoryId))]
    public ArticleCategory ArticleCategory { get; set; } = null!;

    public string? ImageUrl { get; set; }
  }
}