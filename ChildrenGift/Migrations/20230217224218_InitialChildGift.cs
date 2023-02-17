﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildrenGift.Migrations
{
    public partial class InitialChildGift : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gifts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GiftId = table.Column<int>(nullable: false),
                    ChildId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gifts_Children_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Children",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Carrie", "Schaefer" },
                    { 73, "Zackery", "Lockman" },
                    { 72, "Harley", "Weissnat" },
                    { 71, "Harrison", "Bergnaum" },
                    { 70, "Alexzander", "Mertz" },
                    { 69, "Edwina", "Lind" },
                    { 68, "Beaulah", "Mraz" },
                    { 67, "Rowena", "Towne" },
                    { 66, "Faustino", "Macejkovic" },
                    { 65, "Noe", "Hyatt" },
                    { 64, "Johathan", "Fadel" },
                    { 63, "Vivian", "Sipes" },
                    { 62, "Adonis", "Cartwright" },
                    { 61, "Carmen", "Sauer" },
                    { 60, "Bonita", "Schuster" },
                    { 59, "Marcelina", "Schiller" },
                    { 58, "Larue", "Abernathy" },
                    { 57, "Maurice", "Lindgren" },
                    { 56, "Lue", "Schowalter" },
                    { 55, "Karson", "Dickens" },
                    { 54, "Taylor", "Morissette" },
                    { 53, "Susana", "Lueilwitz" },
                    { 74, "Emil", "Bernhard" },
                    { 75, "Keon", "Kuhic" },
                    { 76, "Carson", "Nitzsche" },
                    { 77, "Madonna", "Keeling" },
                    { 100, "Nils", "Stark" },
                    { 99, "Mittie", "Purdy" },
                    { 98, "Richie", "Howell" },
                    { 97, "Matteo", "Brakus" },
                    { 96, "Reyes", "Bartell" },
                    { 95, "Jillian", "Simonis" },
                    { 94, "Janae", "Willms" },
                    { 93, "Lucie", "Bechtelar" },
                    { 92, "Adrian", "Moen" },
                    { 91, "Marisol", "Doyle" },
                    { 52, "Cortez", "Johnston" },
                    { 90, "Mckayla", "Parisian" },
                    { 88, "Merlin", "Batz" },
                    { 87, "Rita", "Hammes" },
                    { 86, "Brad", "Kerluke" },
                    { 85, "Kathlyn", "Abernathy" },
                    { 84, "Adrienne", "Haley" },
                    { 83, "Laurence", "Schoen" },
                    { 82, "Amira", "O'Keefe" },
                    { 80, "Layne", "Donnelly" },
                    { 79, "Adrain", "Huel" },
                    { 78, "Napoleon", "Marquardt" },
                    { 89, "Tate", "Metz" },
                    { 51, "Tremaine", "Zemlak" },
                    { 81, "Theodora", "Hansen" },
                    { 49, "Jaida", "Bergnaum" },
                    { 22, "Bryana", "Cassin" },
                    { 21, "Terry", "Johnson" },
                    { 20, "Princess", "Koepp" },
                    { 19, "Gunner", "Olson" },
                    { 18, "Bertha", "Konopelski" },
                    { 17, "Kaycee", "Larson" },
                    { 16, "Walter", "Walsh" },
                    { 15, "Ebba", "Heidenreich" },
                    { 14, "Daija", "Schuppe" },
                    { 13, "Etha", "Sipes" },
                    { 11, "Dallas", "Morar" },
                    { 10, "Asa", "Fisher" },
                    { 9, "Esta", "Watsica" },
                    { 8, "Myriam", "Conroy" },
                    { 7, "Elisha", "Skiles" },
                    { 6, "Terrence", "Ratke" },
                    { 5, "Hannah", "Koch" },
                    { 4, "Holly", "Mohr" },
                    { 3, "Mary", "Schimmel" },
                    { 2, "Joelle", "Pouros" },
                    { 50, "Gregg", "Cronin" },
                    { 23, "Keyon", "Kohler" },
                    { 24, "Adella", "Kihn" },
                    { 12, "Ernest", "Mosciski" },
                    { 26, "Eugene", "Lang" },
                    { 48, "Oren", "Powlowski" },
                    { 25, "Patricia", "Satterfield" },
                    { 47, "Noemy", "Pfannerstill" },
                    { 46, "Velda", "Reichel" },
                    { 45, "Fidel", "Pollich" },
                    { 44, "Norberto", "O'Conner" },
                    { 43, "Karina", "Jones" },
                    { 41, "Francis", "Schmidt" },
                    { 40, "Randal", "Bechtelar" },
                    { 39, "Peter", "Fahey" },
                    { 38, "Chaz", "Metz" },
                    { 42, "Waino", "Gorczany" },
                    { 30, "Ellsworth", "Veum" },
                    { 28, "Elisa", "Leffler" },
                    { 37, "Alva", "Zulauf" },
                    { 29, "Dolores", "Mante" },
                    { 31, "Valentin", "Beahan" },
                    { 32, "Lillie", "McDermott" },
                    { 27, "Maiya", "Gleichner" },
                    { 33, "Chadrick", "Goldner" },
                    { 34, "Mckenzie", "Kuvalis" },
                    { 35, "Bryon", "Kshlerin" },
                    { 36, "Jany", "Morar" }
                });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "Id", "ChildId", "GiftId", "Name" },
                values: new object[,]
                {
                    { 165, null, 70, "alias" },
                    { 168, null, 87, "alias" },
                    { 167, null, 71, "alias" },
                    { 166, null, 33, "alias" },
                    { 169, null, 34, "alias" },
                    { 160, null, 17, "alias" },
                    { 161, null, 72, "alias" },
                    { 163, null, 49, "alias" },
                    { 162, null, 68, "alias" },
                    { 159, null, 62, "alias" },
                    { 170, null, 55, "alias" },
                    { 164, null, 79, "alias" },
                    { 171, null, 12, "alias" },
                    { 182, null, 1, "alias" },
                    { 173, null, 18, "alias" },
                    { 174, null, 84, "alias" },
                    { 175, null, 42, "alias" },
                    { 176, null, 11, "alias" },
                    { 177, null, 63, "alias" },
                    { 178, null, 90, "alias" },
                    { 179, null, 68, "alias" },
                    { 180, null, 23, "alias" },
                    { 181, null, 94, "alias" },
                    { 183, null, 49, "alias" },
                    { 184, null, 41, "alias" },
                    { 158, null, 45, "alias" },
                    { 185, null, 45, "alias" },
                    { 172, null, 88, "alias" },
                    { 157, null, 22, "alias" },
                    { 132, null, 17, "alias" },
                    { 155, null, 8, "alias" },
                    { 186, null, 8, "alias" },
                    { 127, null, 13, "alias" },
                    { 128, null, 71, "alias" },
                    { 129, null, 41, "alias" },
                    { 130, null, 59, "alias" },
                    { 131, null, 80, "alias" },
                    { 133, null, 93, "alias" },
                    { 134, null, 58, "alias" },
                    { 135, null, 92, "alias" },
                    { 136, null, 42, "alias" },
                    { 137, null, 78, "alias" },
                    { 138, null, 29, "alias" },
                    { 139, null, 47, "alias" },
                    { 156, null, 97, "alias" },
                    { 140, null, 50, "alias" },
                    { 142, null, 48, "alias" },
                    { 143, null, 90, "alias" },
                    { 144, null, 41, "alias" },
                    { 145, null, 32, "alias" },
                    { 146, null, 11, "alias" },
                    { 147, null, 21, "alias" },
                    { 148, null, 12, "alias" },
                    { 149, null, 22, "alias" },
                    { 150, null, 1, "alias" },
                    { 151, null, 15, "alias" },
                    { 152, null, 73, "alias" },
                    { 153, null, 76, "alias" },
                    { 154, null, 47, "alias" },
                    { 141, null, 43, "alias" },
                    { 187, null, 40, "alias" },
                    { 237, null, 23, "alias" },
                    { 189, null, 51, "alias" },
                    { 222, null, 25, "alias" },
                    { 223, null, 37, "alias" },
                    { 224, null, 39, "alias" },
                    { 225, null, 34, "alias" },
                    { 226, null, 77, "alias" },
                    { 227, null, 22, "alias" },
                    { 228, null, 87, "alias" },
                    { 229, null, 7, "alias" },
                    { 230, null, 67, "alias" },
                    { 231, null, 12, "alias" },
                    { 232, null, 52, "alias" },
                    { 233, null, 20, "alias" },
                    { 234, null, 69, "alias" },
                    { 235, null, 83, "alias" },
                    { 236, null, 61, "alias" },
                    { 126, null, 15, "alias" },
                    { 238, null, 81, "alias" },
                    { 239, null, 52, "alias" },
                    { 240, null, 19, "alias" },
                    { 241, null, 51, "alias" },
                    { 242, null, 49, "alias" },
                    { 243, null, 42, "alias" },
                    { 244, null, 53, "alias" },
                    { 245, null, 60, "alias" },
                    { 246, null, 89, "alias" },
                    { 247, null, 58, "alias" },
                    { 248, null, 28, "alias" },
                    { 221, null, 93, "alias" },
                    { 220, null, 63, "alias" },
                    { 219, null, 35, "alias" },
                    { 218, null, 8, "alias" },
                    { 190, null, 94, "alias" },
                    { 191, null, 21, "alias" },
                    { 192, null, 34, "alias" },
                    { 193, null, 67, "alias" },
                    { 194, null, 30, "alias" },
                    { 195, null, 78, "alias" },
                    { 196, null, 74, "alias" },
                    { 197, null, 98, "alias" },
                    { 198, null, 12, "alias" },
                    { 199, null, 71, "alias" },
                    { 200, null, 98, "alias" },
                    { 201, null, 39, "alias" },
                    { 202, null, 33, "alias" },
                    { 188, null, 47, "alias" },
                    { 203, null, 78, "alias" },
                    { 205, null, 88, "alias" },
                    { 206, null, 26, "alias" },
                    { 207, null, 56, "alias" },
                    { 208, null, 91, "alias" },
                    { 209, null, 5, "alias" },
                    { 210, null, 97, "alias" },
                    { 211, null, 35, "alias" },
                    { 212, null, 31, "alias" },
                    { 213, null, 76, "alias" },
                    { 214, null, 39, "alias" },
                    { 215, null, 23, "alias" },
                    { 216, null, 71, "alias" },
                    { 217, null, 20, "alias" },
                    { 204, null, 67, "alias" },
                    { 125, null, 33, "alias" },
                    { 75, null, 90, "alias" },
                    { 123, null, 32, "alias" },
                    { 33, null, 58, "alias" },
                    { 34, null, 60, "alias" },
                    { 35, null, 58, "alias" },
                    { 36, null, 63, "alias" },
                    { 37, null, 36, "alias" },
                    { 38, null, 8, "alias" },
                    { 39, null, 11, "alias" },
                    { 40, null, 3, "alias" },
                    { 41, null, 73, "alias" },
                    { 42, null, 82, "alias" },
                    { 43, null, 78, "alias" },
                    { 44, null, 98, "alias" },
                    { 45, null, 60, "alias" },
                    { 46, null, 35, "alias" },
                    { 47, null, 76, "alias" },
                    { 48, null, 26, "alias" },
                    { 49, null, 3, "alias" },
                    { 50, null, 14, "alias" },
                    { 51, null, 34, "alias" },
                    { 52, null, 29, "alias" },
                    { 53, null, 22, "alias" },
                    { 54, null, 29, "alias" },
                    { 55, null, 68, "alias" },
                    { 56, null, 76, "alias" },
                    { 57, null, 88, "alias" },
                    { 58, null, 69, "alias" },
                    { 59, null, 70, "alias" },
                    { 32, null, 59, "alias" },
                    { 31, null, 12, "alias" },
                    { 30, null, 68, "alias" },
                    { 29, null, 93, "alias" },
                    { 1, null, 81, "alias" },
                    { 2, null, 12, "alias" },
                    { 3, null, 53, "alias" },
                    { 4, null, 49, "alias" },
                    { 5, null, 64, "alias" },
                    { 6, null, 62, "alias" },
                    { 7, null, 68, "alias" },
                    { 8, null, 37, "alias" },
                    { 9, null, 37, "alias" },
                    { 10, null, 78, "alias" },
                    { 11, null, 54, "alias" },
                    { 12, null, 42, "alias" },
                    { 13, null, 83, "alias" },
                    { 60, null, 91, "alias" },
                    { 14, null, 40, "alias" },
                    { 16, null, 18, "alias" },
                    { 17, null, 58, "alias" },
                    { 18, null, 1, "alias" },
                    { 19, null, 34, "alias" },
                    { 20, null, 64, "alias" },
                    { 21, null, 1, "alias" },
                    { 22, null, 6, "alias" },
                    { 23, null, 23, "alias" },
                    { 24, null, 84, "alias" },
                    { 25, null, 79, "alias" },
                    { 26, null, 72, "alias" },
                    { 27, null, 49, "alias" },
                    { 28, null, 27, "alias" },
                    { 15, null, 71, "alias" },
                    { 124, null, 1, "alias" },
                    { 61, null, 13, "alias" },
                    { 63, null, 44, "alias" },
                    { 96, null, 32, "alias" },
                    { 97, null, 38, "alias" },
                    { 98, null, 11, "alias" },
                    { 99, null, 31, "alias" },
                    { 100, null, 65, "alias" },
                    { 101, null, 52, "alias" },
                    { 102, null, 53, "alias" },
                    { 103, null, 45, "alias" },
                    { 104, null, 95, "alias" },
                    { 105, null, 32, "alias" },
                    { 106, null, 84, "alias" },
                    { 107, null, 39, "alias" },
                    { 108, null, 90, "alias" },
                    { 109, null, 39, "alias" },
                    { 110, null, 50, "alias" },
                    { 111, null, 50, "alias" },
                    { 112, null, 64, "alias" },
                    { 113, null, 46, "alias" },
                    { 114, null, 26, "alias" },
                    { 115, null, 96, "alias" },
                    { 116, null, 89, "alias" },
                    { 117, null, 18, "alias" },
                    { 118, null, 65, "alias" },
                    { 119, null, 35, "alias" },
                    { 120, null, 84, "alias" },
                    { 121, null, 58, "alias" },
                    { 122, null, 54, "alias" },
                    { 95, null, 89, "alias" },
                    { 94, null, 19, "alias" },
                    { 93, null, 38, "alias" },
                    { 92, null, 66, "alias" },
                    { 64, null, 68, "alias" },
                    { 65, null, 67, "alias" },
                    { 66, null, 95, "alias" },
                    { 67, null, 83, "alias" },
                    { 68, null, 23, "alias" },
                    { 69, null, 81, "alias" },
                    { 70, null, 8, "alias" },
                    { 71, null, 81, "alias" },
                    { 72, null, 50, "alias" },
                    { 73, null, 89, "alias" },
                    { 74, null, 31, "alias" },
                    { 249, null, 8, "alias" },
                    { 76, null, 19, "alias" },
                    { 62, null, 41, "alias" },
                    { 77, null, 27, "alias" },
                    { 79, null, 24, "alias" },
                    { 80, null, 44, "alias" },
                    { 81, null, 95, "alias" },
                    { 82, null, 23, "alias" },
                    { 83, null, 24, "alias" },
                    { 84, null, 79, "alias" },
                    { 85, null, 34, "alias" },
                    { 86, null, 82, "alias" },
                    { 87, null, 38, "alias" },
                    { 88, null, 29, "alias" },
                    { 89, null, 91, "alias" },
                    { 90, null, 81, "alias" },
                    { 91, null, 75, "alias" },
                    { 78, null, 25, "alias" },
                    { 250, null, 7, "alias" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gifts_ChildId",
                table: "Gifts",
                column: "ChildId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gifts");

            migrationBuilder.DropTable(
                name: "Children");
        }
    }
}
