using FluentValidation;
using SummerPractice2026Blazor.Repository.Entities;

namespace SummerPractice2026Blazor.Validation
{
  public class ArticleCategoryValidator : AbstractValidator<ArticleCategory>
  {
    public ArticleCategoryValidator()
    {
      RuleFor(x => x.Name)
        .NotEmpty().WithMessage("Name is required.")
        .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");
    }
  }
}
