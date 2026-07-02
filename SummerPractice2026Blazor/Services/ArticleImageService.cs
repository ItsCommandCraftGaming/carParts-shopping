using Microsoft.AspNetCore.Components.Forms;

namespace SummerPractice2026Blazor.Services
{
  public class ArticleImageService(IWebHostEnvironment environment)
  {
    private readonly string _articleImageFolderPath = Path.Combine(environment.WebRootPath, "images", "article");

    public async Task<string> SaveFileAsync(IBrowserFile file)
    {
      Directory.CreateDirectory(_articleImageFolderPath);

      var extension = Path.GetExtension(file.Name);
      var fileName = $"{Guid.NewGuid()}{extension}";
      var filePath = Path.Combine(_articleImageFolderPath, fileName);

      await using var fs = new FileStream(filePath, FileMode.Create);
      await file.OpenReadStream(1024 * 1024 * 10).CopyToAsync(fs);

      return $"images/article/{fileName}";
    }

    public void DeleteFile(string relativePath)
    {
      var normalizedPath = relativePath.Replace('/', Path.DirectorySeparatorChar);
      var fullPath = Path.Combine(environment.WebRootPath, normalizedPath);

      if (File.Exists(fullPath))
      {
        File.Delete(fullPath);
      }
    }
  }
}
