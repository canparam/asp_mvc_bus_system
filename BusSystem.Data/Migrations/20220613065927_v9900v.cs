using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class v9900v : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransacionId",
                table: "Orders",
                newName: "TransactionId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "644aab66-6f26-451b-a636-e21e92e1384b", "AQAAAAEAACcQAAAAEJ3R4A99YnH2ntFMPmCwsd2m3wCJ/lL0PVBpFAdD87SQ9LbMaoYEQytBGih7/P6kJQ==", "d060a972-7ab7-4bf1-a475-f10f8a258990" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1997 Wisoky Village, West Robynmouth, Lebanon", new DateTime(1950, 1, 10, 13, 31, 12, 128, DateTimeKind.Utc).AddTicks(7936), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Nora_Marks@hotmail.com", "Delbert Raynor", "915-750-7230" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "74240 Ernestina Centers, North Otiliaville, France", new DateTime(1970, 1, 5, 21, 15, 28, 990, DateTimeKind.Utc).AddTicks(547), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Baylee89@hotmail.com", "Audrey Crona", "553-704-9475" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "70133 Cynthia Pass, Marvinland, Seychelles", new DateTime(1985, 1, 24, 19, 31, 3, 513, DateTimeKind.Utc).AddTicks(907), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Breanne94@hotmail.com", "Norbert Berge", "944-479-9257" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "33300 Dare Turnpike, Allisonfort, Vietnam", new DateTime(1989, 3, 7, 21, 17, 2, 115, DateTimeKind.Utc).AddTicks(6859), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Bryce40@gmail.com", "Nicholas Kohler", "419-859-4677" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1879 Barrett Extensions, Swaniawskiside, Saint Barthelemy", new DateTime(1981, 6, 21, 19, 54, 26, 291, DateTimeKind.Utc).AddTicks(7324), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Nikki.Rath33@yahoo.com", "Llewellyn McDermott", "515-486-5987" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "109 Ephraim Station, South Jamison, Grenada", new DateTime(1947, 10, 5, 14, 2, 6, 503, DateTimeKind.Utc).AddTicks(6130), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Celine73@gmail.com", "Kamren Heathcote", "952-212-3525" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "89395 Julius Neck, Burniceshire, Ukraine", new DateTime(1951, 11, 1, 2, 27, 39, 685, DateTimeKind.Utc).AddTicks(3255), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Macey.Pollich@hotmail.com", "Katelynn Swaniawski", "784-370-8102" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "4632 Grant Via, Schadenborough, Luxembourg", new DateTime(1977, 10, 9, 11, 38, 28, 471, DateTimeKind.Utc).AddTicks(5977), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Chelsea_Hudson@gmail.com", "Trent McClure", "611-273-9749" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3582 Maximillian Mill, East Carolinachester, Guam", new DateTime(1973, 9, 6, 5, 38, 5, 306, DateTimeKind.Utc).AddTicks(5821), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Eloy_Runte@hotmail.com", "Patrick Halvorson", "645-432-8996" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7887 Mitchel Mills, Marielleport, Sweden", new DateTime(1945, 5, 3, 23, 3, 3, 497, DateTimeKind.Utc).AddTicks(2856), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Hermann46@yahoo.com", "Ciara Hoeger", "707-432-4324" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "274 Quitzon Court, Veldamouth, Virgin Islands, British", new DateTime(1947, 12, 6, 1, 16, 7, 602, DateTimeKind.Utc).AddTicks(1917), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Tiana83@yahoo.com", "Llewellyn Wiegand", "581-340-4875" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6023 Lucy Club, North Lydaside, Rwanda", new DateTime(1970, 2, 10, 16, 4, 59, 466, DateTimeKind.Utc).AddTicks(9176), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Roman72@gmail.com", "Ansel Heidenreich", "204-504-3722" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "25260 Etha Squares, East Brayan, Denmark", new DateTime(1988, 3, 25, 18, 12, 23, 708, DateTimeKind.Utc).AddTicks(9001), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Jammie98@hotmail.com", "Keanu Gottlieb", "322-446-5623" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "225 Marshall Junctions, Port Barretttown, Timor-Leste", new DateTime(1960, 1, 15, 20, 32, 44, 935, DateTimeKind.Utc).AddTicks(6031), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Robyn.Cormier@yahoo.com", "Abdul Blick", "950-499-1917" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "95321 Margarett Junction, Lake Dashawn, Ecuador", new DateTime(1991, 4, 25, 4, 23, 49, 313, DateTimeKind.Utc).AddTicks(2548), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Marie_Hegmann66@yahoo.com", "Stefanie Barrows", "280-263-7231" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "995 Jaren Circle, North Nashfort, Rwanda", new DateTime(1955, 8, 5, 6, 25, 38, 286, DateTimeKind.Utc).AddTicks(6742), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Muhammad75@hotmail.com", "Raul Gerhold", "931-595-6668" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2863 Goodwin Keys, Wiegandbury, Belgium", new DateTime(1981, 12, 31, 22, 37, 31, 645, DateTimeKind.Utc).AddTicks(7484), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Edythe.Thompson@gmail.com", "Bell Vandervort", "538-285-7084" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "15359 Myrtie Dam, Garrisonland, Italy", new DateTime(1947, 8, 23, 21, 26, 23, 527, DateTimeKind.Utc).AddTicks(2171), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Karlee_McDermott@gmail.com", "Donnie Goyette", "268-868-7661" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6813 Ed Vista, South Katarinaview, Afghanistan", new DateTime(1964, 2, 17, 6, 0, 5, 648, DateTimeKind.Utc).AddTicks(6781), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Lyda.OKon@yahoo.com", "Xavier Denesik", "228-552-1348" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6097 Leann Fall, South Sammiebury, Belgium", new DateTime(1981, 12, 23, 4, 32, 34, 154, DateTimeKind.Utc).AddTicks(2427), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Caitlyn2@yahoo.com", "Mara Jacobson", "616-733-7655" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "02956 Anderson Run, Ronaldoshire, Grenada", new DateTime(1974, 4, 14, 23, 24, 50, 126, DateTimeKind.Utc).AddTicks(4070), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Taryn20@yahoo.com", "Madison Kshlerin", "882-736-2884" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "380 Eleazar Mall, North Jairoside, Bulgaria", new DateTime(1988, 3, 1, 12, 13, 36, 708, DateTimeKind.Utc).AddTicks(7723), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Zoila_Steuber@yahoo.com", "Gina DuBuque", "246-482-3618" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "02956 Domenic Wells, East Oswaldville, Timor-Leste", new DateTime(1997, 12, 14, 1, 11, 9, 979, DateTimeKind.Utc).AddTicks(7175), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Vaughn_Gerlach64@gmail.com", "Gisselle Bradtke", "413-940-1672" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "964 Abernathy Prairie, West Cyrilburgh, Taiwan", new DateTime(1961, 3, 10, 1, 7, 42, 547, DateTimeKind.Utc).AddTicks(8159), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Devin55@yahoo.com", "Lorena West", "558-641-6518" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3022 Swift Extension, North Hershel, Uzbekistan", new DateTime(1964, 12, 25, 3, 5, 28, 366, DateTimeKind.Utc).AddTicks(6216), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Janelle_Rath5@hotmail.com", "Savanah Stoltenberg", "623-778-2804" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8195 Monica Burgs, Gottliebton, Kenya", new DateTime(1998, 12, 29, 11, 50, 14, 20, DateTimeKind.Utc).AddTicks(3328), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Renee86@hotmail.com", "Jennie Mann", "582-213-4030" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "214 Boehm Knolls, Lehnerside, Lao People's Democratic Republic", new DateTime(1962, 8, 10, 4, 59, 44, 545, DateTimeKind.Utc).AddTicks(6255), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Cassandre_Volkman47@yahoo.com", "Cleve Grant", "650-855-2245" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9055 Jaskolski Field, Lake Abdulside, Belize", new DateTime(1984, 4, 1, 13, 51, 29, 838, DateTimeKind.Utc).AddTicks(5301), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Maverick.Cormier@yahoo.com", "Nigel Sawayn", "564-638-9510" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "090 Benedict Corners, Gardnerside, Honduras", new DateTime(2000, 10, 29, 7, 56, 23, 654, DateTimeKind.Utc).AddTicks(3987), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Ashleigh68@yahoo.com", "Melvina Streich", "603-423-7103" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1024 Shirley Turnpike, Clydemouth, Poland", new DateTime(1997, 6, 2, 12, 15, 45, 125, DateTimeKind.Utc).AddTicks(2720), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Delmer_Jenkins51@yahoo.com", "Teresa Klein", "454-587-4639" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "16849 Kirlin Valleys, Port Angusport, Nigeria", new DateTime(1993, 12, 16, 7, 21, 38, 285, DateTimeKind.Utc).AddTicks(5211), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Jerel65@hotmail.com", "Velva MacGyver", "599-200-1738" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3218 Boyd Estate, West Delilahfurt, Holy See (Vatican City State)", new DateTime(1982, 5, 25, 11, 8, 58, 283, DateTimeKind.Utc).AddTicks(2390), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Dwight.Zulauf67@gmail.com", "Joe Ratke", "910-749-1410" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5141 Celestine Cape, Hagenesfurt, Palau", new DateTime(1984, 3, 2, 19, 36, 47, 267, DateTimeKind.Utc).AddTicks(7380), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Margarita.Baumbach@yahoo.com", "Audie Predovic", "907-373-0741" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "39247 Kris Ville, Maggioton, Heard Island and McDonald Islands", new DateTime(1975, 10, 19, 1, 40, 18, 517, DateTimeKind.Utc).AddTicks(573), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Bridgette.Gleichner@yahoo.com", "Malcolm Padberg", "704-716-2898" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "86312 Filomena Crescent, Greenfelderview, Kuwait", new DateTime(1966, 7, 16, 2, 56, 58, 701, DateTimeKind.Utc).AddTicks(1088), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Rosie.Ortiz@yahoo.com", "Nakia Hilll", "793-320-3200" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1225 Victor Coves, West Jazminfort, Singapore", new DateTime(1944, 9, 15, 1, 39, 51, 75, DateTimeKind.Utc).AddTicks(7823), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Anita.Towne24@yahoo.com", "Daron Ortiz", "621-781-0542" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "27425 Foster Radial, Scottieport, Moldova", new DateTime(1979, 5, 22, 20, 55, 57, 21, DateTimeKind.Utc).AddTicks(7002), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Meagan8@gmail.com", "Alexander Zemlak", "937-587-2927" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2362 Kris Ville, Wildermantown, Colombia", new DateTime(1982, 6, 30, 5, 8, 56, 518, DateTimeKind.Utc).AddTicks(3858), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Elmira_Ratke21@hotmail.com", "Chauncey Stamm", "207-993-4807" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "914 Yundt Alley, Lockmanfort, Zambia", new DateTime(1976, 1, 13, 6, 14, 20, 9, DateTimeKind.Utc).AddTicks(1054), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Johann93@yahoo.com", "Cindy Larkin", "499-473-4756" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5763 Kertzmann Plaza, Schambergerbury, Iran", new DateTime(1971, 2, 11, 0, 11, 22, 65, DateTimeKind.Utc).AddTicks(4514), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Augustine_Halvorson@gmail.com", "Porter Langworth", "904-885-4925" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2079 Tyrese Gateway, Griffinstad, Libyan Arab Jamahiriya", new DateTime(1974, 2, 28, 11, 12, 3, 122, DateTimeKind.Utc).AddTicks(4165), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Kattie31@yahoo.com", "Courtney Jacobson", "578-975-0882" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "16882 Donald Springs, Simonisburgh, Haiti", new DateTime(1976, 3, 11, 12, 11, 18, 664, DateTimeKind.Utc).AddTicks(2511), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Gina_Welch96@hotmail.com", "Kiley Metz", "447-775-4241" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "84534 Christiansen Ford, North Viviennemouth, Guernsey", new DateTime(2002, 6, 21, 22, 31, 40, 956, DateTimeKind.Utc).AddTicks(6245), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Ila_Wilkinson@gmail.com", "Juston Kassulke", "739-859-5163" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "11415 Tressie Stream, Littleborough, Saint Kitts and Nevis", new DateTime(1988, 8, 19, 10, 31, 17, 447, DateTimeKind.Utc).AddTicks(2789), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Hailey.Block19@gmail.com", "Brooklyn Hahn", "641-526-8847" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2288 Domingo Corner, Annaton, Slovakia (Slovak Republic)", new DateTime(1968, 12, 2, 5, 46, 20, 397, DateTimeKind.Utc).AddTicks(5), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Meggie_Hettinger39@hotmail.com", "Austin Becker", "986-267-6425" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9377 Dickens Turnpike, West Trinity, Iran", new DateTime(1981, 9, 14, 3, 10, 23, 333, DateTimeKind.Utc).AddTicks(7902), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Leopoldo51@yahoo.com", "Noe Schulist", "760-367-6636" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "068 Garfield Haven, South Oswald, Panama", new DateTime(1967, 8, 23, 5, 13, 43, 788, DateTimeKind.Utc).AddTicks(4245), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Santino39@hotmail.com", "Rasheed Mayer", "210-616-9384" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "01005 Runte Walk, West Ariane, Cook Islands", new DateTime(1979, 10, 7, 0, 10, 48, 460, DateTimeKind.Utc).AddTicks(7080), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Jaylin.Thiel35@gmail.com", "Dana Hackett", "924-727-6392" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8812 Schinner Summit, South Elsa, Samoa", new DateTime(1945, 11, 13, 22, 58, 38, 695, DateTimeKind.Utc).AddTicks(369), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Cordelia_Wolff54@hotmail.com", "Charles McDermott", "804-963-6256" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "260 Reynolds Row, East Ashlystad, Cote d'Ivoire", new DateTime(1949, 3, 9, 19, 9, 3, 25, DateTimeKind.Utc).AddTicks(8990), new DateTime(2022, 6, 13, 6, 59, 27, 56, DateTimeKind.Utc).AddTicks(6101), "Elissa.Thompson@hotmail.com", "Billie Harris", "267-414-2151" });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 13, 13, 59, 27, 3, DateTimeKind.Local).AddTicks(495));

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

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "Orders",
                newName: "TransacionId");

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
    }
}
