using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class v999 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_TransactionHis_TransactionId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28856116-6cd7-460f-8333-95a9f3e6d6ab", "AQAAAAEAACcQAAAAELBbCrhNa7uwNoA2LE9UmVjyHXbVD6Opzt5EsjX/WLXYqfgd1lrZ80ZOne8SOYs2pA==", "da4859eb-72af-47da-ad92-ff4552946876" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "58114 Bechtelar Spring, Lake Dollyburgh, Marshall Islands", new DateTime(1983, 6, 22, 0, 9, 52, 876, DateTimeKind.Utc).AddTicks(607), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Paul39@hotmail.com", "Greta McCullough", "238-580-9072" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3976 Brown Coves, Donnellyland, Sierra Leone", new DateTime(1995, 7, 11, 18, 41, 37, 856, DateTimeKind.Utc).AddTicks(8589), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Dixie_Schultz89@yahoo.com", "Kali Gorczany", "365-321-9491" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2741 Sammie Square, Lake Darlene, Egypt", new DateTime(1988, 3, 22, 23, 43, 31, 83, DateTimeKind.Utc).AddTicks(1984), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Manley.McCullough@gmail.com", "Jamarcus Dibbert", "860-797-1894" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9645 Louvenia Fort, North Morganfort, Republic of Korea", new DateTime(1977, 7, 23, 5, 57, 25, 800, DateTimeKind.Utc).AddTicks(4990), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Vern89@gmail.com", "Jennyfer Sipes", "464-985-2163" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6869 Rhett Forest, New Mayramouth, Turkmenistan", new DateTime(1992, 3, 23, 20, 17, 3, 102, DateTimeKind.Utc).AddTicks(83), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Elza_Streich12@yahoo.com", "Rene Bahringer", "667-658-7748" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "03259 Erwin Plains, East Tyraside, Turks and Caicos Islands", new DateTime(1986, 6, 29, 7, 12, 50, 503, DateTimeKind.Utc).AddTicks(9984), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Paul_Ritchie@hotmail.com", "Dana Greenholt", "904-207-8094" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6766 Wiegand Court, Marilouview, Japan", new DateTime(1955, 8, 15, 4, 27, 10, 249, DateTimeKind.Utc).AddTicks(6250), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Shakira_Koepp13@yahoo.com", "Eloisa Jerde", "829-528-5341" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "370 Kris Centers, Schusterberg, Guinea-Bissau", new DateTime(1980, 8, 29, 13, 23, 51, 598, DateTimeKind.Utc).AddTicks(7586), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Addie95@yahoo.com", "Lionel Keeling", "671-260-2872" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6208 Fritsch Rest, East Lennyville, Virgin Islands, U.S.", new DateTime(1996, 4, 18, 19, 11, 10, 949, DateTimeKind.Utc).AddTicks(1651), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Kurtis.Powlowski19@hotmail.com", "Bud Kemmer", "656-662-4216" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "849 Kohler Curve, North Jeniferhaven, Chad", new DateTime(1944, 10, 5, 13, 57, 34, 969, DateTimeKind.Utc).AddTicks(2034), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Stanton1@yahoo.com", "Jeanne Wilkinson", "425-893-5037" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "434 Okuneva Garden, Kovacekborough, Burundi", new DateTime(1980, 8, 1, 23, 11, 10, 783, DateTimeKind.Utc).AddTicks(7251), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Mae_Kshlerin@gmail.com", "Santiago Muller", "686-811-2171" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "15334 Jordy Branch, Lake Chelseahaven, Malawi", new DateTime(1998, 11, 18, 8, 26, 12, 74, DateTimeKind.Utc).AddTicks(9139), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Seth46@gmail.com", "Katelynn Rutherford", "807-385-5316" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0492 Vada Trail, North Odatown, Jamaica", new DateTime(1989, 6, 24, 15, 22, 40, 743, DateTimeKind.Utc).AddTicks(5957), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Cletus.Wilkinson43@yahoo.com", "Dexter Towne", "401-371-6992" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "28211 Gussie Crossroad, Arnoburgh, Palau", new DateTime(1978, 9, 17, 12, 39, 9, 922, DateTimeKind.Utc).AddTicks(41), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Wilfred71@gmail.com", "Savanah Satterfield", "872-518-0989" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "106 Era Stravenue, East Dorthyland, Niger", new DateTime(1949, 2, 7, 14, 42, 57, 214, DateTimeKind.Utc).AddTicks(5953), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Bertrand98@hotmail.com", "Elvera Zieme", "819-253-2232" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "514 Stark Greens, Cartwrightmouth, Netherlands", new DateTime(1964, 6, 15, 3, 3, 45, 331, DateTimeKind.Utc).AddTicks(3441), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Maci97@gmail.com", "Stevie Jenkins", "940-359-0059" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2005 Odell Courts, Lerafort, China", new DateTime(1964, 4, 12, 7, 23, 51, 389, DateTimeKind.Utc).AddTicks(697), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Juanita69@yahoo.com", "Lexi Tillman", "632-279-1367" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "480 Hyatt Circles, South Brandyn, Italy", new DateTime(1976, 11, 18, 23, 46, 3, 381, DateTimeKind.Utc).AddTicks(4383), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Marcelo.Shields55@yahoo.com", "Deborah Ankunding", "820-473-2489" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "22403 Kuhlman Villages, East Austin, Uzbekistan", new DateTime(1949, 5, 13, 3, 34, 28, 994, DateTimeKind.Utc).AddTicks(4787), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Bobbie51@hotmail.com", "Savion King", "347-388-1089" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "07550 Cole Villages, West Ada, Albania", new DateTime(1950, 2, 5, 15, 11, 16, 48, DateTimeKind.Utc).AddTicks(3447), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Jacques_Koepp@hotmail.com", "Allen Buckridge", "620-487-6012" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "78057 Bahringer Crescent, Creminmouth, Anguilla", new DateTime(1959, 7, 5, 14, 23, 38, 729, DateTimeKind.Utc).AddTicks(5646), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Wallace.Greenfelder@hotmail.com", "Kyle Brekke", "641-577-2246" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8766 Santiago Gardens, North Selmer, Israel", new DateTime(1996, 12, 31, 21, 10, 37, 821, DateTimeKind.Utc).AddTicks(3287), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Reva.Abbott82@yahoo.com", "Jannie Hand", "748-365-2356" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8505 Hills Via, Ritchieburgh, Greenland", new DateTime(1967, 8, 24, 2, 14, 38, 230, DateTimeKind.Utc).AddTicks(6091), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Marcus.Huels@hotmail.com", "Keshawn Thompson", "766-628-2276" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "498 Lazaro Stravenue, East Aftonberg, Sierra Leone", new DateTime(1976, 10, 27, 14, 43, 20, 32, DateTimeKind.Utc).AddTicks(956), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Keira_Barton99@gmail.com", "Erich Dach", "293-569-4476" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "092 Langworth Creek, South Armando, Iceland", new DateTime(1972, 12, 20, 16, 1, 3, 967, DateTimeKind.Utc).AddTicks(3562), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Richmond_Russel@yahoo.com", "Rickie Kemmer", "303-916-8898" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0774 Krystel Well, Lake Edgardomouth, Latvia", new DateTime(1984, 11, 12, 14, 39, 40, 593, DateTimeKind.Utc).AddTicks(9512), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Rashawn72@yahoo.com", "Sylvan Kub", "848-239-5062" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "947 Libby Wall, Port Cordieville, Belarus", new DateTime(1955, 8, 11, 21, 2, 11, 646, DateTimeKind.Utc).AddTicks(8136), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Ludie5@hotmail.com", "Alfonzo Bradtke", "816-709-5204" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "175 Walsh Port, Schmelerbury, Poland", new DateTime(1950, 2, 21, 17, 27, 18, 960, DateTimeKind.Utc).AddTicks(5333), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Elna.Schulist@hotmail.com", "Matteo Batz", "932-824-1226" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "13815 Stephon Burgs, Opalville, Venezuela", new DateTime(1987, 5, 12, 10, 55, 26, 275, DateTimeKind.Utc).AddTicks(2438), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Mortimer_Emmerich73@yahoo.com", "Jaeden Pfeffer", "996-697-3738" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8146 Gordon Alley, West Carymouth, Andorra", new DateTime(1985, 10, 31, 17, 25, 57, 764, DateTimeKind.Utc).AddTicks(5993), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Maximillia94@gmail.com", "Aric Boehm", "847-932-0491" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "073 Lang Crossing, Damianland, Tajikistan", new DateTime(1996, 7, 15, 2, 26, 52, 567, DateTimeKind.Utc).AddTicks(9599), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Berneice.Wilkinson@hotmail.com", "Omari Renner", "271-832-0407" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8089 Marianne Port, Rogeliochester, Honduras", new DateTime(1972, 9, 17, 1, 5, 34, 89, DateTimeKind.Utc).AddTicks(2705), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Kathleen.McGlynn@hotmail.com", "Oscar Olson", "270-299-3374" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6412 Reinger Plains, Millerberg, Italy", new DateTime(1948, 3, 4, 16, 10, 16, 179, DateTimeKind.Utc).AddTicks(7610), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Nat.Schmitt@gmail.com", "Milan Bergstrom", "866-557-3262" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "48291 Tromp Course, Port Chad, Democratic People's Republic of Korea", new DateTime(1970, 10, 4, 5, 55, 34, 214, DateTimeKind.Utc).AddTicks(1360), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Andreanne_Will@yahoo.com", "Judd Gerhold", "586-929-3023" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "092 Valentina Trail, Cormiermouth, Philippines", new DateTime(1950, 1, 15, 12, 40, 50, 369, DateTimeKind.Utc).AddTicks(1069), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Jimmy74@hotmail.com", "Olen Stroman", "369-783-3861" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "4167 Lillie Estates, North Glendamouth, Djibouti", new DateTime(1976, 10, 9, 17, 22, 41, 231, DateTimeKind.Utc).AddTicks(8282), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Nora.Koelpin@gmail.com", "Claudia Schamberger", "810-527-8959" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "26095 Tracey Hollow, Dickichester, Cuba", new DateTime(1980, 2, 14, 17, 54, 9, 600, DateTimeKind.Utc).AddTicks(1633), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Salvador18@yahoo.com", "Grayce Rohan", "895-243-3462" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "58484 Favian Course, West Johathanside, Guadeloupe", new DateTime(2002, 2, 27, 11, 24, 54, 208, DateTimeKind.Utc).AddTicks(9322), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Cesar_Bogisich@gmail.com", "Amber Sauer", "302-954-0913" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5336 Shaun Causeway, West Pattie, Namibia", new DateTime(2002, 8, 4, 18, 44, 49, 534, DateTimeKind.Utc).AddTicks(2737), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Walker51@yahoo.com", "Maybelle Kulas", "394-722-0508" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9126 Hansen Island, Virginieberg, Tanzania", new DateTime(1967, 1, 8, 18, 35, 58, 957, DateTimeKind.Utc).AddTicks(7723), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Marcella.MacGyver59@gmail.com", "Keara Pacocha", "257-821-1590" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7101 Dewayne Spurs, Swiftbury, Russian Federation", new DateTime(1964, 1, 29, 11, 1, 41, 621, DateTimeKind.Utc).AddTicks(4276), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Marcelo_Beatty@yahoo.com", "Dolly Mayert", "396-739-0017" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3988 Calista Field, Abnerbury, Cote d'Ivoire", new DateTime(1949, 3, 11, 17, 53, 30, 435, DateTimeKind.Utc).AddTicks(961), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Amelie.Mitchell@gmail.com", "Keshaun Graham", "601-681-0927" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3533 Fritsch Valley, South Augustbury, Rwanda", new DateTime(1971, 9, 30, 20, 4, 1, 230, DateTimeKind.Utc).AddTicks(652), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Genesis.Simonis54@yahoo.com", "Madelyn Wunsch", "465-235-0147" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "270 O'Conner Ramp, East Janiya, Barbados", new DateTime(1945, 12, 1, 2, 21, 22, 635, DateTimeKind.Utc).AddTicks(3570), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Audrey_Marvin@hotmail.com", "Brooks Douglas", "524-895-8657" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0777 Sienna Ports, Eddieborough, Cote d'Ivoire", new DateTime(1994, 7, 2, 16, 24, 42, 719, DateTimeKind.Utc).AddTicks(4237), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Lily.McCullough45@yahoo.com", "Jermain Conn", "623-893-7279" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "00088 Bernadine Ridges, Starkview, Sudan", new DateTime(1991, 1, 16, 16, 39, 26, 323, DateTimeKind.Utc).AddTicks(2236), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Adeline88@hotmail.com", "Maribel Veum", "460-219-8324" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "4946 Adams Unions, New Madison, United States Minor Outlying Islands", new DateTime(1980, 9, 14, 23, 3, 10, 386, DateTimeKind.Utc).AddTicks(7448), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Camren23@hotmail.com", "Wade Rempel", "675-855-1971" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "028 Tito Corners, Emilianostad, Egypt", new DateTime(1947, 3, 29, 14, 37, 17, 11, DateTimeKind.Utc).AddTicks(3003), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Uriah.Collins74@yahoo.com", "Melisa Thompson", "324-381-7247" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "848 Delaney Shoals, Port Calefurt, Denmark", new DateTime(1989, 2, 26, 0, 49, 8, 66, DateTimeKind.Utc).AddTicks(7755), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Lonnie.Carter@yahoo.com", "Jaida Durgan", "444-761-4283" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "41132 Eloy Highway, New Fae, Aruba", new DateTime(1970, 5, 23, 23, 21, 10, 59, DateTimeKind.Utc).AddTicks(2538), new DateTime(2022, 6, 13, 6, 44, 49, 146, DateTimeKind.Utc).AddTicks(9943), "Lela11@gmail.com", "Richie Schmitt", "815-784-8125" });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 13, 13, 44, 49, 96, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_TransactionHis_TransactionId",
                table: "Orders",
                column: "TransactionId",
                principalTable: "TransactionHis",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_TransactionHis_TransactionId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_TransactionHis_TransactionId",
                table: "Orders",
                column: "TransactionId",
                principalTable: "TransactionHis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
