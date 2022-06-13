using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class v991 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c64f8e52-12f9-4856-8498-7cff9308f288", "AQAAAAEAACcQAAAAEDDtiJiYF0XFs5EUEjAlc4+TpA9WcnMZwusDbgKaLS0jN1j/YaDOEWY587q/ZGuY/g==", "490bf01c-5618-45de-a311-eb57f2a304d0" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "6267 Dietrich Square, Mullerville, Barbados", new DateTime(1946, 8, 7, 21, 16, 59, 151, DateTimeKind.Utc).AddTicks(9232), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Jaime.Ferry@hotmail.com", "Spencer Bosco", "231-897-2260" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "148 Sammy Wells, East Zoe, Cuba", new DateTime(1950, 7, 31, 12, 12, 19, 502, DateTimeKind.Utc).AddTicks(6536), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Graham11@gmail.com", "Ottilie Kovacek", "505-382-6474" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1809 Kutch Islands, Lake Nikita, Syrian Arab Republic", new DateTime(1950, 9, 9, 13, 11, 58, 481, DateTimeKind.Utc).AddTicks(6925), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Blanca.Goyette93@hotmail.com", "Keon Johnston", "355-647-1925" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "382 Howe Glens, Port Cielo, Costa Rica", new DateTime(1977, 3, 13, 19, 5, 23, 18, DateTimeKind.Utc).AddTicks(9387), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Lucie_Walker@gmail.com", "Jakayla Bode", "206-911-0306" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "93488 Okuneva Mills, Corwinport, Greece", new DateTime(1984, 3, 29, 20, 31, 13, 403, DateTimeKind.Utc).AddTicks(3807), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Bridgette25@yahoo.com", "Yasmeen Tillman", "644-706-7339" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7765 Rylee Knolls, Pourosberg, Bangladesh", new DateTime(1951, 4, 16, 21, 4, 14, 193, DateTimeKind.Utc).AddTicks(3949), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Rosemarie.Schmidt86@gmail.com", "Ezequiel Franecki", "621-783-6819" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "4934 Wintheiser Greens, New Mario, American Samoa", new DateTime(1990, 8, 14, 17, 15, 57, 713, DateTimeKind.Utc).AddTicks(8923), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Carmella_Kuvalis66@yahoo.com", "Braden Swaniawski", "875-528-0018" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "153 Johns Walks, Ryleighview, Belize", new DateTime(2003, 1, 4, 19, 32, 24, 24, DateTimeKind.Utc).AddTicks(2933), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Cameron.Murazik38@yahoo.com", "Jesus Lynch", "441-509-4744" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "501 Silas Extensions, West Devante, United States Minor Outlying Islands", new DateTime(1950, 9, 14, 3, 28, 22, 740, DateTimeKind.Utc).AddTicks(3571), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Macie_Kuhic@gmail.com", "Sandy Crona", "574-311-3765" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "187 Prosacco Turnpike, Boylehaven, Ethiopia", new DateTime(2002, 6, 20, 23, 33, 6, 700, DateTimeKind.Utc).AddTicks(6238), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Cali2@hotmail.com", "Kirsten Klein", "407-906-4070" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "4011 Treutel Flat, New Trinity, Saint Vincent and the Grenadines", new DateTime(1987, 10, 31, 12, 14, 12, 250, DateTimeKind.Utc).AddTicks(9621), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Jacinthe99@gmail.com", "Kayli Kunde", "862-563-4712" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "61774 Cristopher Junctions, Port Owenburgh, Botswana", new DateTime(1948, 1, 23, 2, 2, 44, 294, DateTimeKind.Utc).AddTicks(1500), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Frank.Wolf@hotmail.com", "Rosie Koepp", "202-729-4869" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "973 Hackett Center, Dexterview, Kazakhstan", new DateTime(1961, 5, 26, 1, 2, 54, 666, DateTimeKind.Utc).AddTicks(3383), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Forest_Green@yahoo.com", "Thalia Graham", "829-484-4917" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "5367 Lera Springs, East Destiney, Uzbekistan", new DateTime(1959, 11, 14, 13, 7, 46, 358, DateTimeKind.Utc).AddTicks(5830), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Kellen_Lueilwitz20@gmail.com", "Loyal Waelchi", "416-700-8381" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1689 Toney Hollow, Cummingsbury, Bolivia", new DateTime(2004, 3, 28, 19, 7, 15, 461, DateTimeKind.Utc).AddTicks(4187), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Billy.Casper32@gmail.com", "Patience Beier", "353-534-5769" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "32417 Hettinger Oval, South Kenyonchester, Macao", new DateTime(2003, 5, 21, 5, 7, 21, 308, DateTimeKind.Utc).AddTicks(4464), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Nyasia_Fay46@hotmail.com", "Olen Nitzsche", "908-458-5919" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "769 Marcos Parks, West Chetton, Saint Vincent and the Grenadines", new DateTime(1964, 11, 25, 21, 55, 34, 999, DateTimeKind.Utc).AddTicks(3662), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Kiera_Roob79@hotmail.com", "Antonietta Leffler", "923-337-8391" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "32437 Kareem Passage, South Ari, Tunisia", new DateTime(1999, 7, 5, 2, 18, 29, 695, DateTimeKind.Utc).AddTicks(8483), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Stan23@hotmail.com", "Ludie Gleason", "365-471-3893" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "494 Reinger Port, Domenicport, Bulgaria", new DateTime(1948, 3, 25, 9, 59, 45, 643, DateTimeKind.Utc).AddTicks(6637), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Darrick_Klein@yahoo.com", "Adelbert Bartell", "594-901-4474" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "123 Fahey Street, South Valentinemouth, Malawi", new DateTime(1946, 6, 2, 17, 38, 9, 431, DateTimeKind.Utc).AddTicks(7145), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Jarod88@hotmail.com", "Abner Hayes", "898-300-3852" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3780 Meda Mill, East Mellieshire, Armenia", new DateTime(1989, 6, 29, 16, 46, 28, 198, DateTimeKind.Utc).AddTicks(635), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Anibal_Herman66@hotmail.com", "Carlee Oberbrunner", "605-317-1526" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2182 Cathrine Forks, Nienowshire, Equatorial Guinea", new DateTime(1951, 7, 5, 15, 50, 59, 924, DateTimeKind.Utc).AddTicks(3648), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Palma.Kemmer33@hotmail.com", "Angie Boehm", "492-921-3653" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "7808 Liliane View, West Noemiport, Botswana", new DateTime(1984, 8, 1, 4, 16, 47, 208, DateTimeKind.Utc).AddTicks(3553), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Patricia45@gmail.com", "Perry Lind", "588-740-9195" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "38701 Nicolas Row, East Laurine, Colombia", new DateTime(1957, 5, 16, 1, 20, 4, 883, DateTimeKind.Utc).AddTicks(9848), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Oswald.Casper21@gmail.com", "Felipa Wunsch", "447-231-9861" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "545 Esther Ridge, South Gage, Dominican Republic", new DateTime(1967, 11, 25, 15, 16, 50, 61, DateTimeKind.Utc).AddTicks(7235), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Ebony.Fisher79@gmail.com", "Esther Pagac", "776-303-8429" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "38063 Dietrich Locks, Ronaldoside, Oman", new DateTime(1990, 9, 7, 6, 59, 59, 184, DateTimeKind.Utc).AddTicks(4491), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Alyce.Stracke28@gmail.com", "Sydni Hilll", "446-703-0802" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8892 Aniya Center, West Makennaside, San Marino", new DateTime(1981, 2, 5, 10, 23, 49, 758, DateTimeKind.Utc).AddTicks(9353), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Mae.Hoppe@gmail.com", "Leonora Koepp", "865-205-3072" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1908 Gottlieb Crossing, North Caseyburgh, Saudi Arabia", new DateTime(1962, 4, 13, 4, 17, 39, 172, DateTimeKind.Utc).AddTicks(8664), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Vernie69@gmail.com", "Julien Cole", "969-475-9448" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "19533 Lowe Village, New Araceli, Republic of Korea", new DateTime(1991, 11, 10, 23, 42, 52, 288, DateTimeKind.Utc).AddTicks(3368), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Sadye84@gmail.com", "Brielle Bayer", "226-878-5514" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "138 Bruen Cliff, New Elissastad, Tanzania", new DateTime(1949, 10, 26, 13, 25, 47, 204, DateTimeKind.Utc).AddTicks(7177), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Eden_Hettinger@hotmail.com", "Krystal Wuckert", "420-889-0705" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "902 Melvin Courts, Nyahberg, Spain", new DateTime(1981, 5, 30, 7, 21, 51, 900, DateTimeKind.Utc).AddTicks(7956), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Luis_Rice23@yahoo.com", "Furman Howe", "382-527-9619" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "4273 Granville Trace, West Tia, Mexico", new DateTime(1972, 9, 24, 6, 10, 29, 509, DateTimeKind.Utc).AddTicks(353), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Lilliana35@yahoo.com", "Frederik Flatley", "931-380-4201" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "1173 Wintheiser Extension, Brendanside, United Kingdom", new DateTime(1999, 6, 26, 8, 49, 20, 46, DateTimeKind.Utc).AddTicks(5124), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Marcus33@hotmail.com", "Easter Welch", "564-809-4333" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "05251 Caterina Passage, Albertburgh, Antigua and Barbuda", new DateTime(1978, 6, 21, 3, 37, 24, 939, DateTimeKind.Utc).AddTicks(6349), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Providenci_Breitenberg75@gmail.com", "Caitlyn Donnelly", "816-994-0777" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "3619 Mraz Valley, Durganburgh, Mozambique", new DateTime(1996, 1, 2, 4, 15, 25, 94, DateTimeKind.Utc).AddTicks(7423), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Jay.Funk@gmail.com", "Green Denesik", "648-612-5655" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "56871 Smith Neck, Lake Abbie, Paraguay", new DateTime(1955, 11, 11, 2, 17, 7, 765, DateTimeKind.Utc).AddTicks(8881), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Ole.Johns@gmail.com", "Karlie Sauer", "385-606-7436" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "34966 Cruickshank Spring, West Cathrine, Northern Mariana Islands", new DateTime(1955, 9, 21, 4, 59, 8, 13, DateTimeKind.Utc).AddTicks(6129), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Gregoria.Lesch93@yahoo.com", "Alejandra Mueller", "283-728-8815" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2496 Towne Port, Kleintown, Jersey", new DateTime(1978, 11, 5, 18, 56, 47, 285, DateTimeKind.Utc).AddTicks(1244), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Samara83@yahoo.com", "Aracely Cronin", "863-849-8546" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "8572 Fredrick Haven, East Edythe, Eritrea", new DateTime(1993, 6, 16, 8, 2, 46, 719, DateTimeKind.Utc).AddTicks(934), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Saige.Schultz@hotmail.com", "Beatrice Koelpin", "662-331-9597" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "2000 Dorris Place, Deronmouth, Guadeloupe", new DateTime(1969, 4, 26, 12, 3, 49, 504, DateTimeKind.Utc).AddTicks(420), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Athena99@yahoo.com", "Milton Yundt", "765-924-1923" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "9926 Vidal Shoal, Klingshire, San Marino", new DateTime(1948, 12, 7, 12, 51, 41, 981, DateTimeKind.Utc).AddTicks(1433), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Vanessa_Renner31@gmail.com", "Else Mertz", "909-869-0743" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "66138 Willard Turnpike, Port Karolann, New Caledonia", new DateTime(1956, 2, 25, 8, 21, 19, 486, DateTimeKind.Utc).AddTicks(876), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Florencio52@yahoo.com", "Ramiro Pfeffer", "571-954-2781" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "101 Liza Point, Lake Zoratown, Japan", new DateTime(2000, 12, 25, 18, 44, 59, 146, DateTimeKind.Utc).AddTicks(9709), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Alphonso.Cronin31@yahoo.com", "Noemi Hansen", "327-441-4438" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "17210 Oscar Hills, Lake Yvette, Pakistan", new DateTime(1960, 10, 22, 9, 52, 32, 572, DateTimeKind.Utc).AddTicks(4407), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Adolf.Frami@yahoo.com", "Everette Dickinson", "716-555-1576" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "679 Johnson Cape, East Claudineton, Sri Lanka", new DateTime(1973, 1, 27, 12, 44, 24, 543, DateTimeKind.Utc).AddTicks(8934), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Noble.Huel9@hotmail.com", "Ofelia Douglas", "446-383-2792" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "34356 Christine River, South Desireeland, Somalia", new DateTime(1944, 10, 1, 0, 24, 10, 85, DateTimeKind.Utc).AddTicks(1473), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Hosea.Cartwright67@hotmail.com", "Jaren Langworth", "933-357-3997" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "0405 Kaden Cape, Bessietown, Guyana", new DateTime(1961, 11, 18, 8, 55, 11, 570, DateTimeKind.Utc).AddTicks(7024), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Domenic.Treutel@yahoo.com", "Ned Parisian", "762-428-3779" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "833 Hettinger Flats, West Athenaland, Ghana", new DateTime(2002, 8, 1, 9, 47, 40, 343, DateTimeKind.Utc).AddTicks(9535), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Warren13@gmail.com", "Lavonne Nienow", "270-531-2966" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "732 Schinner Gardens, South Cathrine, Armenia", new DateTime(1983, 9, 28, 4, 44, 45, 47, DateTimeKind.Utc).AddTicks(6202), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Jeromy56@gmail.com", "Fidel Rice", "558-851-6622" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Birthday", "created_date", "Email", "FullName", "Phone" },
                values: new object[] { "132 McLaughlin Ville, East Judgehaven, Panama", new DateTime(1975, 12, 3, 2, 10, 1, 673, DateTimeKind.Utc).AddTicks(6106), new DateTime(2022, 6, 13, 6, 46, 19, 455, DateTimeKind.Utc).AddTicks(3811), "Margaretta64@gmail.com", "Treva Stokes", "402-841-3371" });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 13, 13, 46, 19, 403, DateTimeKind.Local).AddTicks(2949));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
