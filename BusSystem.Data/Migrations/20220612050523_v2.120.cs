using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class v2120 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,1)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    modified_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e97cf3f-9b3c-4559-9127-d63b8cd99c90", "AQAAAAEAACcQAAAAELE0y0XqUU8SqJj0kzFlP+rHF6rfr0+m97abWJzb46Bwiky5z3gjdLt6Xq7kDaCTgA==", "a8a431c9-fb1c-4dd7-bb70-86f92bbbf229" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "397 Tillman Rapids, Gaylordview, Iran", new DateTime(1986, 12, 5, 8, 18, 34, 267, DateTimeKind.Utc).AddTicks(5170), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Olen_Hansen@hotmail.com", "Cloyd Ward", "983-420-6070" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "92769 Kutch Place, West Jerrold, Isle of Man", new DateTime(1973, 7, 23, 7, 0, 32, 998, DateTimeKind.Utc).AddTicks(9122), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Colton2@yahoo.com", "Lamont Reinger", "539-913-4826" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "72716 Greta Squares, Bergstrommouth, Jersey", new DateTime(1955, 4, 16, 14, 3, 29, 920, DateTimeKind.Utc).AddTicks(5200), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Jeanette.Fay80@hotmail.com", "Manley Tromp", "626-463-2544" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "54049 Hazel Courts, Araceliborough, Chad", new DateTime(1963, 8, 11, 2, 34, 54, 766, DateTimeKind.Utc).AddTicks(1102), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Lavern84@yahoo.com", "Waino Fisher", "467-277-1402" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "436 Earl Knoll, West Glenna, Nigeria", new DateTime(1967, 10, 13, 16, 35, 9, 353, DateTimeKind.Utc).AddTicks(1753), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Emilia_Kunze93@gmail.com", "Maxine Denesik", "219-545-6734" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "93119 Crooks Mill, South Addie, Peru", new DateTime(1945, 8, 11, 9, 26, 33, 513, DateTimeKind.Utc).AddTicks(2297), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Jessica_Kihn@gmail.com", "Zackary Bayer", "467-478-7777" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "08525 Hortense Center, Coletown, Panama", new DateTime(1948, 7, 26, 20, 32, 5, 874, DateTimeKind.Utc).AddTicks(8287), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Katrina91@hotmail.com", "Aileen Douglas", "878-457-3626" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "50461 Nolan Locks, Lake Keeley, Lao People's Democratic Republic", new DateTime(1960, 3, 24, 1, 24, 22, 778, DateTimeKind.Utc).AddTicks(4910), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Verdie16@gmail.com", "Hassan Keeling", "641-254-8262" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1304 Robyn Prairie, Grantfurt, Sudan", new DateTime(1947, 5, 3, 13, 19, 26, 108, DateTimeKind.Utc).AddTicks(6101), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Beulah65@gmail.com", "Donna Nitzsche", "429-587-8207" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "294 Mueller Fields, Metzville, Palau", new DateTime(1958, 8, 9, 12, 49, 13, 473, DateTimeKind.Utc).AddTicks(4428), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Miracle.Haag@hotmail.com", "Pauline Rosenbaum", "745-391-8430" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "80308 Abshire Track, Lake Sashachester, Estonia", new DateTime(1970, 6, 2, 8, 29, 36, 640, DateTimeKind.Utc).AddTicks(2249), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Abdiel_Bergstrom@gmail.com", "Pauline Weber", "953-989-6779" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "98221 Wuckert Shores, Binsstad, Palau", new DateTime(1991, 6, 22, 19, 43, 43, 719, DateTimeKind.Utc).AddTicks(2091), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Esperanza_Grimes@hotmail.com", "Rubye Oberbrunner", "342-416-9946" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "53013 Hilario Islands, Lake Bert, Lesotho", new DateTime(1959, 1, 5, 15, 22, 9, 432, DateTimeKind.Utc).AddTicks(4810), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Marlen.Parker@gmail.com", "Destin Ward", "645-885-8099" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "757 Jacobi Ports, Hansenfort, Tunisia", new DateTime(1952, 9, 24, 16, 25, 44, 673, DateTimeKind.Utc).AddTicks(4491), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Cielo_Nader24@yahoo.com", "Polly Nikolaus", "873-347-4577" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7358 Ullrich Dam, New Kieranville, Barbados", new DateTime(1973, 8, 30, 2, 25, 48, 680, DateTimeKind.Utc).AddTicks(2551), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Danielle19@hotmail.com", "Easton Bogisich", "304-705-3622" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "70952 Huel Club, New Keon, Comoros", new DateTime(1992, 8, 25, 5, 38, 23, 824, DateTimeKind.Utc).AddTicks(4063), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Demond36@yahoo.com", "Ora Adams", "695-243-8637" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1643 Wintheiser Mill, New Stacy, Guam", new DateTime(1981, 1, 25, 13, 50, 12, 361, DateTimeKind.Utc).AddTicks(4309), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Simeon38@hotmail.com", "Eriberto O'Keefe", "544-953-0979" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "228 Grady Viaduct, North Romanshire, Cyprus", new DateTime(1977, 10, 22, 8, 35, 28, 264, DateTimeKind.Utc).AddTicks(6014), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Cecilia_Boyle@gmail.com", "Henriette MacGyver", "338-479-1364" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "619 Shanahan Vista, Bradyville, Egypt", new DateTime(1981, 8, 6, 4, 34, 47, 427, DateTimeKind.Utc).AddTicks(5147), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Hipolito27@gmail.com", "Cristobal Towne", "920-812-4093" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0460 Effertz Glens, Yeseniamouth, Finland", new DateTime(1997, 1, 17, 1, 27, 48, 508, DateTimeKind.Utc).AddTicks(577), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Augusta_Koelpin@gmail.com", "Orpha Stehr", "935-446-5753" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "31747 Lowe Spur, East Francisco, Solomon Islands", new DateTime(1964, 3, 9, 19, 59, 43, 606, DateTimeKind.Utc).AddTicks(711), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Americo_Beahan@hotmail.com", "Samir Pfeffer", "485-818-5572" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "537 Henriette Mills, Port Berenice, Bosnia and Herzegovina", new DateTime(1955, 2, 16, 17, 4, 34, 602, DateTimeKind.Utc).AddTicks(8601), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Cortney_McKenzie72@gmail.com", "Walker Goldner", "523-992-2398" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "522 Abel Mountains, New Linnie, Grenada", new DateTime(1976, 12, 21, 18, 12, 47, 486, DateTimeKind.Utc).AddTicks(8203), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Paige60@hotmail.com", "Leila Bauch", "995-653-9421" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "261 Schuppe Village, Yoshikochester, Nepal", new DateTime(1989, 5, 7, 19, 27, 59, 696, DateTimeKind.Utc).AddTicks(9310), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Eudora.Towne46@hotmail.com", "Donavon Fahey", "639-401-6380" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "667 Daphnee Rest, North Samantha, Ukraine", new DateTime(1948, 8, 9, 16, 44, 44, 113, DateTimeKind.Utc).AddTicks(6697), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Eleonore_Gislason8@hotmail.com", "Arlene Hammes", "677-290-0662" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9562 O'Keefe Rapid, South Will, Honduras", new DateTime(1977, 3, 16, 3, 49, 5, 730, DateTimeKind.Utc).AddTicks(1325), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Walter.Cruickshank61@yahoo.com", "Zakary Rau", "952-931-3169" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2621 Harvey Forks, Lake Domenico, Montserrat", new DateTime(1961, 1, 23, 19, 10, 16, 274, DateTimeKind.Utc).AddTicks(9768), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Ivory50@yahoo.com", "Tyree Krajcik", "837-910-3256" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "70792 Kuhlman Way, South Leathaton, Estonia", new DateTime(1963, 11, 4, 4, 48, 55, 771, DateTimeKind.Utc).AddTicks(5468), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Pamela_Tremblay@yahoo.com", "Hellen Ziemann", "551-265-2891" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3753 Morissette Ford, Madysonmouth, Tanzania", new DateTime(1993, 3, 21, 11, 26, 47, 135, DateTimeKind.Utc).AddTicks(5659), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Pattie_Reichert@gmail.com", "Leonor Pollich", "847-924-3318" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3043 Goodwin Mews, Port Davinside, Ireland", new DateTime(1957, 11, 23, 3, 48, 1, 543, DateTimeKind.Utc).AddTicks(1336), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Heloise.Kirlin@gmail.com", "Rosemarie Baumbach", "487-598-6280" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9546 Gottlieb Circle, West Landenside, Central African Republic", new DateTime(1953, 12, 4, 2, 59, 12, 509, DateTimeKind.Utc).AddTicks(3552), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Loy_Considine32@hotmail.com", "Kassandra Rippin", "776-803-6685" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "158 Salvatore Mill, South Anseltown, Equatorial Guinea", new DateTime(1954, 3, 11, 6, 57, 10, 761, DateTimeKind.Utc).AddTicks(2885), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Wilson_Stanton@hotmail.com", "Frederick Mosciski", "247-878-6059" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "491 Reichel Light, Kihnhaven, French Southern Territories", new DateTime(1990, 11, 21, 19, 3, 56, 726, DateTimeKind.Utc).AddTicks(8607), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Marcus58@hotmail.com", "Reagan Schmitt", "728-828-8960" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "021 Maribel Knolls, New Serena, Isle of Man", new DateTime(1960, 6, 23, 12, 42, 24, 675, DateTimeKind.Utc).AddTicks(2587), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Tracey.Brakus@yahoo.com", "Shakira Cassin", "389-320-5861" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "905 Russell Mills, New Benjamin, Bangladesh", new DateTime(1989, 3, 6, 23, 49, 43, 630, DateTimeKind.Utc).AddTicks(6861), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Terrill67@gmail.com", "Stephanie Kuphal", "836-786-2961" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "91819 Rickey Summit, North Orlandmouth, Bouvet Island (Bouvetoya)", new DateTime(1958, 1, 24, 21, 38, 45, 706, DateTimeKind.Utc).AddTicks(359), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Brandyn_Brakus@hotmail.com", "Cecile McGlynn", "211-400-6552" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "29725 Steuber Landing, Rathborough, Svalbard & Jan Mayen Islands", new DateTime(1986, 8, 29, 21, 43, 43, 706, DateTimeKind.Utc).AddTicks(9356), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Joany.Fay@yahoo.com", "Tania Hodkiewicz", "648-806-7852" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9381 Gino Crest, Kshlerinview, Indonesia", new DateTime(1976, 1, 16, 2, 24, 42, 106, DateTimeKind.Utc).AddTicks(2894), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Demarcus7@hotmail.com", "Korbin Prohaska", "488-787-1875" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "794 Libby Rapids, Theronchester, Vanuatu", new DateTime(1968, 2, 18, 21, 54, 44, 271, DateTimeKind.Utc).AddTicks(8571), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Velda_Johns@yahoo.com", "Blaise Corwin", "542-229-2826" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "4281 Orland Neck, Port Mallory, Latvia", new DateTime(1980, 12, 22, 7, 33, 12, 10, DateTimeKind.Utc).AddTicks(2106), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Samara_Ferry@gmail.com", "Waldo Botsford", "780-406-7723" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9884 Fay Island, New Oletatown, Croatia", new DateTime(1955, 1, 26, 18, 10, 24, 155, DateTimeKind.Utc).AddTicks(6832), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Scarlett_Wilkinson@hotmail.com", "Shannon Kutch", "828-873-9187" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "069 Feeney Ways, New Ferne, Malta", new DateTime(1970, 11, 28, 22, 1, 3, 841, DateTimeKind.Utc).AddTicks(8668), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Ahmed_Schultz82@gmail.com", "Abe Kutch", "436-942-6609" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "65782 Kailey Brooks, East Destany, Japan", new DateTime(1963, 12, 31, 18, 27, 53, 155, DateTimeKind.Utc).AddTicks(5977), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Magnus27@gmail.com", "Merlin Anderson", "875-993-0034" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5912 Herman Inlet, Port Virginieview, Cape Verde", new DateTime(1980, 3, 12, 16, 29, 19, 862, DateTimeKind.Utc).AddTicks(3954), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Kaitlin_Huel83@gmail.com", "Lester Veum", "574-366-6554" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9129 Russel Haven, New Verdiemouth, Belgium", new DateTime(1958, 10, 20, 9, 14, 48, 674, DateTimeKind.Utc).AddTicks(6272), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Alfonso.Kuhic85@hotmail.com", "Gwen Padberg", "249-496-9266" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "248 Rau Gateway, Port Hailey, Liberia", new DateTime(1958, 1, 14, 3, 41, 24, 50, DateTimeKind.Utc).AddTicks(6177), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Korey_Steuber8@hotmail.com", "Pink McLaughlin", "585-912-8422" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "027 Jennie Falls, South Lourdes, Hong Kong", new DateTime(1992, 1, 31, 1, 14, 58, 118, DateTimeKind.Utc).AddTicks(8088), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Timothy11@hotmail.com", "Zula Heathcote", "215-636-4354" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6413 Joyce Center, Marvinmouth, Solomon Islands", new DateTime(2002, 11, 17, 21, 50, 0, 557, DateTimeKind.Utc).AddTicks(5646), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Hilton.Haag@gmail.com", "Ivah Schimmel", "711-342-7570" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "96727 Crawford Bridge, Lake Dimitriside, Guernsey", new DateTime(1957, 10, 14, 2, 29, 24, 278, DateTimeKind.Utc).AddTicks(559), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Favian17@gmail.com", "Roma Lowe", "261-849-2316" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "256 Evalyn Station, Andersonside, Brunei Darussalam", new DateTime(1981, 10, 5, 19, 59, 29, 159, DateTimeKind.Utc).AddTicks(2969), new DateTime(2022, 6, 12, 5, 5, 22, 905, DateTimeKind.Utc).AddTicks(3678), "Kamille.Strosin36@hotmail.com", "Carlie Lesch", "936-858-0593" });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 12, 12, 5, 22, 851, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e8f12b8-6446-48ae-9e6d-0328257b8e7c", "AQAAAAEAACcQAAAAEOyYwXqsaMcauYr7r7v9jcKw0ZnF5BRYA97bTIyyIAvlzMy/Zfl0CZyschSs4KvM9Q==", "7a32e9e3-e01d-4484-9b49-64ad1526c468" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "843 Neoma Way, Maverickhaven, United States Minor Outlying Islands", new DateTime(1969, 9, 30, 3, 52, 52, 97, DateTimeKind.Utc).AddTicks(3815), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Hiram_Goldner16@gmail.com", "Genoveva Lueilwitz", "230.417.8188 x4321" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8726 Minerva Plains, Bergstromfurt, French Polynesia", new DateTime(1979, 5, 23, 22, 29, 44, 765, DateTimeKind.Utc).AddTicks(7524), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Emmett_Schulist@yahoo.com", "Mollie Rau", "1-562-202-4725 x6457" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1436 Colleen Manors, Lake Horaceburgh, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(1975, 2, 24, 14, 27, 58, 956, DateTimeKind.Utc).AddTicks(9056), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Larue95@hotmail.com", "Derick Greenfelder", "233-709-0150" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "236 Imani Harbors, New Theo, Jordan", new DateTime(2003, 7, 5, 5, 55, 52, 878, DateTimeKind.Utc).AddTicks(1118), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Brandyn87@yahoo.com", "Kurtis Crooks", "523.488.8413 x100" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "78374 Dannie Gardens, Schuylerbury, Niue", new DateTime(1953, 7, 2, 19, 4, 48, 822, DateTimeKind.Utc).AddTicks(7727), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Bria.Reilly@gmail.com", "Destiney Goldner", "(256) 648-1216 x81749" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "809 Wiegand Meadows, Lake Erica, Honduras", new DateTime(2001, 9, 7, 19, 5, 31, 260, DateTimeKind.Utc).AddTicks(1834), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Laverna_Crona@gmail.com", "Trudie Sanford", "679.671.6886 x619" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "746 Vandervort Pike, North Ricofort, Bangladesh", new DateTime(1986, 11, 7, 16, 24, 58, 0, DateTimeKind.Utc).AddTicks(6925), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Alexanne.Hartmann@gmail.com", "Anjali Hermiston", "388.888.0128" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "528 Shawn Port, Port Mohammadhaven, Tunisia", new DateTime(1985, 1, 1, 4, 0, 40, 467, DateTimeKind.Utc).AddTicks(4230), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Juliana.Ondricka@yahoo.com", "Kennedi Johns", "623.786.1762 x325" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "35310 Giovanny Street, Watsicaport, French Guiana", new DateTime(1972, 2, 6, 11, 47, 27, 309, DateTimeKind.Utc).AddTicks(1512), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "London_Lemke64@yahoo.com", "Hassie Kuphal", "(993) 951-7643 x481" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0297 Winnifred Island, Imaland, Saint Barthelemy", new DateTime(1960, 7, 19, 11, 43, 15, 991, DateTimeKind.Utc).AddTicks(2046), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Kale_Lesch22@hotmail.com", "Heidi Hamill", "573.555.5546" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2460 Marjolaine Turnpike, Lake Barontown, Armenia", new DateTime(1951, 5, 16, 22, 6, 34, 965, DateTimeKind.Utc).AddTicks(3770), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Rosa.Williamson19@hotmail.com", "Billy Carroll", "855.284.6439 x30536" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6634 Haley Extension, Piperchester, Lao People's Democratic Republic", new DateTime(1963, 7, 6, 15, 41, 42, 363, DateTimeKind.Utc).AddTicks(9091), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Theresia.Funk@hotmail.com", "Rubye Nienow", "490.569.8705" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "66382 Rose Points, Lake Rasheed, Papua New Guinea", new DateTime(1955, 3, 16, 12, 9, 12, 450, DateTimeKind.Utc).AddTicks(5069), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Jeanie81@gmail.com", "Julian D'Amore", "704.456.2883 x916" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "630 Lea Turnpike, East Davonside, Bosnia and Herzegovina", new DateTime(1972, 9, 23, 0, 23, 3, 285, DateTimeKind.Utc).AddTicks(5592), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Tabitha_Flatley29@gmail.com", "Mireya Crona", "419.535.9836 x19604" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "227 Daphney Wall, West Lavernview, Qatar", new DateTime(1977, 11, 12, 19, 8, 11, 755, DateTimeKind.Utc).AddTicks(6149), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Hermann_Cummerata15@gmail.com", "Rachel Pacocha", "632-375-0945 x7157" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2133 Sandra Fords, Clemmieland, Mali", new DateTime(1974, 8, 27, 12, 17, 55, 722, DateTimeKind.Utc).AddTicks(2170), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Tavares38@gmail.com", "Mckayla Veum", "1-226-927-7883 x1635" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "99038 Emmett Walks, Port Ivory, Tanzania", new DateTime(1977, 6, 3, 21, 30, 45, 605, DateTimeKind.Utc).AddTicks(8274), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Gregorio_Wunsch9@yahoo.com", "Guadalupe Morissette", "1-743-550-5580 x045" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "233 Andreane Divide, Hermannside, Turkey", new DateTime(1966, 11, 9, 20, 44, 35, 456, DateTimeKind.Utc).AddTicks(6411), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Ewell_Nolan@gmail.com", "Fredrick O'Hara", "(785) 949-5804 x80308" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "170 Gislason Highway, Ashleighhaven, Finland", new DateTime(1975, 5, 14, 14, 57, 10, 712, DateTimeKind.Utc).AddTicks(5041), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Jennifer_Waelchi@yahoo.com", "Estel Feil", "1-361-354-2993 x5879" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1578 Gutmann Skyway, Katlynstad, American Samoa", new DateTime(1982, 8, 2, 7, 54, 8, 584, DateTimeKind.Utc).AddTicks(8900), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "May9@gmail.com", "Bernhard Stanton", "(238) 602-8602" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "4916 Hane Centers, Heaneyhaven, Thailand", new DateTime(1963, 10, 10, 18, 36, 16, 478, DateTimeKind.Utc).AddTicks(8296), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Katelynn.Gibson61@hotmail.com", "Brandon Hilll", "222-772-5286 x55124" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "224 Verda Loop, Hyattborough, Eritrea", new DateTime(1978, 12, 11, 7, 48, 25, 968, DateTimeKind.Utc).AddTicks(6079), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Oran.Langosh@gmail.com", "Muhammad Ruecker", "422-248-7273 x64484" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "888 Larson Burgs, North Ignatiusview, Sao Tome and Principe", new DateTime(2000, 10, 27, 10, 4, 27, 976, DateTimeKind.Utc).AddTicks(7908), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Salvatore_Ortiz@yahoo.com", "Damaris MacGyver", "1-717-794-1298" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "23243 Marcella Springs, Lake Eliseofort, Afghanistan", new DateTime(1989, 1, 15, 1, 18, 30, 438, DateTimeKind.Utc).AddTicks(2929), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Leon_Ruecker@gmail.com", "Isaiah Walter", "(878) 755-6593 x55450" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "42414 Russell Inlet, Donnellyburgh, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2003, 9, 24, 18, 58, 16, 642, DateTimeKind.Utc).AddTicks(8357), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Brad90@gmail.com", "Webster Borer", "1-769-748-2734 x20533" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "17352 Haylee Keys, Gladyceburgh, Congo", new DateTime(1963, 3, 16, 19, 34, 5, 372, DateTimeKind.Utc).AddTicks(6723), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Carmella81@gmail.com", "Gennaro Balistreri", "1-906-670-6177 x67080" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6630 Lueilwitz Trace, South Adellborough, Saint Lucia", new DateTime(1999, 12, 28, 6, 24, 47, 264, DateTimeKind.Utc).AddTicks(9521), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Ashton.Moen@yahoo.com", "Herminia Larkin", "612.284.9623 x6662" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "77014 Hilpert Forest, Lynchville, Albania", new DateTime(1988, 5, 2, 9, 43, 50, 750, DateTimeKind.Utc).AddTicks(9532), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Zackary_Rice66@yahoo.com", "Marguerite Zulauf", "1-277-389-9374" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8301 Berge Mountains, South General, Republic of Korea", new DateTime(1992, 1, 26, 18, 48, 28, 390, DateTimeKind.Utc).AddTicks(5653), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Cordelia_OHara14@gmail.com", "Grayson MacGyver", "1-266-958-8177" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "18251 O'Hara Viaduct, Nelleborough, Faroe Islands", new DateTime(1965, 10, 22, 12, 0, 15, 352, DateTimeKind.Utc).AddTicks(8144), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Myron_Rau25@hotmail.com", "Josh Crona", "604-600-4946" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "779 Kayley Roads, Walkerburgh, Turkmenistan", new DateTime(1987, 12, 25, 22, 20, 1, 791, DateTimeKind.Utc).AddTicks(1491), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Dane.Abshire@gmail.com", "Vincent Ernser", "1-636-905-5187 x57071" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "34631 Bradtke Drives, Lake Providenciview, Morocco", new DateTime(1981, 11, 21, 21, 45, 30, 510, DateTimeKind.Utc).AddTicks(5175), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Faustino.Hammes@hotmail.com", "Hertha Roberts", "(959) 311-1211" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "59973 Rahul Lights, West Abbey, Germany", new DateTime(1944, 8, 22, 17, 9, 26, 395, DateTimeKind.Utc).AddTicks(1873), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Emerson_Kessler52@yahoo.com", "Pierre Kub", "352-812-5100" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7525 Tiffany Union, Sammyville, Tuvalu", new DateTime(1954, 1, 11, 2, 44, 30, 152, DateTimeKind.Utc).AddTicks(1110), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Otho.Turner82@gmail.com", "Adolf Hammes", "422.213.6463 x33635" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "59333 Ellie Prairie, Lake Daisyborough, Peru", new DateTime(1993, 3, 31, 22, 5, 53, 697, DateTimeKind.Utc).AddTicks(2332), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Loy67@yahoo.com", "Alice Howell", "1-479-925-8245 x7512" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0473 Shannon Trace, Naderland, Gambia", new DateTime(1959, 9, 13, 21, 36, 34, 940, DateTimeKind.Utc).AddTicks(3882), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Tyreek_Ratke54@gmail.com", "General O'Conner", "1-735-408-5071 x487" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "052 Greenfelder Knoll, Pfefferside, Poland", new DateTime(1981, 12, 14, 20, 27, 44, 134, DateTimeKind.Utc).AddTicks(7711), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Preston_Herman@hotmail.com", "Abraham Wiegand", "1-993-371-9767" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "941 Clarissa Valley, East Aaron, Kyrgyz Republic", new DateTime(1954, 5, 4, 16, 48, 12, 504, DateTimeKind.Utc).AddTicks(2385), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Casper90@gmail.com", "Cindy Heidenreich", "961-987-4014 x38473" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6671 Huels Creek, South Lon, Angola", new DateTime(1958, 7, 14, 11, 5, 31, 291, DateTimeKind.Utc).AddTicks(7366), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Ova37@yahoo.com", "Esmeralda Witting", "734.583.6135 x74810" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "639 Wilmer Knoll, North Mathias, Spain", new DateTime(2000, 8, 19, 8, 9, 25, 308, DateTimeKind.Utc).AddTicks(6741), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Herminio.Wisoky@yahoo.com", "Larissa Bahringer", "(358) 594-3670 x8879" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "05429 Daphne Squares, East Will, Greenland", new DateTime(1972, 10, 20, 8, 5, 5, 627, DateTimeKind.Utc).AddTicks(9489), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Russel_Homenick@yahoo.com", "Nolan Ledner", "1-950-405-8629 x93098" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "91063 Beer Parkway, Erikashire, Ghana", new DateTime(1972, 4, 12, 23, 8, 54, 128, DateTimeKind.Utc).AddTicks(7481), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Kylie.Little17@gmail.com", "Erna Brekke", "689.703.9946 x1752" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "23326 Wilfred Inlet, East Hazle, Guyana", new DateTime(1998, 7, 30, 5, 15, 13, 451, DateTimeKind.Utc).AddTicks(4061), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Titus.Boehm@hotmail.com", "Pete Thiel", "670-969-8128" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "43257 Caesar Fall, North Reece, Martinique", new DateTime(2001, 5, 5, 2, 49, 9, 685, DateTimeKind.Utc).AddTicks(2383), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Era_Schumm@yahoo.com", "Dudley Heaney", "(735) 886-2510 x8187" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "786 Haley Summit, Domenicland, Turkey", new DateTime(1985, 7, 15, 18, 56, 2, 278, DateTimeKind.Utc).AddTicks(3273), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Hailie_Hudson@hotmail.com", "Dan Mitchell", "(453) 370-7365" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "738 Nitzsche Common, Willmsfurt, Svalbard & Jan Mayen Islands", new DateTime(1967, 1, 7, 17, 56, 36, 379, DateTimeKind.Utc).AddTicks(4863), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Erik63@yahoo.com", "Tate Zieme", "568-341-4820 x311" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "63813 Cooper Harbors, Mckaylachester, Dominica", new DateTime(1960, 2, 19, 23, 1, 18, 917, DateTimeKind.Utc).AddTicks(7694), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Berneice44@yahoo.com", "Richard Glover", "(355) 969-0757 x50322" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "594 Dejah Meadows, Linneaport, Lithuania", new DateTime(1991, 1, 30, 18, 20, 49, 241, DateTimeKind.Utc).AddTicks(5774), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Aletha.Homenick@gmail.com", "Rocio Bins", "866.721.5596" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "267 Micah Ford, New Ashtyn, United Kingdom", new DateTime(1986, 10, 22, 0, 5, 16, 168, DateTimeKind.Utc).AddTicks(931), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Dan_Hickle@yahoo.com", "Estefania Yundt", "909-336-1909 x9973" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "73726 Pete Club, Glendafurt, Uganda", new DateTime(1992, 9, 7, 7, 4, 46, 228, DateTimeKind.Utc).AddTicks(3834), new DateTime(2022, 6, 9, 10, 17, 17, 732, DateTimeKind.Utc).AddTicks(5916), "Garret_Baumbach@hotmail.com", "Lorna Armstrong", "700-735-7463 x565" });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 9, 17, 17, 17, 682, DateTimeKind.Local).AddTicks(6596));
        }
    }
}
