using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class v9900 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "TransacionId",
                table: "Orders",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08f50f0a-c3fd-4102-a8f0-b86dc9ee92f6", "AQAAAAEAACcQAAAAEAj4br0g1mML+bUDsbuOn73C7pufxS1OXRDyVMMo0e4rlMCJRiZHoWSgHlIarUJVnw==", "be1d3949-1015-4eca-a31a-807ef63b9cfb" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "930 Friesen Neck, New Carrollland, Paraguay", new DateTime(1971, 7, 1, 22, 0, 49, 827, DateTimeKind.Utc).AddTicks(4698), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Sandy.Moen@yahoo.com", "Tressa Ebert", "606-420-1083" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "99182 Cleveland Plains, South Desiree, Ethiopia", new DateTime(1966, 3, 31, 22, 58, 59, 106, DateTimeKind.Utc).AddTicks(4807), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Jaiden_Jacobi73@yahoo.com", "Jaida Heathcote", "484-513-1384" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "986 Pollich Inlet, West Dion, Trinidad and Tobago", new DateTime(1974, 5, 25, 15, 44, 35, 568, DateTimeKind.Utc).AddTicks(8109), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Weldon_Koelpin49@yahoo.com", "Marques Parisian", "561-681-7457" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "781 Wolff Parks, Port Camden, Greece", new DateTime(1947, 12, 5, 19, 28, 4, 330, DateTimeKind.Utc).AddTicks(5927), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Zachariah.Walker69@gmail.com", "Rachel Aufderhar", "792-306-5055" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6347 Idell Drives, Lednertown, Kiribati", new DateTime(1976, 5, 9, 1, 14, 47, 171, DateTimeKind.Utc).AddTicks(3612), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Cheyanne85@gmail.com", "Janelle Gutkowski", "701-378-4739" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "56824 Emmerich Shoal, Port Randalchester, United Kingdom", new DateTime(1957, 9, 16, 23, 52, 3, 185, DateTimeKind.Utc).AddTicks(9595), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Gladyce45@yahoo.com", "Maymie Frami", "718-845-5680" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "560 Oleta Forges, New Christopher, Central African Republic", new DateTime(1998, 6, 22, 12, 49, 17, 921, DateTimeKind.Utc).AddTicks(7577), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Annie.Walter91@gmail.com", "Haven Aufderhar", "677-515-3291" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9038 Donnelly Roads, Ferryland, Canada", new DateTime(1965, 7, 13, 21, 35, 2, 432, DateTimeKind.Utc).AddTicks(83), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Norene_Cassin@hotmail.com", "Brando Jerde", "918-768-1828" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "11397 Penelope Parkways, Beckerfort, Chad", new DateTime(1966, 10, 9, 3, 58, 56, 693, DateTimeKind.Utc).AddTicks(3830), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Jules.Mitchell@yahoo.com", "Darron Nicolas", "517-527-3350" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "83691 Wiley Ways, Dulcefort, Belize", new DateTime(2003, 4, 29, 6, 18, 23, 668, DateTimeKind.Utc).AddTicks(8697), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Colton60@yahoo.com", "Pierce King", "414-204-5887" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6662 Madonna Trafficway, Dachburgh, Slovenia", new DateTime(1952, 5, 22, 19, 4, 40, 310, DateTimeKind.Utc).AddTicks(8236), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Carter.Rogahn97@hotmail.com", "Retta Treutel", "815-398-9535" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "355 Haleigh Prairie, Nikolausbury, Gibraltar", new DateTime(1950, 7, 3, 1, 12, 52, 964, DateTimeKind.Utc).AddTicks(7117), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Manuela.Cruickshank@hotmail.com", "Polly Feil", "258-917-2860" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0455 Trace View, West Leonie, Belgium", new DateTime(1995, 8, 12, 2, 46, 42, 467, DateTimeKind.Utc).AddTicks(8176), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Raleigh14@hotmail.com", "Maynard Bogan", "895-286-4661" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "199 Gottlieb Shoal, Marcosshire, Tanzania", new DateTime(1964, 1, 24, 5, 22, 49, 571, DateTimeKind.Utc).AddTicks(1707), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Yasmeen_Runolfsson45@yahoo.com", "Philip Pacocha", "399-694-1224" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "280 Schumm Skyway, Mauriceland, Maldives", new DateTime(1997, 9, 22, 17, 36, 38, 474, DateTimeKind.Utc).AddTicks(4235), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Amaya64@gmail.com", "Hayley Simonis", "776-750-5988" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1972 Roman Pass, North Ronaldo, Seychelles", new DateTime(1973, 12, 6, 2, 1, 57, 855, DateTimeKind.Utc).AddTicks(7302), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Garnett.Schowalter28@yahoo.com", "Letha Stiedemann", "277-706-1628" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "258 Kristoffer Inlet, Langbury, Ecuador", new DateTime(1969, 8, 11, 8, 26, 18, 574, DateTimeKind.Utc).AddTicks(131), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Sigmund.Boehm@hotmail.com", "Jaquelin Aufderhar", "243-980-8478" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9490 Aracely Key, Enidport, Iceland", new DateTime(1974, 3, 18, 18, 11, 48, 324, DateTimeKind.Utc).AddTicks(9685), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Jacinthe79@gmail.com", "Aniyah Gutmann", "207-255-1907" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "255 Wilderman Brooks, Mitchellstad, Comoros", new DateTime(1969, 5, 10, 17, 25, 50, 684, DateTimeKind.Utc).AddTicks(1874), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Victor_Waters@yahoo.com", "Stefanie Kuvalis", "460-401-5645" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "68522 Alford Prairie, Lorenaside, Isle of Man", new DateTime(1975, 11, 11, 1, 56, 45, 668, DateTimeKind.Utc).AddTicks(209), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Bradford.Walker@hotmail.com", "Douglas Bayer", "636-385-7343" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "592 Jake Circle, Lake Kimberlyland, New Caledonia", new DateTime(1945, 9, 2, 12, 57, 16, 299, DateTimeKind.Utc).AddTicks(7855), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Lester_Reichert55@gmail.com", "Nils Wyman", "942-275-1194" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "075 Angus Glen, Harberton, Somalia", new DateTime(1965, 3, 26, 13, 9, 26, 456, DateTimeKind.Utc).AddTicks(7824), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Whitney.Upton@gmail.com", "Caleb Terry", "772-701-4865" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "951 Price Rest, New Zetta, Yemen", new DateTime(1969, 9, 11, 9, 50, 11, 23, DateTimeKind.Utc).AddTicks(3569), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Adonis_Monahan@yahoo.com", "Gretchen Stanton", "677-374-1262" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "41950 Brando Ways, East Rhiannon, United States Minor Outlying Islands", new DateTime(1964, 6, 15, 16, 43, 15, 344, DateTimeKind.Utc).AddTicks(1192), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Lionel80@hotmail.com", "Lysanne Howe", "401-315-8154" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "466 Rachel Stravenue, New Abel, Macedonia", new DateTime(1949, 2, 1, 13, 25, 51, 488, DateTimeKind.Utc).AddTicks(2833), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Trisha.Sipes63@yahoo.com", "Fae Hettinger", "380-211-0945" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "589 Schiller Tunnel, Lake Kalebury, Panama", new DateTime(1996, 7, 15, 1, 28, 1, 942, DateTimeKind.Utc).AddTicks(3025), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Dayana.Padberg@yahoo.com", "Alaina Hessel", "481-426-8168" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9602 Sophia Terrace, Hickleview, Georgia", new DateTime(1971, 7, 22, 5, 22, 54, 355, DateTimeKind.Utc).AddTicks(5330), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Gerda_Bergnaum32@yahoo.com", "Jacques Dickens", "860-534-6103" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2620 Vida Lakes, Percybury, Trinidad and Tobago", new DateTime(1983, 8, 25, 12, 56, 14, 833, DateTimeKind.Utc).AddTicks(7019), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Monserrat.Corkery@hotmail.com", "Daphney Crist", "913-267-1532" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "059 Nash Prairie, Beckerport, Gabon", new DateTime(1991, 6, 17, 17, 34, 54, 974, DateTimeKind.Utc).AddTicks(5437), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Eliezer_Dicki94@hotmail.com", "Jermain Bauch", "222-615-2822" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6626 Ward Ports, Josephburgh, Togo", new DateTime(1972, 1, 21, 22, 22, 29, 215, DateTimeKind.Utc).AddTicks(4857), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Chelsey_Wilderman@hotmail.com", "Lucious Gerhold", "734-855-4014" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "67643 Leannon Square, West Gilberto, Albania", new DateTime(1944, 11, 9, 12, 7, 42, 715, DateTimeKind.Utc).AddTicks(4273), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Kirsten87@yahoo.com", "Dominic Grady", "804-460-0326" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0042 Boyle Corner, Kuhlmanburgh, Guam", new DateTime(2002, 10, 30, 16, 44, 48, 176, DateTimeKind.Utc).AddTicks(7602), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Joey51@gmail.com", "Idella Schmitt", "534-441-3876" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "283 Will Bypass, Mikaylastad, Northern Mariana Islands", new DateTime(2003, 6, 6, 15, 41, 34, 406, DateTimeKind.Utc).AddTicks(6516), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Milan_Cormier@hotmail.com", "Grant Kerluke", "610-704-9839" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "370 Herman Path, West Maximilianmouth, Vanuatu", new DateTime(1962, 10, 10, 5, 36, 49, 732, DateTimeKind.Utc).AddTicks(3418), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Morris.Koepp15@hotmail.com", "Pearline Collier", "416-828-8191" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6134 Nellie Summit, Tarynberg, Australia", new DateTime(1979, 7, 20, 9, 56, 51, 230, DateTimeKind.Utc).AddTicks(5683), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Estella40@gmail.com", "Ted Wuckert", "668-546-1074" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2987 Fisher Mountains, Bomouth, Saint Barthelemy", new DateTime(1951, 12, 23, 12, 32, 5, 433, DateTimeKind.Utc).AddTicks(4225), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Lawson_Stiedemann38@hotmail.com", "Lera Bode", "835-885-9065" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1507 Royce Highway, New Amalia, Gibraltar", new DateTime(1950, 9, 2, 4, 44, 30, 203, DateTimeKind.Utc).AddTicks(3476), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Linnea.Rogahn@gmail.com", "Graham Steuber", "223-910-1393" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "80261 Vada Glen, New Grace, Burundi", new DateTime(1987, 10, 13, 15, 51, 7, 351, DateTimeKind.Utc).AddTicks(1566), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Walker32@gmail.com", "Tevin Dietrich", "239-451-9818" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "98762 Summer Center, Wyattview, Mongolia", new DateTime(1948, 6, 24, 23, 44, 9, 608, DateTimeKind.Utc).AddTicks(8314), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Nyasia_Wunsch@hotmail.com", "Liana Rippin", "208-683-3192" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "310 Feil Run, Juliafurt, South Africa", new DateTime(1955, 4, 22, 5, 3, 23, 492, DateTimeKind.Utc).AddTicks(9423), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Jackson91@gmail.com", "Boyd Thiel", "241-372-0507" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7762 Mallory Mills, Lake Gay, Timor-Leste", new DateTime(1974, 6, 5, 0, 42, 16, 456, DateTimeKind.Utc).AddTicks(5112), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Dejon_Bartell@hotmail.com", "Kenneth Olson", "502-994-3051" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6187 Pfannerstill Fork, South Marcusfurt, Germany", new DateTime(2003, 1, 3, 18, 23, 4, 804, DateTimeKind.Utc).AddTicks(4317), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Cornell_Greenfelder56@gmail.com", "Cierra Gutkowski", "868-312-1162" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6586 Waelchi Stravenue, East Jarrettborough, Moldova", new DateTime(1966, 2, 3, 11, 10, 39, 674, DateTimeKind.Utc).AddTicks(2437), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Casimir30@yahoo.com", "Katharina Beer", "762-728-0496" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2362 Vandervort Course, Savannahfurt, Vanuatu", new DateTime(1991, 8, 8, 11, 44, 39, 595, DateTimeKind.Utc).AddTicks(461), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Lamar_Marquardt85@yahoo.com", "Andy Wyman", "933-376-6961" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "73846 Ritchie Brooks, North Sandyshire, Gibraltar", new DateTime(2000, 9, 3, 5, 42, 14, 369, DateTimeKind.Utc).AddTicks(8961), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Jerome73@yahoo.com", "Tanner Ziemann", "372-221-4640" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5830 Paucek Roads, East Claudine, Guyana", new DateTime(1975, 6, 17, 20, 10, 27, 748, DateTimeKind.Utc).AddTicks(8213), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Electa.McClure@hotmail.com", "Belle Reynolds", "428-718-5868" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "536 Yessenia Isle, Balistrerifort, Niger", new DateTime(1958, 1, 30, 19, 33, 15, 820, DateTimeKind.Utc).AddTicks(549), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Johanna.Stanton18@hotmail.com", "Cynthia Wolff", "288-906-6582" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "044 Krystel Forge, Colinhaven, China", new DateTime(1989, 5, 20, 18, 51, 23, 732, DateTimeKind.Utc).AddTicks(793), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Lew.Carter@hotmail.com", "Nestor Fahey", "736-210-7123" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7322 Princess Harbors, Feeneyfort, Kyrgyz Republic", new DateTime(1952, 3, 11, 5, 55, 14, 677, DateTimeKind.Utc).AddTicks(82), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Minnie0@gmail.com", "Mckenna Aufderhar", "655-368-8738" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "945 Pagac Junction, Schmelerville, Austria", new DateTime(1950, 2, 22, 15, 49, 41, 67, DateTimeKind.Utc).AddTicks(2144), new DateTime(2022, 6, 13, 6, 50, 35, 396, DateTimeKind.Utc).AddTicks(8359), "Kaya1@hotmail.com", "Brady Sporer", "203-618-9959" });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 13, 13, 50, 35, 341, DateTimeKind.Local).AddTicks(3004));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransacionId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ede1e264-5322-43ab-82f7-c7d31e023eb8", "AQAAAAEAACcQAAAAEEoOnWR/V7l0NaiEjaoxBDh1YPkBwbOL5FU6CjfejMSg+QxpUJVWMceBTooBrnUSQw==", "6158a7ca-0d18-48aa-b487-696862b8ae47" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "91906 Hills Meadow, East Kayli, Rwanda", new DateTime(1982, 8, 31, 2, 15, 38, 72, DateTimeKind.Utc).AddTicks(2947), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Johnson_Von@hotmail.com", "Garth Lueilwitz", "579-299-2626" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6410 Lubowitz Pines, North Gabrielle, Eritrea", new DateTime(1984, 11, 16, 20, 39, 37, 176, DateTimeKind.Utc).AddTicks(3477), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Chelsie_Flatley20@hotmail.com", "Ezekiel Rice", "518-759-3564" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8184 Altenwerth Bypass, New Alana, Turkey", new DateTime(1984, 8, 5, 19, 2, 40, 669, DateTimeKind.Utc).AddTicks(665), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Mack44@yahoo.com", "Maximillia Kihn", "513-273-8962" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "681 Beier Pine, New Lola, Saint Kitts and Nevis", new DateTime(1998, 10, 17, 19, 10, 44, 609, DateTimeKind.Utc).AddTicks(6559), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Brianne27@gmail.com", "Tyson Krajcik", "760-423-1396" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3220 Senger Creek, West Tremaynetown, Saint Barthelemy", new DateTime(1975, 4, 8, 22, 47, 23, 556, DateTimeKind.Utc).AddTicks(1176), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Della82@yahoo.com", "Darien Steuber", "745-585-3382" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2977 Walker Forge, Ebertchester, Angola", new DateTime(1964, 1, 7, 10, 43, 6, 178, DateTimeKind.Utc).AddTicks(3972), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Katelin.Spencer15@gmail.com", "Misty Dickens", "411-519-9698" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "51984 Hugh Parkway, New Cecilemouth, Mauritania", new DateTime(1992, 12, 21, 21, 1, 27, 120, DateTimeKind.Utc).AddTicks(5527), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Roberta19@yahoo.com", "Garth Schimmel", "654-808-3328" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9361 O'Connell Parkways, Port Ezekiel, Kenya", new DateTime(1948, 5, 28, 0, 50, 16, 581, DateTimeKind.Utc).AddTicks(3360), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Freeda12@yahoo.com", "Sigurd Morissette", "457-435-0578" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "65981 Nickolas Inlet, North Demarcus, Tuvalu", new DateTime(1995, 1, 18, 12, 24, 31, 776, DateTimeKind.Utc).AddTicks(6074), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Bridie_Jast18@hotmail.com", "Major Lueilwitz", "738-665-1546" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "06212 Frederique Estate, Lake Joanieport, India", new DateTime(1982, 6, 20, 20, 57, 11, 672, DateTimeKind.Utc).AddTicks(7665), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Frank.Gutmann36@gmail.com", "Pietro Kessler", "979-761-4335" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3230 Mertz Ville, West Laila, Gambia", new DateTime(1991, 10, 21, 12, 0, 33, 195, DateTimeKind.Utc).AddTicks(4409), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Noble30@gmail.com", "Mathias O'Kon", "933-456-2358" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "34496 Zboncak Rue, Hermistonport, Dominica", new DateTime(1995, 12, 14, 21, 53, 49, 310, DateTimeKind.Utc).AddTicks(1886), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Irving_Altenwerth@yahoo.com", "Queen Toy", "473-403-4979" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2430 Langworth Lodge, Frederiqueburgh, Malawi", new DateTime(2002, 4, 2, 23, 24, 56, 283, DateTimeKind.Utc).AddTicks(7072), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Elliot_Kunde@hotmail.com", "Nakia Larson", "696-323-5839" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "461 Calista Walks, New Dustyfort, Mauritania", new DateTime(1950, 1, 18, 21, 29, 36, 464, DateTimeKind.Utc).AddTicks(2501), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Presley.Berge@yahoo.com", "Joanny Pouros", "502-232-9529" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2888 Golda Locks, Klockochester, Turkey", new DateTime(1952, 3, 20, 1, 47, 21, 841, DateTimeKind.Utc).AddTicks(3874), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Annabel_Hudson82@gmail.com", "Eryn Adams", "805-896-9808" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5051 Hahn Neck, Deontaestad, Niger", new DateTime(1986, 6, 3, 23, 6, 9, 530, DateTimeKind.Utc).AddTicks(2412), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Jerod.Dicki36@gmail.com", "Heath Ebert", "316-644-4830" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "75881 Hahn Burg, Carmellamouth, Jersey", new DateTime(1947, 8, 24, 6, 15, 49, 121, DateTimeKind.Utc).AddTicks(8067), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Eva.Jerde76@yahoo.com", "Ocie Wyman", "234-928-1021" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "44325 Janet Well, Lake Yazminton, Armenia", new DateTime(1975, 11, 5, 20, 59, 40, 828, DateTimeKind.Utc).AddTicks(3724), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Jamaal_Weber@hotmail.com", "Carlos Watsica", "324-588-9486" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "39285 Kasey Drives, Stevemouth, Democratic People's Republic of Korea", new DateTime(1996, 11, 6, 3, 21, 33, 740, DateTimeKind.Utc).AddTicks(4548), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Luigi.Gleason81@hotmail.com", "Werner Kunze", "571-201-6494" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "619 Rohan Viaduct, New Maximushaven, Guyana", new DateTime(1950, 2, 25, 10, 49, 50, 489, DateTimeKind.Utc).AddTicks(8737), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Maryam_DAmore90@yahoo.com", "Seamus Bosco", "782-754-1228" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "076 Maximillian Haven, Dollymouth, Rwanda", new DateTime(1983, 4, 9, 15, 45, 5, 503, DateTimeKind.Utc).AddTicks(250), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Nicklaus_Casper28@hotmail.com", "Wilbert Bode", "393-969-5254" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "763 Deckow Park, North Sydneeburgh, Jordan", new DateTime(1948, 4, 16, 22, 43, 1, 298, DateTimeKind.Utc).AddTicks(3711), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Scottie.Mueller47@gmail.com", "Sven Predovic", "481-664-5778" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7130 Ansel Rue, Cadeland, Virgin Islands, U.S.", new DateTime(1963, 7, 5, 11, 30, 30, 9, DateTimeKind.Utc).AddTicks(2864), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Nasir_Shanahan83@hotmail.com", "Coralie Dach", "537-584-4129" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "018 Thompson Loop, New Hettie, Rwanda", new DateTime(1982, 7, 24, 6, 58, 19, 410, DateTimeKind.Utc).AddTicks(8020), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Curt_Armstrong@hotmail.com", "Lilla Hansen", "923-272-2723" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "21027 Schuppe Glen, Maverickborough, Solomon Islands", new DateTime(2003, 12, 27, 13, 19, 54, 718, DateTimeKind.Utc).AddTicks(6885), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Greg47@yahoo.com", "Deja Bergstrom", "695-514-0267" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5499 Elna Spring, South Candido, Lao People's Democratic Republic", new DateTime(1972, 10, 9, 22, 57, 17, 267, DateTimeKind.Utc).AddTicks(3933), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Sydnee.Glover@gmail.com", "Rebeka Simonis", "274-271-3782" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "378 Beahan Ville, Runolfsdottirberg, Mauritius", new DateTime(1995, 9, 6, 18, 21, 53, 442, DateTimeKind.Utc).AddTicks(9838), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Reese.Botsford@hotmail.com", "Raleigh Hills", "204-277-8971" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "174 Bailey Wall, South Kenyachester, Jordan", new DateTime(1987, 7, 27, 0, 17, 47, 370, DateTimeKind.Utc).AddTicks(7763), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Coty.Hackett30@hotmail.com", "Frieda Simonis", "317-420-2010" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "09630 Jenifer Lodge, South Jakayla, Haiti", new DateTime(2003, 4, 13, 11, 41, 13, 258, DateTimeKind.Utc).AddTicks(1267), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Ryann.Ondricka@yahoo.com", "Lily Littel", "862-263-8997" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "37276 Herbert Corners, Beahanside, Mayotte", new DateTime(1985, 5, 1, 22, 27, 37, 363, DateTimeKind.Utc).AddTicks(7304), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Ahmad50@hotmail.com", "Eloise Bayer", "474-639-8120" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5349 Kertzmann Crossing, East Burnice, Bolivia", new DateTime(1965, 11, 30, 7, 18, 37, 980, DateTimeKind.Utc).AddTicks(3833), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Alysson_Zulauf26@gmail.com", "Marcelino Mertz", "663-838-0155" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8743 Kendrick Via, Larryshire, Ghana", new DateTime(1970, 6, 25, 1, 51, 12, 395, DateTimeKind.Utc).AddTicks(1143), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Mathias.Olson29@gmail.com", "Allan Padberg", "399-563-1352" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7111 Myrl Junction, Trystanside, Costa Rica", new DateTime(1960, 11, 4, 18, 57, 49, 366, DateTimeKind.Utc).AddTicks(8537), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Nedra.Kuhlman@hotmail.com", "Wellington Hamill", "775-563-2857" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "453 Libby Roads, Purdytown, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(1966, 11, 20, 5, 47, 44, 365, DateTimeKind.Utc).AddTicks(1311), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Amya.Sawayn37@yahoo.com", "Herminia Von", "872-285-0531" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "912 Stracke Forge, Port Ashly, Martinique", new DateTime(1946, 2, 6, 11, 52, 50, 292, DateTimeKind.Utc).AddTicks(1815), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Lilla31@yahoo.com", "Ronaldo Leffler", "523-958-3340" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "30588 Chauncey Ramp, Boehmton, United Kingdom", new DateTime(2003, 4, 18, 8, 8, 36, 264, DateTimeKind.Utc).AddTicks(6004), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Era.Klein37@gmail.com", "Madisyn VonRueden", "292-691-7585" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "728 Koepp Square, Johannfurt, Belgium", new DateTime(1994, 8, 7, 22, 42, 43, 21, DateTimeKind.Utc).AddTicks(9077), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Lucienne6@gmail.com", "Ashly Moen", "955-215-1972" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "21757 Kreiger Ramp, Dillanfort, Malaysia", new DateTime(1945, 3, 20, 13, 37, 12, 532, DateTimeKind.Utc).AddTicks(1538), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Bethany_OKeefe@hotmail.com", "Dianna Berge", "550-808-5328" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6636 Hackett Heights, South Deion, French Guiana", new DateTime(1989, 7, 10, 1, 39, 33, 606, DateTimeKind.Utc).AddTicks(3623), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Luciano_McKenzie@hotmail.com", "Aliya Altenwerth", "226-717-7387" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "964 O'Conner Hill, North Bret, Ghana", new DateTime(2003, 2, 13, 3, 13, 37, 522, DateTimeKind.Utc).AddTicks(3997), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Ericka.Rogahn87@gmail.com", "Reba Koch", "719-933-8356" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "553 Turcotte Parkways, Tadhaven, Guernsey", new DateTime(2002, 3, 23, 0, 54, 53, 635, DateTimeKind.Utc).AddTicks(5447), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Velva.Murazik96@yahoo.com", "Ella Schroeder", "680-755-6435" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "03712 Jeffery Manors, Curtfort, Bahrain", new DateTime(1959, 7, 3, 8, 56, 49, 501, DateTimeKind.Utc).AddTicks(63), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Murl44@hotmail.com", "Leonard Champlin", "270-777-3381" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "045 Feest Street, Mariannemouth, France", new DateTime(1945, 2, 16, 3, 47, 5, 640, DateTimeKind.Utc).AddTicks(4582), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Dwight_Konopelski69@yahoo.com", "Edmund Towne", "910-423-1776" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "051 Dach Burgs, Sylvesterfurt, Sweden", new DateTime(1977, 10, 25, 16, 4, 57, 695, DateTimeKind.Utc).AddTicks(7735), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Janae46@hotmail.com", "Warren Stiedemann", "914-635-8778" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "314 Schuster Run, West Dimitristad, Armenia", new DateTime(2003, 2, 27, 20, 21, 48, 109, DateTimeKind.Utc).AddTicks(8311), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Eloy_MacGyver@yahoo.com", "Mya Hills", "927-636-5622" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2611 Cathryn Stream, Nienowberg, Martinique", new DateTime(1984, 11, 26, 7, 43, 10, 343, DateTimeKind.Utc).AddTicks(34), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Gudrun_Harvey21@yahoo.com", "Deron Hegmann", "577-940-2117" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "87092 Fahey Shores, Batzshire, Armenia", new DateTime(1992, 5, 14, 22, 1, 41, 18, DateTimeKind.Utc).AddTicks(9128), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Bettye27@gmail.com", "Susie Dicki", "796-265-6704" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3641 Juliana River, Dorothealand, Cuba", new DateTime(1962, 5, 8, 9, 2, 0, 376, DateTimeKind.Utc).AddTicks(7775), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Howell2@hotmail.com", "Zackery Jacobi", "964-590-9521" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "86375 Wyman Mission, Boyerberg, Saint Vincent and the Grenadines", new DateTime(1955, 12, 24, 1, 53, 54, 851, DateTimeKind.Utc).AddTicks(6120), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Trey84@yahoo.com", "Anna Beer", "809-549-2477" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7362 VonRueden Terrace, Franeckibury, Palau", new DateTime(1972, 1, 17, 12, 23, 21, 290, DateTimeKind.Utc).AddTicks(5010), new DateTime(2022, 6, 13, 6, 48, 10, 160, DateTimeKind.Utc).AddTicks(7854), "Christiana_Gerlach@gmail.com", "Grady Hamill", "622-991-4555" });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 13, 13, 48, 10, 105, DateTimeKind.Local).AddTicks(5594));

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
