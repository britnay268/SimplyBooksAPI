using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplyBooksAPI.Migrations
{
    public partial class UpdatedDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("129501b6-ad29-4496-a581-67345736779b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f4849c2-7408-4e19-9a85-5184a6ac4550"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f6f2d92-dfc8-43f0-9a34-2011df16a53b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6f0d168a-ea8f-4c78-a175-2b72963f2fe6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("837faac0-fb17-449f-849f-5958e4b54292"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a040a4f2-b2f3-4161-a2ae-795b54dbdc36"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bd9284c2-41db-4aee-8664-0be8c37f2557"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c4c45cf2-3cba-4951-af52-a5bc98a9f7cd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ff1c5128-d757-4b25-b5dd-fdfcfa821192"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Image", "Price", "Sale", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("026fb7d0-2909-42df-bf94-214dca8ec7d9"), 6, "", "https://res.cloudinary.com/bloomsbury-atlas/image/upload/w_360,c_scale/jackets/9781526622402.jpg", "12.99", true, "Hood Feminism", 1 },
                    { new Guid("095fee65-941e-4a7f-b1a7-ce95e5998448"), 1, "", "https://images-na.ssl-images-amazon.com/images/I/A1agLFsWkOL.jpg", "12.99", true, "Children of Blood and Bone", 1 },
                    { new Guid("1484266d-8621-409b-a0e4-1405e90aa7bc"), 5, "", "https://images-na.ssl-images-amazon.com/images/I/A1Cu4ywUeyL.jpg", "25.00", true, "The Underground Railroad", 1 },
                    { new Guid("41b1b757-1132-47e5-aa45-52d9dece8332"), 8, "", "https://images-na.ssl-images-amazon.com/images/I/61GSqXVhhKL.jpg", "12.00", false, "The Fire Next Time", 1 },
                    { new Guid("45d6b609-9cb6-42e1-bb9d-1a1c23aa124b"), 7, "", "https://images-na.ssl-images-amazon.com/images/I/81Uf1dTjfQL.jpg", "15.00", false, "A Blade So Black", 1 },
                    { new Guid("baafd719-670f-447d-80e4-1d9714073ebd"), 3, "", "https://images-na.ssl-images-amazon.com/images/I/51529Lfc2ML.jpg", "30.00", false, "A People's History of the United States of America", 1 },
                    { new Guid("c05f210d-f870-4c89-84cf-17cd117689a9"), 7, "", "https://m.media-amazon.com/images/I/51BZdlchEsL.jpg", "14.99", false, "A Dream So Dark", 1 },
                    { new Guid("c57bc1e8-cc64-4784-8a9b-fa2b7277fa5f"), 4, "", "https://images-na.ssl-images-amazon.com/images/I/81rRRmZZvZL.jpg", "15.89", false, "Concrete Rose", 1 },
                    { new Guid("ef99feb2-485f-4a6c-bd12-b5598ea640aa"), 2, "", "https://images-na.ssl-images-amazon.com/images/I/91+NBrXG-PL.jpg", "24.99", false, "A Promised Land", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("026fb7d0-2909-42df-bf94-214dca8ec7d9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("095fee65-941e-4a7f-b1a7-ce95e5998448"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1484266d-8621-409b-a0e4-1405e90aa7bc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("41b1b757-1132-47e5-aa45-52d9dece8332"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("45d6b609-9cb6-42e1-bb9d-1a1c23aa124b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("baafd719-670f-447d-80e4-1d9714073ebd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c05f210d-f870-4c89-84cf-17cd117689a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c57bc1e8-cc64-4784-8a9b-fa2b7277fa5f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ef99feb2-485f-4a6c-bd12-b5598ea640aa"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Image", "Price", "Sale", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("129501b6-ad29-4496-a581-67345736779b"), 6, "", "https://res.cloudinary.com/bloomsbury-atlas/image/upload/w_360,c_scale/jackets/9781526622402.jpg", "12.99", true, "Hood Feminism", 1 },
                    { new Guid("2f4849c2-7408-4e19-9a85-5184a6ac4550"), 2, "", "https://images-na.ssl-images-amazon.com/images/I/91+NBrXG-PL.jpg", "24.99", false, "A Promised Land", 1 },
                    { new Guid("2f6f2d92-dfc8-43f0-9a34-2011df16a53b"), 8, "", "https://images-na.ssl-images-amazon.com/images/I/61GSqXVhhKL.jpg", "12.00", false, "The Fire Next Time", 1 },
                    { new Guid("6f0d168a-ea8f-4c78-a175-2b72963f2fe6"), 7, "", "https://images-na.ssl-images-amazon.com/images/I/81Uf1dTjfQL.jpg", "15.00", false, "A Blade So Black", 1 },
                    { new Guid("837faac0-fb17-449f-849f-5958e4b54292"), 7, "", "https://m.media-amazon.com/images/I/51BZdlchEsL.jpg", "14.99", false, "A Dream So Dark", 1 },
                    { new Guid("a040a4f2-b2f3-4161-a2ae-795b54dbdc36"), 5, "", "https://images-na.ssl-images-amazon.com/images/I/A1Cu4ywUeyL.jpg", "25.00", true, "The Underground Railroad", 1 },
                    { new Guid("bd9284c2-41db-4aee-8664-0be8c37f2557"), 3, "", "https://images-na.ssl-images-amazon.com/images/I/51529Lfc2ML.jpg", "30.00", false, "A People's History of the United States of America", 1 },
                    { new Guid("c4c45cf2-3cba-4951-af52-a5bc98a9f7cd"), 4, "", "https://images-na.ssl-images-amazon.com/images/I/81rRRmZZvZL.jpg", "15.89", false, "Concrete Rose", 1 },
                    { new Guid("ff1c5128-d757-4b25-b5dd-fdfcfa821192"), 1, "", "https://images-na.ssl-images-amazon.com/images/I/A1agLFsWkOL.jpg", "12.99", true, "Children of Blood and Bone", 1 }
                });
        }
    }
}
