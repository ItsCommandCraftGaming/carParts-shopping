using FluentValidation;
using SummerPractice2026Blazor.Repository.Entities;

namespace SummerPractice2026Blazor.Validation
{
  public class ArticleValidator : AbstractValidator<Article>
  {
    public ArticleValidator()
    {
        RuleFor(a => a.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(150).WithMessage("Name cannot exceed 150 characters.");
        RuleFor(a => a.Price)
            .InclusiveBetween(0.01m, 1000).WithMessage("Preț între 0.01$ și 1000$");
        RuleFor(a => a.ArticleCategoryId)
            .NotEmpty().WithMessage("Category is required.");
    }
  }
}
