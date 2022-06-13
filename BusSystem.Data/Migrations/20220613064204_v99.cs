using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class v99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2011c37b-9e4b-4c0b-8e0f-73105ee5e864", "AQAAAAEAACcQAAAAEPTV0SRfUjgMBFS6P9VxA0pzpeh16kYhkS/2KeM4Nw+qnLFTVF7f/iWAN9iV3DTGAA==", "8ca52c02-cc5a-4310-bed7-ebbbbc8c0e34" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5304 Arne Causeway, North Quentin, Ghana", new DateTime(1993, 12, 17, 17, 46, 33, 636, DateTimeKind.Utc).AddTicks(1656), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Ada.Rice@yahoo.com", "Dwight Sauer", "622-677-7470" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2189 Powlowski Land, New Johathanmouth, Tajikistan", new DateTime(1985, 3, 31, 8, 8, 38, 260, DateTimeKind.Utc).AddTicks(5238), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Otilia_Lesch@hotmail.com", "Esta Klocko", "872-210-4330" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "407 Immanuel Islands, Raeville, Iraq", new DateTime(1950, 10, 23, 3, 13, 12, 967, DateTimeKind.Utc).AddTicks(9028), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Moises_Shields@hotmail.com", "Kaya Witting", "755-460-5753" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "688 Orn Landing, Ellieview, Somalia", new DateTime(1992, 10, 8, 9, 1, 2, 847, DateTimeKind.Utc).AddTicks(4156), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Queenie.Hermiston@gmail.com", "Roosevelt Rohan", "495-632-4529" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "282 Strosin Haven, North Verlie, Macao", new DateTime(1991, 6, 6, 14, 46, 33, 868, DateTimeKind.Utc).AddTicks(1834), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Reina64@yahoo.com", "Rubye Orn", "331-302-7952" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "793 Susanna Key, Jovanport, Brunei Darussalam", new DateTime(1996, 9, 26, 13, 30, 53, 224, DateTimeKind.Utc).AddTicks(8382), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Mallie91@gmail.com", "Dale Stiedemann", "526-776-3766" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0430 Hillard Route, Lake Zulashire, Philippines", new DateTime(1959, 6, 17, 2, 0, 7, 684, DateTimeKind.Utc).AddTicks(4911), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Alberta.Schmitt@gmail.com", "Autumn Hirthe", "774-767-1356" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "65690 Stehr Coves, Hesselshire, Dominica", new DateTime(1964, 2, 14, 8, 37, 47, 57, DateTimeKind.Utc).AddTicks(9873), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Savion_Bosco9@gmail.com", "Albina Gusikowski", "808-758-9907" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "132 Stroman Turnpike, Hellerstad, Saudi Arabia", new DateTime(1979, 8, 5, 23, 58, 39, 334, DateTimeKind.Utc).AddTicks(6057), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Garrick52@yahoo.com", "Georgette Bogan", "512-945-8958" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "40199 Gorczany Mountains, New Bruce, Italy", new DateTime(1997, 1, 17, 22, 42, 11, 328, DateTimeKind.Utc).AddTicks(1291), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Ida_Bauch@gmail.com", "Jonathon Paucek", "824-692-3008" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "19909 Etha Fort, Joeport, Malta", new DateTime(2000, 9, 24, 5, 53, 4, 40, DateTimeKind.Utc).AddTicks(2791), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Hugh_Mraz@gmail.com", "Johan Kessler", "583-600-3219" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "793 Swaniawski Villages, South Sunnyside, Andorra", new DateTime(1961, 6, 22, 17, 48, 33, 665, DateTimeKind.Utc).AddTicks(9678), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Graciela65@hotmail.com", "Calista Block", "599-424-1228" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "710 Alberto Motorway, Marcusberg, Kiribati", new DateTime(1949, 5, 7, 18, 47, 33, 59, DateTimeKind.Utc).AddTicks(5151), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Velda.Graham@yahoo.com", "Marc Rosenbaum", "982-277-5964" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1564 Omer Spurs, Zulaberg, Algeria", new DateTime(1960, 1, 23, 1, 39, 8, 390, DateTimeKind.Utc).AddTicks(5360), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Jesse.Bernier@gmail.com", "Omer Larson", "918-959-8075" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "01887 Velda Spring, Kenburgh, Bermuda", new DateTime(1968, 11, 4, 20, 41, 28, 97, DateTimeKind.Utc).AddTicks(8467), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Zoey91@gmail.com", "Kacey Buckridge", "285-256-8891" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7349 Verner Trail, Luciusland, Estonia", new DateTime(1966, 11, 12, 10, 57, 56, 316, DateTimeKind.Utc).AddTicks(9664), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Javon.Hane@yahoo.com", "Raymond Dicki", "260-574-5411" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "863 Lilian Road, West Kennedishire, Iran", new DateTime(1982, 5, 19, 23, 46, 11, 210, DateTimeKind.Utc).AddTicks(8630), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Emory37@hotmail.com", "Edwardo Willms", "607-473-5553" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8086 Weissnat Fords, Dejonfort, Portugal", new DateTime(1949, 12, 14, 10, 11, 35, 599, DateTimeKind.Utc).AddTicks(8036), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Lois.Heidenreich52@yahoo.com", "Forest Cummings", "376-861-7212" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "44581 Felicity Roads, Rooseveltton, Equatorial Guinea", new DateTime(2002, 3, 9, 10, 30, 7, 193, DateTimeKind.Utc).AddTicks(6396), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Maud86@hotmail.com", "Ashly Bartoletti", "204-880-3007" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "29927 Lehner Plains, Adriannaland, Turkmenistan", new DateTime(1968, 10, 7, 21, 8, 10, 960, DateTimeKind.Utc).AddTicks(1551), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Brennan.Weber@yahoo.com", "Max Jacobs", "290-318-4614" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "51492 Rosie Green, Hardyville, Angola", new DateTime(1983, 7, 16, 18, 33, 2, 832, DateTimeKind.Utc).AddTicks(8289), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Isai.Wintheiser11@hotmail.com", "Jacky Deckow", "532-493-7828" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0671 Pacocha Shoal, Lake Kenyon, Liechtenstein", new DateTime(1955, 10, 16, 6, 29, 2, 418, DateTimeKind.Utc).AddTicks(8888), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Jeffrey13@gmail.com", "Oscar Franecki", "500-498-5314" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "527 Nicole Lane, Hagenesbury, Uganda", new DateTime(2002, 7, 22, 2, 20, 48, 11, DateTimeKind.Utc).AddTicks(3792), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Quinten25@yahoo.com", "Lelah Rempel", "406-429-3588" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "63069 Mraz Gateway, South Davonteville, Uruguay", new DateTime(1995, 11, 19, 14, 11, 47, 837, DateTimeKind.Utc).AddTicks(5260), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Frankie.Berge87@gmail.com", "Claudia Reichert", "377-452-3874" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "14053 Hallie Harbor, South Ianland, Vanuatu", new DateTime(1990, 4, 5, 12, 22, 48, 133, DateTimeKind.Utc).AddTicks(4468), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Jannie_Robel@yahoo.com", "Johnathan Daugherty", "629-341-0682" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0931 Schinner Pine, Lake Cordelia, Cuba", new DateTime(1982, 12, 29, 11, 47, 58, 356, DateTimeKind.Utc).AddTicks(3560), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Effie24@yahoo.com", "Mitchel Ankunding", "761-280-5803" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0494 Gavin Shore, Buckridgebury, Gabon", new DateTime(1978, 12, 24, 15, 31, 23, 817, DateTimeKind.Utc).AddTicks(8576), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Marquise_Christiansen@gmail.com", "Hadley Renner", "699-694-1070" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "797 Nitzsche Street, New Fredrickfort, Uruguay", new DateTime(1946, 5, 1, 7, 54, 45, 955, DateTimeKind.Utc).AddTicks(144), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Shanelle_Keeling69@gmail.com", "Danial Wehner", "482-613-5950" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "729 Mckayla Route, Port Kianfort, Burundi", new DateTime(1995, 6, 20, 18, 22, 30, 215, DateTimeKind.Utc).AddTicks(9021), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Victoria61@gmail.com", "Mercedes Stokes", "755-438-3441" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "851 Murray Corners, Noeliahaven, Malta", new DateTime(1977, 8, 13, 15, 37, 23, 805, DateTimeKind.Utc).AddTicks(9624), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Alexandre36@hotmail.com", "Adelbert Cole", "624-895-6278" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "865 Pauline Islands, Cronastad, Burkina Faso", new DateTime(1946, 8, 18, 18, 32, 52, 302, DateTimeKind.Utc).AddTicks(1301), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Gwen39@hotmail.com", "Frederick Gutkowski", "840-461-8709" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "146 Hegmann Walk, Chloeview, Lebanon", new DateTime(1977, 10, 8, 14, 44, 9, 543, DateTimeKind.Utc).AddTicks(8267), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Clark_Cormier@yahoo.com", "Virginia Schowalter", "313-700-8719" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "936 Carroll Crest, West Kieraview, Saint Pierre and Miquelon", new DateTime(1967, 1, 26, 13, 20, 33, 91, DateTimeKind.Utc).AddTicks(7149), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "William0@hotmail.com", "Ubaldo Marvin", "707-426-6665" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "932 Fatima Shoal, Lake Rhiannonshire, Timor-Leste", new DateTime(1997, 11, 25, 9, 12, 14, 231, DateTimeKind.Utc).AddTicks(11), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Lindsey84@hotmail.com", "Destiny Wisozk", "292-928-9244" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "720 Bennett Shore, West Selinamouth, Tonga", new DateTime(1973, 5, 6, 3, 3, 20, 333, DateTimeKind.Utc).AddTicks(8882), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Salma.Daniel17@gmail.com", "Estella O'Keefe", "519-754-8576" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "09911 Gaylord Parks, Sanfordton, Chad", new DateTime(1983, 4, 26, 20, 25, 22, 812, DateTimeKind.Utc).AddTicks(7976), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Prince54@hotmail.com", "Rosemary Schmeler", "524-353-5287" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "72190 Roob Square, East Sagebury, Tonga", new DateTime(1982, 6, 9, 16, 53, 28, 914, DateTimeKind.Utc).AddTicks(2491), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Beverly_Reinger29@gmail.com", "Eleanora Hodkiewicz", "492-862-4604" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "07953 Lauryn Valley, Port Kieranville, Isle of Man", new DateTime(1992, 3, 21, 18, 27, 14, 50, DateTimeKind.Utc).AddTicks(6914), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Ole_Aufderhar@gmail.com", "Sigmund Keebler", "318-850-0730" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "26867 Beatty Mission, Metzside, Portugal", new DateTime(1972, 12, 26, 10, 9, 0, 846, DateTimeKind.Utc).AddTicks(1138), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Danyka39@hotmail.com", "Lamont Hermiston", "412-627-4971" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1653 Asha Neck, Carolinaview, Svalbard & Jan Mayen Islands", new DateTime(1974, 3, 11, 23, 58, 9, 95, DateTimeKind.Utc).AddTicks(1291), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Pat51@hotmail.com", "Dereck Halvorson", "810-889-6877" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5420 Barton Haven, Parkerton, Moldova", new DateTime(1976, 11, 11, 10, 26, 10, 575, DateTimeKind.Utc).AddTicks(1574), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Greg_Rath41@hotmail.com", "Modesto Cormier", "644-735-3193" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "4521 Willms Forge, Kertzmannton, Burundi", new DateTime(1996, 9, 23, 20, 58, 58, 733, DateTimeKind.Utc).AddTicks(856), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Filomena12@yahoo.com", "Toni Sauer", "936-370-1672" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "771 Koch Brook, West Haleyburgh, Mauritius", new DateTime(1990, 1, 4, 7, 11, 25, 762, DateTimeKind.Utc).AddTicks(9366), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Filiberto97@yahoo.com", "Diana Hilll", "910-762-9981" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "264 Parker Falls, Gwendolynton, Thailand", new DateTime(1969, 12, 14, 2, 42, 32, 919, DateTimeKind.Utc).AddTicks(7386), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Adolf_Bernhard@hotmail.com", "Quinn Schinner", "872-526-5821" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "49511 Joelle Lock, Lamarbury, Mongolia", new DateTime(1968, 3, 11, 23, 7, 51, 843, DateTimeKind.Utc).AddTicks(9357), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Javonte85@gmail.com", "Audra Smitham", "533-306-5814" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "035 Berge Lock, Port Kyleefurt, Swaziland", new DateTime(1997, 2, 23, 11, 28, 48, 441, DateTimeKind.Utc).AddTicks(7087), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Marion32@hotmail.com", "Vada Lang", "524-976-0478" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "05845 Cornell Plains, Odessabury, Monaco", new DateTime(1959, 9, 16, 12, 44, 12, 833, DateTimeKind.Utc).AddTicks(4047), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Vidal_Sanford88@yahoo.com", "Armand Kertzmann", "261-628-4365" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "265 Percy Unions, Port Shannon, Canada", new DateTime(1976, 8, 4, 3, 14, 33, 154, DateTimeKind.Utc).AddTicks(293), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Blanche.Torp@gmail.com", "Maryam Adams", "925-966-4032" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "72704 Noemi Summit, East Johathan, Chad", new DateTime(1966, 3, 2, 5, 40, 53, 108, DateTimeKind.Utc).AddTicks(8858), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Marisol_Feeney85@yahoo.com", "Bernard Kshlerin", "377-691-8389" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "23674 Casper River, Maximeshire, Aruba", new DateTime(1975, 6, 15, 1, 7, 53, 320, DateTimeKind.Utc).AddTicks(9023), new DateTime(2022, 6, 13, 6, 42, 3, 350, DateTimeKind.Utc).AddTicks(9084), "Velda52@gmail.com", "Gloria Keeling", "654-630-8543" });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 13, 13, 42, 3, 296, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TransactionId",
                table: "Orders",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_TransactionHis_TransactionId",
                table: "Orders",
                column: "TransactionId",
                principalTable: "TransactionHis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_TransactionHis_TransactionId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TransactionId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Orders");

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
        }
    }
}
