using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SimplyBooksAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Favorite = table.Column<bool>(type: "boolean", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Sale = table.Column<bool>(type: "boolean", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Uid" },
                values: new object[] { 1, "britnaygore268@gmail.com", "Britnay Gore", "NdnbyDbtZTUYr9T0YH4YicxApXG2" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Favorite", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, "ta@ta.com", true, "Tomi", "Adeyemi", 1 },
                    { 2, "ba@obama.com", true, "Barack", "Obama", 1 },
                    { 3, "hz@zinn.com", false, "Howard", "Zinn", 1 },
                    { 4, "at@thomas.com", false, "Angie", "Thomas", 1 },
                    { 5, "cw@whithead.com", false, "Colson", "Whitehead", 1 },
                    { 6, "mk@kendall.com", true, "Mikki", "Kendall", 1 },
                    { 7, "lm@lm.com", true, "L.L", "McKinney", 1 },
                    { 8, "jb@baldwin.com", false, "James", "Baldwin", 1 }
                });

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
                name: "IX_AuthorBooks_BookId",
                table: "AuthorBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBooks_UserId",
                table: "AuthorBooks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_UserId",
                table: "Authors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
