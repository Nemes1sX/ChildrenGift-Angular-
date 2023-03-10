using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildrenGift.Migrations
{
    public partial class InitialCreate : Migration
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
                    ChildId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gifts_Children_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Children",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Juvenal", "Ferry" },
                    { 73, "Boyd", "Schuster" },
                    { 72, "Lucie", "Hahn" },
                    { 71, "Isabel", "Trantow" },
                    { 70, "Kari", "Casper" },
                    { 69, "Linnea", "Heller" },
                    { 68, "Rahsaan", "Mitchell" },
                    { 67, "Antonio", "Durgan" },
                    { 66, "Conner", "Kessler" },
                    { 65, "Lea", "Bins" },
                    { 64, "Roselyn", "Moen" },
                    { 63, "Tressie", "Bailey" },
                    { 62, "Katelin", "Hickle" },
                    { 61, "Letha", "Macejkovic" },
                    { 60, "Roberta", "Howe" },
                    { 59, "Nicolas", "Jenkins" },
                    { 58, "Maxie", "Grady" },
                    { 57, "Glen", "Kirlin" },
                    { 56, "Otha", "Wilderman" },
                    { 55, "Orlando", "Bins" },
                    { 54, "Larry", "Deckow" },
                    { 53, "Euna", "Eichmann" },
                    { 74, "Frida", "Robel" },
                    { 52, "Ramiro", "Wisoky" },
                    { 75, "Brenna", "Halvorson" },
                    { 77, "Liliane", "Quigley" },
                    { 98, "Nikolas", "Reichel" },
                    { 97, "Marge", "Hoppe" },
                    { 96, "Margarita", "Hammes" },
                    { 95, "Gunnar", "Miller" },
                    { 94, "Clementine", "Weber" },
                    { 93, "Hellen", "Goyette" },
                    { 92, "Jacey", "Goyette" },
                    { 91, "Cristobal", "Mann" },
                    { 90, "Rosie", "Baumbach" },
                    { 89, "Rosalinda", "Walker" },
                    { 88, "Selena", "Larson" },
                    { 87, "Deven", "Moen" },
                    { 86, "Cloyd", "Schimmel" },
                    { 85, "Jeffery", "Block" },
                    { 84, "Modesta", "Christiansen" },
                    { 83, "Felicity", "Larkin" },
                    { 82, "Keith", "Prosacco" },
                    { 81, "Stone", "Leuschke" },
                    { 80, "Mckenzie", "Bechtelar" },
                    { 79, "Chance", "Schmeler" },
                    { 78, "Ila", "Rowe" },
                    { 76, "Shaina", "Goldner" },
                    { 51, "Arely", "Stoltenberg" },
                    { 50, "Oren", "Reichel" },
                    { 49, "Clementina", "Casper" },
                    { 22, "Victor", "Walker" },
                    { 21, "Breana", "Walsh" },
                    { 20, "Adelle", "Volkman" },
                    { 19, "Kirsten", "Runolfsdottir" },
                    { 18, "Krista", "Heaney" },
                    { 17, "Rodger", "Mraz" },
                    { 16, "Ahmad", "Hodkiewicz" },
                    { 15, "Eleazar", "Reilly" },
                    { 14, "Kelsi", "Orn" },
                    { 13, "Clair", "Hamill" },
                    { 12, "Stefanie", "Connelly" },
                    { 11, "Max", "Leannon" },
                    { 10, "Leif", "Kuphal" },
                    { 9, "Domenica", "Funk" },
                    { 8, "Milan", "Yundt" },
                    { 7, "Gaetano", "Hills" },
                    { 6, "Anibal", "Hane" },
                    { 5, "Astrid", "Walsh" },
                    { 4, "Ronaldo", "Grimes" },
                    { 3, "Broderick", "Huels" },
                    { 2, "Celestine", "Dooley" },
                    { 23, "Makenzie", "Dickens" },
                    { 24, "Sophie", "Wunsch" },
                    { 25, "Devante", "Reichel" },
                    { 26, "Jamil", "Barton" },
                    { 48, "Delaney", "Dietrich" },
                    { 47, "Martina", "Satterfield" },
                    { 46, "Burnice", "Kohler" },
                    { 45, "Jacklyn", "Legros" },
                    { 44, "Torey", "Shanahan" },
                    { 43, "Anabel", "Barton" },
                    { 42, "Tobin", "Morar" },
                    { 41, "Herminia", "Wolf" },
                    { 40, "Beau", "Simonis" },
                    { 39, "Lue", "Walter" },
                    { 99, "Benton", "Parker" },
                    { 38, "Destiny", "Jerde" },
                    { 36, "Aniyah", "Lesch" },
                    { 35, "Dennis", "Jaskolski" },
                    { 34, "Zakary", "Effertz" },
                    { 33, "Bobbie", "McKenzie" },
                    { 32, "Devan", "Wilderman" },
                    { 31, "Naomi", "Mosciski" },
                    { 30, "Claud", "Runolfsson" },
                    { 29, "Agustina", "O'Kon" },
                    { 28, "Geraldine", "Corkery" },
                    { 27, "Isabel", "Kilback" },
                    { 37, "Calista", "Flatley" },
                    { 100, "Leland", "Watsica" }
                });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "Id", "ChildId", "Name" },
                values: new object[,]
                {
                    { 57, 1, "alias" },
                    { 166, 63, "alias" },
                    { 207, 63, "alias" },
                    { 173, 64, "alias" },
                    { 174, 64, "alias" },
                    { 175, 64, "alias" },
                    { 25, 65, "alias" },
                    { 84, 65, "alias" },
                    { 112, 65, "alias" },
                    { 129, 65, "alias" },
                    { 153, 66, "alias" },
                    { 225, 66, "alias" },
                    { 21, 67, "alias" },
                    { 9, 68, "alias" },
                    { 26, 68, "alias" },
                    { 106, 68, "alias" },
                    { 120, 68, "alias" },
                    { 124, 68, "alias" },
                    { 33, 69, "alias" },
                    { 60, 69, "alias" },
                    { 62, 69, "alias" },
                    { 215, 69, "alias" },
                    { 249, 69, "alias" },
                    { 23, 70, "alias" },
                    { 36, 70, "alias" },
                    { 91, 70, "alias" },
                    { 2, 71, "alias" },
                    { 105, 71, "alias" },
                    { 138, 63, "alias" },
                    { 205, 72, "alias" },
                    { 243, 61, "alias" },
                    { 39, 61, "alias" },
                    { 202, 47, "alias" },
                    { 203, 47, "alias" },
                    { 184, 48, "alias" },
                    { 186, 48, "alias" },
                    { 210, 48, "alias" },
                    { 123, 49, "alias" },
                    { 125, 49, "alias" },
                    { 108, 50, "alias" },
                    { 178, 50, "alias" },
                    { 201, 51, "alias" },
                    { 22, 52, "alias" },
                    { 248, 52, "alias" },
                    { 165, 53, "alias" },
                    { 128, 54, "alias" },
                    { 140, 54, "alias" },
                    { 167, 54, "alias" },
                    { 188, 54, "alias" },
                    { 197, 54, "alias" },
                    { 71, 55, "alias" },
                    { 81, 56, "alias" },
                    { 160, 56, "alias" },
                    { 234, 56, "alias" },
                    { 148, 57, "alias" },
                    { 154, 57, "alias" },
                    { 37, 58, "alias" },
                    { 118, 58, "alias" },
                    { 76, 59, "alias" },
                    { 101, 61, "alias" },
                    { 74, 74, "alias" },
                    { 100, 74, "alias" },
                    { 131, 74, "alias" },
                    { 13, 88, "alias" },
                    { 87, 88, "alias" },
                    { 93, 88, "alias" },
                    { 157, 88, "alias" },
                    { 14, 89, "alias" },
                    { 15, 89, "alias" },
                    { 41, 89, "alias" },
                    { 83, 89, "alias" },
                    { 189, 89, "alias" },
                    { 182, 90, "alias" },
                    { 246, 90, "alias" },
                    { 12, 91, "alias" },
                    { 29, 91, "alias" },
                    { 116, 91, "alias" },
                    { 223, 91, "alias" },
                    { 94, 92, "alias" },
                    { 164, 92, "alias" },
                    { 209, 92, "alias" },
                    { 235, 92, "alias" },
                    { 238, 92, "alias" },
                    { 103, 93, "alias" },
                    { 139, 93, "alias" },
                    { 45, 94, "alias" },
                    { 176, 94, "alias" },
                    { 213, 94, "alias" },
                    { 170, 95, "alias" },
                    { 20, 96, "alias" },
                    { 181, 87, "alias" },
                    { 130, 87, "alias" },
                    { 54, 87, "alias" },
                    { 221, 86, "alias" },
                    { 200, 74, "alias" },
                    { 242, 74, "alias" },
                    { 6, 75, "alias" },
                    { 68, 75, "alias" },
                    { 183, 75, "alias" },
                    { 187, 76, "alias" },
                    { 239, 76, "alias" },
                    { 35, 77, "alias" },
                    { 159, 77, "alias" },
                    { 149, 78, "alias" },
                    { 109, 79, "alias" },
                    { 4, 80, "alias" },
                    { 117, 80, "alias" },
                    { 185, 47, "alias" },
                    { 168, 81, "alias" },
                    { 80, 82, "alias" },
                    { 88, 82, "alias" },
                    { 204, 82, "alias" },
                    { 1, 84, "alias" },
                    { 52, 84, "alias" },
                    { 97, 84, "alias" },
                    { 98, 84, "alias" },
                    { 163, 84, "alias" },
                    { 211, 84, "alias" },
                    { 162, 85, "alias" },
                    { 193, 85, "alias" },
                    { 241, 85, "alias" },
                    { 55, 86, "alias" },
                    { 46, 82, "alias" },
                    { 127, 47, "alias" },
                    { 230, 46, "alias" },
                    { 199, 46, "alias" },
                    { 115, 14, "alias" },
                    { 8, 15, "alias" },
                    { 59, 15, "alias" },
                    { 126, 15, "alias" },
                    { 245, 16, "alias" },
                    { 172, 17, "alias" },
                    { 3, 18, "alias" },
                    { 58, 18, "alias" },
                    { 119, 18, "alias" },
                    { 150, 18, "alias" },
                    { 136, 19, "alias" },
                    { 196, 19, "alias" },
                    { 70, 20, "alias" },
                    { 96, 20, "alias" },
                    { 66, 21, "alias" },
                    { 67, 22, "alias" },
                    { 135, 22, "alias" },
                    { 156, 22, "alias" },
                    { 161, 22, "alias" },
                    { 192, 22, "alias" },
                    { 63, 23, "alias" },
                    { 85, 23, "alias" },
                    { 206, 23, "alias" },
                    { 53, 24, "alias" },
                    { 226, 24, "alias" },
                    { 240, 24, "alias" },
                    { 43, 25, "alias" },
                    { 34, 14, "alias" },
                    { 19, 14, "alias" },
                    { 16, 14, "alias" },
                    { 113, 13, "alias" },
                    { 190, 1, "alias" },
                    { 222, 1, "alias" },
                    { 250, 2, "alias" },
                    { 143, 3, "alias" },
                    { 208, 3, "alias" },
                    { 38, 4, "alias" },
                    { 141, 4, "alias" },
                    { 233, 4, "alias" },
                    { 7, 5, "alias" },
                    { 51, 5, "alias" },
                    { 79, 5, "alias" },
                    { 220, 5, "alias" },
                    { 48, 6, "alias" },
                    { 99, 25, "alias" },
                    { 146, 6, "alias" },
                    { 111, 7, "alias" },
                    { 42, 8, "alias" },
                    { 75, 8, "alias" },
                    { 95, 9, "alias" },
                    { 217, 10, "alias" },
                    { 224, 10, "alias" },
                    { 65, 11, "alias" },
                    { 133, 11, "alias" },
                    { 169, 11, "alias" },
                    { 198, 11, "alias" },
                    { 32, 13, "alias" },
                    { 47, 13, "alias" },
                    { 69, 13, "alias" },
                    { 18, 7, "alias" },
                    { 24, 99, "alias" },
                    { 158, 25, "alias" },
                    { 232, 26, "alias" },
                    { 145, 38, "alias" },
                    { 194, 38, "alias" },
                    { 40, 39, "alias" },
                    { 82, 39, "alias" },
                    { 107, 39, "alias" },
                    { 142, 39, "alias" },
                    { 212, 39, "alias" },
                    { 17, 40, "alias" },
                    { 92, 40, "alias" },
                    { 122, 40, "alias" },
                    { 151, 40, "alias" },
                    { 231, 40, "alias" },
                    { 64, 41, "alias" },
                    { 236, 41, "alias" },
                    { 155, 42, "alias" },
                    { 244, 42, "alias" },
                    { 86, 43, "alias" },
                    { 132, 43, "alias" },
                    { 90, 44, "alias" },
                    { 180, 44, "alias" },
                    { 237, 44, "alias" },
                    { 27, 45, "alias" },
                    { 171, 45, "alias" },
                    { 219, 45, "alias" },
                    { 49, 46, "alias" },
                    { 73, 46, "alias" },
                    { 137, 46, "alias" },
                    { 10, 38, "alias" },
                    { 5, 38, "alias" },
                    { 177, 37, "alias" },
                    { 102, 37, "alias" },
                    { 31, 27, "alias" },
                    { 50, 27, "alias" },
                    { 77, 27, "alias" },
                    { 89, 27, "alias" },
                    { 104, 27, "alias" },
                    { 152, 27, "alias" },
                    { 247, 27, "alias" },
                    { 30, 28, "alias" },
                    { 110, 28, "alias" },
                    { 147, 28, "alias" },
                    { 179, 30, "alias" },
                    { 191, 30, "alias" },
                    { 61, 31, "alias" },
                    { 228, 26, "alias" },
                    { 134, 31, "alias" },
                    { 229, 31, "alias" },
                    { 114, 32, "alias" },
                    { 227, 32, "alias" },
                    { 11, 33, "alias" },
                    { 56, 33, "alias" },
                    { 121, 33, "alias" },
                    { 195, 33, "alias" },
                    { 214, 34, "alias" },
                    { 28, 35, "alias" },
                    { 78, 35, "alias" },
                    { 44, 36, "alias" },
                    { 72, 36, "alias" },
                    { 218, 36, "alias" },
                    { 216, 31, "alias" },
                    { 144, 99, "alias" }
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
