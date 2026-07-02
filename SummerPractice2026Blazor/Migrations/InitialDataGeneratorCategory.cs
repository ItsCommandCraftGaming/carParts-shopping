using Microsoft.EntityFrameworkCore.Migrations;

namespace SummerPractice2026Blazor.Migrations
{
  public class InitialDataGeneratorCategory
  {
    internal static void AddInitialData(ref MigrationBuilder migrationBuilder)
    {
      migrationBuilder.InsertData(
        table: "ArticleCategories",
        columns: new[] { "Id", "Name" },
        values: new object[,]
        {
          { new Guid("7e5f5f7f-c9d2-4c5c-a3e1-3384be8fabf8"), "Engine" },
          { new Guid("81d67dc2-0d81-4406-b5fb-7a2d434da254"), "Braking System" },
          { new Guid("fd0074cf-cdc8-45b8-a9e4-1d18ddf12bde"), "Suspension and Steering" },
          { new Guid("a37484b6-272b-4a6a-8dd0-1e9a20636f1f"), "Electrical System" }
        });
    }
  }
}
