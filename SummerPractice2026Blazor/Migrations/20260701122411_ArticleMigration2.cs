using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SummerPractice2026Blazor.Migrations
{
  /// <inheritdoc />
  public partial class ArticleMigration2 : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Articles",
          columns: table => new
          {
            Id = table.Column<Guid>(type: "TEXT", nullable: false),
            Name = table.Column<string>(type: "TEXT", nullable: false),
            Price = table.Column<decimal>(type: "TEXT", nullable: false),
            Description = table.Column<string>(type: "TEXT", nullable: true),
            SpecialTag = table.Column<string>(type: "TEXT", nullable: true),
            ArticleCategoryId = table.Column<Guid>(type: "TEXT", nullable: false),
            ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Articles", x => x.Id);
            table.ForeignKey(
                      name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                      column: x => x.ArticleCategoryId,
                      principalTable: "ArticleCategories",
                      principalColumn: "Id",
                      onDelete: ReferentialAction.Cascade);
          });

      migrationBuilder.CreateIndex(
          name: "IX_Articles_ArticleCategoryId",
          table: "Articles",
          column: "ArticleCategoryId");

      InitialDataGenerator.AddInitialData(ref migrationBuilder);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Articles");
    }
  }
}
