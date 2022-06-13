using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
