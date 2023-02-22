using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceWebApiCase.Data.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_ProductCategories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatureType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatureType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryMainId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategoryTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategoryTranslations_ProductCategories_ProductCategoryMainId",
                        column: x => x.ProductCategoryMainId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductFeatureTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductFeatureType_ProductFeatureTypeId",
                        column: x => x.ProductFeatureTypeId,
                        principalTable: "ProductFeatureType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ProductMainId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Products_ProductMainId",
                        column: x => x.ProductMainId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatureProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductFeatureId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatureProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatureProducts_ProductFeatures_ProductFeatureId",
                        column: x => x.ProductFeatureId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatureProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "tr", new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1575), "Türkçe", true, "Türkçe", new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1572) },
                    { 2, "en", new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1577), "İngilizce", true, "İngilizce", new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1577) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedDate", "IsActive", "ParentCategoryId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1744), true, null, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1744) },
                    { 2, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1747), true, null, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1747) }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatureType",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2064), "Çoktan Seçmeli", true, "Lookup", new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2063) },
                    { 2, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2066), "Var veya Yok", true, "CheckBox", new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2066) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedDate", "IsActive", "ParentCategoryId", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1749), true, 1, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.InsertData(
                table: "ProductCategoryTranslations",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "LanguageId", "Name", "ProductCategoryMainId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1809), "Elektronik ürünler bu kategoride bulunmaktadır", true, 1, "Elektronik", 1, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1810) },
                    { 2, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1811), "Electronic products are in this category", true, 2, "Electronics", 1, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1812) },
                    { 3, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1813), "Tabletler bu kategoride bulunmaktadır", true, 1, "Tabletler", 3, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1814) },
                    { 4, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1822), "Tablets are in this category", true, 2, "Tablets", 3, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1823) }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsActive", "Name", "ProductFeatureTypeId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2008), "Ekran Boyutu (İnç Cinsinden)", true, "Ekran Boyutu", 1, null },
                    { 2, 3, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2010), "İşlemci Hızı", true, "İşlemci Hızı", 1, null },
                    { 3, 3, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2011), "Renk", true, "Renk", 1, null },
                    { 4, 3, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2013), "Pil Kapasitesi", true, "Pil Kapasitesi", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImageUrl", "IsActive", "Price", "UpdatedDate" },
                values: new object[] { 1, 3, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1886), "img/product/product.jpg", true, 500m, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.InsertData(
                table: "ProductFeatureProducts",
                columns: new[] { "Id", "CreatedDate", "IsActive", "ProductFeatureId", "ProductId", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2133), true, 1, 1, null, "7 inç" },
                    { 2, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2135), true, 1, 1, null, "8 inç" },
                    { 3, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2136), true, 1, 1, null, "10 inç" },
                    { 4, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2138), true, 3, 1, null, "Siyah" },
                    { 5, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2139), true, 3, 1, null, "Beyaz" },
                    { 6, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(2141), true, 3, 1, null, "Gümüş" }
                });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "LanguageId", "Name", "ProductMainId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1945), "Samsung Tablet 16 Gb ......", true, 1, "Samsung Tablet", 1, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1946) },
                    { 2, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1948), "Eng Samsung Tablet 16 Gb ......", true, 2, "Samsung Tablet Eng", 1, new DateTime(2023, 2, 22, 5, 5, 28, 320, DateTimeKind.Local).AddTicks(1948) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ParentCategoryId",
                table: "ProductCategories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryTranslations_LanguageId",
                table: "ProductCategoryTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryTranslations_ProductCategoryMainId",
                table: "ProductCategoryTranslations",
                column: "ProductCategoryMainId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatureProducts_ProductFeatureId",
                table: "ProductFeatureProducts",
                column: "ProductFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatureProducts_ProductId",
                table: "ProductFeatureProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_CategoryId",
                table: "ProductFeatures",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductFeatureTypeId",
                table: "ProductFeatures",
                column: "ProductFeatureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_ProductMainId",
                table: "ProductTranslations",
                column: "ProductMainId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategoryTranslations");

            migrationBuilder.DropTable(
                name: "ProductFeatureProducts");

            migrationBuilder.DropTable(
                name: "ProductTranslations");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductFeatureType");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
