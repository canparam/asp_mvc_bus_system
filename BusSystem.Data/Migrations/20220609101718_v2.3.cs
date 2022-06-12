using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class v23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Code", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FullName", "IsDel", "LockoutEnabled", "LockoutEnd", "Logo", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", 0, null, null, "6e8f12b8-6446-48ae-9e6d-0328257b8e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, 0, false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEOyYwXqsaMcauYr7r7v9jcKw0ZnF5BRYA97bTIyyIAvlzMy/Zfl0CZyschSs4KvM9Q==", null, false, "7a32e9e3-e01d-4484-9b49-64ad1526c468", 0, false, 0, "admin" });

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

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "id", "amount", "created_date", "IsDel", "modified_by", "modified_date", "user_id" },
                values: new object[] { 1, 100m, new DateTime(2022, 6, 9, 17, 17, 17, 682, DateTimeKind.Local).AddTicks(6596), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b74ddd14-6340-4840-95c2-db12554843e5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "314 Mayert Hill, Port Orin, Honduras", new DateTime(1960, 10, 1, 9, 0, 4, 344, DateTimeKind.Utc).AddTicks(5482), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Mauricio_Boehm49@yahoo.com", "Alyce Hayes", "1-303-783-2254 x59060" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "35390 Teresa Plain, North Emilie, Saint Helena", new DateTime(2002, 5, 23, 18, 19, 39, 749, DateTimeKind.Utc).AddTicks(5664), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Bertha_Crona36@hotmail.com", "Marc Oberbrunner", "989.204.8313 x0464" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "39226 VonRueden Tunnel, North Verona, Kiribati", new DateTime(1996, 12, 18, 16, 30, 50, 844, DateTimeKind.Utc).AddTicks(7444), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Dustin97@hotmail.com", "Hailee Auer", "715-469-0081" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8616 Collins Lock, Fletaside, Samoa", new DateTime(1982, 11, 30, 15, 57, 45, 517, DateTimeKind.Utc).AddTicks(5380), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Cory14@yahoo.com", "Kendall Leffler", "1-599-943-2391" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8854 Swaniawski Mountain, Homenickside, Uzbekistan", new DateTime(1991, 9, 8, 3, 59, 19, 672, DateTimeKind.Utc).AddTicks(1800), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Dean_Greenfelder72@hotmail.com", "Estefania Lockman", "316.257.1632 x44802" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "65901 Keyshawn Turnpike, Alvenaton, Bulgaria", new DateTime(1992, 11, 27, 8, 10, 27, 673, DateTimeKind.Utc).AddTicks(866), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Katharina_Price@yahoo.com", "Jerod Sanford", "979.215.8512" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "34565 Jacobi Lane, Lawsonmouth, Dominica", new DateTime(1997, 7, 16, 13, 12, 12, 538, DateTimeKind.Utc).AddTicks(3448), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Peyton84@gmail.com", "Kayleigh Rogahn", "606.757.0648 x9925" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "43514 Vernon Ferry, Kiehnstad, Puerto Rico", new DateTime(1951, 4, 21, 0, 8, 22, 11, DateTimeKind.Utc).AddTicks(9522), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Michael.Zemlak70@hotmail.com", "Ahmed Jacobson", "838.626.5626 x0851" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "18607 Johnnie Mill, North Delbertburgh, New Caledonia", new DateTime(1965, 5, 5, 21, 44, 1, 132, DateTimeKind.Utc).AddTicks(8594), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Herman_Greenholt36@hotmail.com", "Trent Tillman", "(741) 223-7179" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "677 Edna Ports, New Israel, Hong Kong", new DateTime(1947, 5, 3, 22, 48, 9, 653, DateTimeKind.Utc).AddTicks(5108), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Isabel84@gmail.com", "Ricky King", "1-486-340-0623" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "4161 Schiller Ports, Mohrmouth, Belgium", new DateTime(1970, 3, 19, 17, 16, 16, 64, DateTimeKind.Utc).AddTicks(8148), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Corene_Cummings97@gmail.com", "Leonel Gislason", "1-820-637-2604 x38339" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "450 Colt Way, Tevinside, Slovakia (Slovak Republic)", new DateTime(1975, 2, 26, 10, 24, 46, 196, DateTimeKind.Utc).AddTicks(7338), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Robbie.Nienow@yahoo.com", "Augustus Gaylord", "(627) 880-1329 x72119" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "987 Baumbach River, Lake Kareem, Austria", new DateTime(1970, 7, 17, 5, 6, 55, 440, DateTimeKind.Utc).AddTicks(4013), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Ahmed50@gmail.com", "Beatrice Sipes", "(611) 981-3186 x865" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7405 Rosemary Trail, South Emmittfurt, Oman", new DateTime(1963, 3, 6, 2, 30, 39, 991, DateTimeKind.Utc).AddTicks(1720), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Afton_Mohr@gmail.com", "Eleanora Abbott", "1-899-638-9141 x97553" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "037 Sonny Pine, Jadeville, Guinea-Bissau", new DateTime(1955, 1, 25, 20, 1, 47, 585, DateTimeKind.Utc).AddTicks(3372), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Britney88@gmail.com", "Joshuah Fisher", "1-659-958-0055" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "502 Wyman Shore, Lucyland, Netherlands", new DateTime(1981, 2, 14, 18, 57, 4, 791, DateTimeKind.Utc).AddTicks(5322), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Odessa82@hotmail.com", "Armando Cartwright", "(520) 730-7405" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0131 River Pines, New Luigihaven, Saint Kitts and Nevis", new DateTime(1949, 11, 15, 12, 54, 15, 107, DateTimeKind.Utc).AddTicks(8948), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Nat.Bradtke@yahoo.com", "Tyreek Renner", "541.674.9010 x6599" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "94951 Weissnat Lock, Chaimville, Russian Federation", new DateTime(1949, 1, 4, 13, 55, 19, 856, DateTimeKind.Utc).AddTicks(9005), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Timmothy.Wisoky87@gmail.com", "Zita Bechtelar", "1-813-690-0098 x9579" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5878 Jason Overpass, North Kathryne, New Caledonia", new DateTime(1947, 9, 27, 5, 40, 34, 383, DateTimeKind.Utc).AddTicks(522), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Velda31@gmail.com", "Peggie Blanda", "794-294-2726" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "412 Dooley Unions, Janisport, Nepal", new DateTime(1947, 12, 17, 23, 59, 31, 925, DateTimeKind.Utc).AddTicks(9998), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Isaias_Abbott@yahoo.com", "Ursula Yundt", "1-673-625-7503" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2007 Dan Spurs, North Dylanburgh, Moldova", new DateTime(1983, 7, 4, 8, 26, 56, 218, DateTimeKind.Utc).AddTicks(8040), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Joesph14@yahoo.com", "Bert Konopelski", "1-435-554-6280" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "67695 Rosalinda Fords, New Jevon, Bahamas", new DateTime(1965, 6, 27, 12, 49, 10, 166, DateTimeKind.Utc).AddTicks(7649), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Crystal16@gmail.com", "Sienna Mraz", "307.962.8388 x01622" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7970 Legros Junction, Lake Hermann, Zambia", new DateTime(1951, 1, 4, 10, 57, 3, 415, DateTimeKind.Utc).AddTicks(5441), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Misael.OConner17@gmail.com", "Carissa Nolan", "1-682-506-4487" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "710 O'Reilly Loaf, Naderfort, Bolivia", new DateTime(1947, 12, 6, 19, 59, 11, 981, DateTimeKind.Utc).AddTicks(5494), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Xzavier.Windler@hotmail.com", "Garland Beer", "857-996-2305 x326" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "03119 Anastacio Falls, Mollieburgh, Dominican Republic", new DateTime(1962, 5, 10, 20, 9, 11, 237, DateTimeKind.Utc).AddTicks(3305), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Zelda_Sipes@yahoo.com", "Gordon Hilll", "(279) 214-0554" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8358 McLaughlin Isle, Lake Gardner, United States of America", new DateTime(1945, 8, 31, 18, 57, 51, 419, DateTimeKind.Utc).AddTicks(7760), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Frances.Bailey@gmail.com", "Caleigh Quitzon", "(831) 460-0525" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "86009 Schuster Trafficway, New Dannieborough, Australia", new DateTime(1993, 8, 2, 10, 45, 2, 245, DateTimeKind.Utc).AddTicks(1904), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Maye5@yahoo.com", "Kiana Kuphal", "(806) 493-7732 x72992" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "079 Dominique Tunnel, North Samanta, Chile", new DateTime(1972, 3, 23, 14, 32, 2, 113, DateTimeKind.Utc).AddTicks(3693), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Evelyn.Kiehn@gmail.com", "Davon Kuhlman", "893-322-6989 x419" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2375 Medhurst Ville, Port Larissa, Saint Vincent and the Grenadines", new DateTime(1989, 7, 21, 17, 20, 24, 123, DateTimeKind.Utc).AddTicks(4594), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Rossie_Heathcote46@yahoo.com", "Charlie Emard", "(300) 521-8998" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2244 Renner Ways, North Garnet, Norfolk Island", new DateTime(1949, 9, 29, 7, 33, 35, 632, DateTimeKind.Utc).AddTicks(863), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Herman37@hotmail.com", "Tracy Zieme", "1-720-965-7057" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1355 Laverne Pine, Port Orlandbury, Philippines", new DateTime(1982, 8, 8, 22, 25, 20, 252, DateTimeKind.Utc).AddTicks(3235), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Jace_Jacobson51@gmail.com", "Maegan Jaskolski", "447-504-4196 x76404" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "046 Legros Ridges, Durganview, New Caledonia", new DateTime(1998, 1, 11, 20, 54, 4, 762, DateTimeKind.Utc).AddTicks(269), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Paolo31@hotmail.com", "Arnulfo Shanahan", "309-804-0208" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6253 Walter Drive, Cormierville, Cote d'Ivoire", new DateTime(2003, 7, 9, 11, 4, 8, 907, DateTimeKind.Utc).AddTicks(1489), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Retta_Romaguera27@yahoo.com", "Edwina Gutkowski", "1-509-977-0684 x8696" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6268 Russel Row, Allenshire, Eritrea", new DateTime(1976, 2, 23, 14, 44, 3, 292, DateTimeKind.Utc).AddTicks(9072), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Autumn.Auer@gmail.com", "Diego Lehner", "(638) 929-5535 x332" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6300 Agnes Roads, Augustusborough, Guernsey", new DateTime(1987, 6, 11, 14, 21, 12, 424, DateTimeKind.Utc).AddTicks(4042), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Lillian79@hotmail.com", "Elena Schamberger", "936.371.6334 x67968" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "311 Dooley Trail, Carrieburgh, Moldova", new DateTime(1949, 10, 23, 1, 22, 49, 301, DateTimeKind.Utc).AddTicks(3426), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Cayla80@hotmail.com", "Leda Mitchell", "(325) 800-7603" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "07182 Rasheed Mountain, North Agnes, Honduras", new DateTime(1958, 8, 2, 16, 20, 46, 617, DateTimeKind.Utc).AddTicks(838), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Jadyn64@yahoo.com", "Genoveva Padberg", "(782) 517-1070 x72474" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9215 Prohaska Extensions, Dennisbury, China", new DateTime(1967, 11, 3, 6, 11, 19, 179, DateTimeKind.Utc).AddTicks(7549), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Nakia_Schmidt19@gmail.com", "Skylar Connelly", "1-550-311-7855 x353" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "16197 Kuvalis Mountains, Hildegardchester, Libyan Arab Jamahiriya", new DateTime(1963, 3, 15, 6, 35, 18, 273, DateTimeKind.Utc).AddTicks(6834), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Noelia.Price@gmail.com", "Roselyn Terry", "907.752.9098" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6371 Feil Estate, Edgarfurt, Russian Federation", new DateTime(1944, 8, 8, 7, 58, 0, 618, DateTimeKind.Utc).AddTicks(5875), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Roosevelt_Lueilwitz@yahoo.com", "Ryan Ruecker", "1-614-757-9960 x9866" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "403 Bauch Flats, West Alphonso, Mauritius", new DateTime(1953, 10, 14, 13, 40, 54, 27, DateTimeKind.Utc).AddTicks(7296), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Jerald14@gmail.com", "Kathleen Sporer", "517.646.4106" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9741 Satterfield Shore, Patton, Cape Verde", new DateTime(1963, 9, 8, 22, 53, 5, 534, DateTimeKind.Utc).AddTicks(5619), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Arnulfo_Kohler@yahoo.com", "Herminio Yundt", "602-690-1373 x06939" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "087 Doyle Prairie, South Osbaldoburgh, Guinea-Bissau", new DateTime(1963, 2, 17, 17, 17, 22, 713, DateTimeKind.Utc).AddTicks(738), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Alexis_Morissette@yahoo.com", "Bill Gutmann", "368.847.8510" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "584 Rylee Flats, South Rossport, Greenland", new DateTime(1999, 3, 16, 14, 56, 25, 705, DateTimeKind.Utc).AddTicks(3803), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Loren.Pacocha@yahoo.com", "Paxton Quigley", "1-505-705-8923 x69709" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "270 Laverne Course, South Erickburgh, Chad", new DateTime(1953, 12, 5, 14, 46, 5, 447, DateTimeKind.Utc).AddTicks(6142), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Mohammad56@yahoo.com", "Krystina Metz", "1-666-892-7887 x2180" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "58056 Josefa Hills, South Brianaberg, Thailand", new DateTime(1958, 3, 23, 23, 41, 35, 727, DateTimeKind.Utc).AddTicks(6911), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Ryan.Bahringer41@yahoo.com", "Bradly Senger", "(981) 542-2417 x6450" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "127 Cole Forge, Roselynport, Papua New Guinea", new DateTime(1946, 2, 2, 7, 5, 46, 469, DateTimeKind.Utc).AddTicks(5514), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Gaetano_Reichel42@gmail.com", "Alvah Howell", "(647) 432-9848" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2471 Stark Lakes, South Lambertmouth, Macedonia", new DateTime(1975, 4, 15, 8, 30, 37, 228, DateTimeKind.Utc).AddTicks(68), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Ewell_Will@gmail.com", "Elias Runte", "974.898.0243 x857" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7948 Kurtis Drive, Ziemannfort, Qatar", new DateTime(1955, 8, 12, 7, 38, 12, 386, DateTimeKind.Utc).AddTicks(28), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Jo18@yahoo.com", "Emmett Kuvalis", "644-344-4777 x002" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0485 Schmeler Trail, Auerburgh, Indonesia", new DateTime(1946, 5, 3, 2, 19, 31, 930, DateTimeKind.Utc).AddTicks(3345), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Kieran_Ernser@hotmail.com", "Willy Berge", "1-881-272-2718 x95776" });
        }
    }
}
