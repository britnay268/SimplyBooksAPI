using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplyBooksAPI.Migrations
{
    public partial class UpdatedAuthorBooksThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBooks_Users_UserId",
                table: "AuthorBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorBooks",
                table: "AuthorBooks");

            migrationBuilder.DropIndex(
                name: "IX_AuthorBooks_AuthorId",
                table: "AuthorBooks");

            migrationBuilder.DropIndex(
                name: "IX_AuthorBooks_UserId",
                table: "AuthorBooks");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0dec23d8-8958-48b2-aedd-7690cc897979"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0fef7b10-6617-4b45-9b7c-7d7454ea89cb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("34a36b62-09f9-4c34-93b7-cd13035c44ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("479b94af-459d-43c0-b818-e4cac10930eb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("681ed2ab-e32f-4b4d-95be-f0d7cd75663a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c3c4e3b8-03ed-420a-a955-ad406bcaf0fb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c75df1f4-c673-48fd-aa79-c4ed92daa4e6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d16f173e-0417-47d7-87fe-1de2c85c7877"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f7af3ab9-2573-4ea5-8e33-baa4556de0cc"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AuthorBooks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AuthorBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorBooks",
                table: "AuthorBooks",
                columns: new[] { "AuthorId", "BookId" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Image", "Price", "Sale", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("0138188e-86d4-440b-8bec-6497d28ed108"), 7, "", "https://m.media-amazon.com/images/I/51BZdlchEsL.jpg", "14.99", false, "A Dream So Dark", 1 },
                    { new Guid("02a5c0e8-54ed-4aee-b639-2163d011a7e6"), 5, "", "https://images-na.ssl-images-amazon.com/images/I/A1Cu4ywUeyL.jpg", "25.00", true, "The Underground Railroad", 1 },
                    { new Guid("06acaeaf-8949-43f3-8508-0dee86455182"), 6, "", "https://res.cloudinary.com/bloomsbury-atlas/image/upload/w_360,c_scale/jackets/9781526622402.jpg", "12.99", true, "Hood Feminism", 1 },
                    { new Guid("08b6c6ea-105f-40be-b928-d26c7b4af841"), 3, "", "https://images-na.ssl-images-amazon.com/images/I/51529Lfc2ML.jpg", "30.00", false, "A People's History of the United States of America", 1 },
                    { new Guid("5266793f-b30e-4728-9fac-44ab14e18760"), 2, "", "https://images-na.ssl-images-amazon.com/images/I/91+NBrXG-PL.jpg", "24.99", false, "A Promised Land", 1 },
                    { new Guid("63df79a8-f99e-4e90-b3d3-1cf0c03e70b7"), 7, "", "https://images-na.ssl-images-amazon.com/images/I/81Uf1dTjfQL.jpg", "15.00", false, "A Blade So Black", 1 },
                    { new Guid("c8520aa8-27df-49d1-9bd8-d4c2f5102c5f"), 8, "", "https://images-na.ssl-images-amazon.com/images/I/61GSqXVhhKL.jpg", "12.00", false, "The Fire Next Time", 1 },
                    { new Guid("d0ad06b3-d2c3-4aee-9c66-eacc5667e64c"), 1, "", "https://images-na.ssl-images-amazon.com/images/I/A1agLFsWkOL.jpg", "12.99", true, "Children of Blood and Bone", 1 },
                    { new Guid("ff318bb1-d560-43e0-857f-97f97188991b"), 4, "", "https://images-na.ssl-images-amazon.com/images/I/81rRRmZZvZL.jpg", "15.89", false, "Concrete Rose", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorBooks",
                table: "AuthorBooks");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0138188e-86d4-440b-8bec-6497d28ed108"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("02a5c0e8-54ed-4aee-b639-2163d011a7e6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("06acaeaf-8949-43f3-8508-0dee86455182"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("08b6c6ea-105f-40be-b928-d26c7b4af841"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5266793f-b30e-4728-9fac-44ab14e18760"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("63df79a8-f99e-4e90-b3d3-1cf0c03e70b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c8520aa8-27df-49d1-9bd8-d4c2f5102c5f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d0ad06b3-d2c3-4aee-9c66-eacc5667e64c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ff318bb1-d560-43e0-857f-97f97188991b"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "AuthorBooks",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AuthorBooks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorBooks",
                table: "AuthorBooks",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Image", "Price", "Sale", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dec23d8-8958-48b2-aedd-7690cc897979"), 2, "", "https://images-na.ssl-images-amazon.com/images/I/91+NBrXG-PL.jpg", "24.99", false, "A Promised Land", 1 },
                    { new Guid("0fef7b10-6617-4b45-9b7c-7d7454ea89cb"), 6, "", "https://res.cloudinary.com/bloomsbury-atlas/image/upload/w_360,c_scale/jackets/9781526622402.jpg", "12.99", true, "Hood Feminism", 1 },
                    { new Guid("34a36b62-09f9-4c34-93b7-cd13035c44ef"), 7, "", "https://m.media-amazon.com/images/I/51BZdlchEsL.jpg", "14.99", false, "A Dream So Dark", 1 },
                    { new Guid("479b94af-459d-43c0-b818-e4cac10930eb"), 4, "", "https://images-na.ssl-images-amazon.com/images/I/81rRRmZZvZL.jpg", "15.89", false, "Concrete Rose", 1 },
                    { new Guid("681ed2ab-e32f-4b4d-95be-f0d7cd75663a"), 3, "", "https://images-na.ssl-images-amazon.com/images/I/51529Lfc2ML.jpg", "30.00", false, "A People's History of the United States of America", 1 },
                    { new Guid("c3c4e3b8-03ed-420a-a955-ad406bcaf0fb"), 7, "", "https://images-na.ssl-images-amazon.com/images/I/81Uf1dTjfQL.jpg", "15.00", false, "A Blade So Black", 1 },
                    { new Guid("c75df1f4-c673-48fd-aa79-c4ed92daa4e6"), 8, "", "https://images-na.ssl-images-amazon.com/images/I/61GSqXVhhKL.jpg", "12.00", false, "The Fire Next Time", 1 },
                    { new Guid("d16f173e-0417-47d7-87fe-1de2c85c7877"), 5, "", "https://images-na.ssl-images-amazon.com/images/I/A1Cu4ywUeyL.jpg", "25.00", true, "The Underground Railroad", 1 },
                    { new Guid("f7af3ab9-2573-4ea5-8e33-baa4556de0cc"), 1, "", "https://images-na.ssl-images-amazon.com/images/I/A1agLFsWkOL.jpg", "12.99", true, "Children of Blood and Bone", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBooks_AuthorId",
                table: "AuthorBooks",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBooks_UserId",
                table: "AuthorBooks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBooks_Users_UserId",
                table: "AuthorBooks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
