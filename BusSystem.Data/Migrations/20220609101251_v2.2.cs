using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class v22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Birthday", "created_date", "Email", "FullName", "IsDel", "modified_by", "modified_date", "Phone" },
                values: new object[,]
                {
                    { 1, "314 Mayert Hill, Port Orin, Honduras", new DateTime(1960, 10, 1, 9, 0, 4, 344, DateTimeKind.Utc).AddTicks(5482), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Mauricio_Boehm49@yahoo.com", "Alyce Hayes", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-303-783-2254 x59060" },
                    { 28, "079 Dominique Tunnel, North Samanta, Chile", new DateTime(1972, 3, 23, 14, 32, 2, 113, DateTimeKind.Utc).AddTicks(3693), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Evelyn.Kiehn@gmail.com", "Davon Kuhlman", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "893-322-6989 x419" },
                    { 29, "2375 Medhurst Ville, Port Larissa, Saint Vincent and the Grenadines", new DateTime(1989, 7, 21, 17, 20, 24, 123, DateTimeKind.Utc).AddTicks(4594), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Rossie_Heathcote46@yahoo.com", "Charlie Emard", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(300) 521-8998" },
                    { 30, "2244 Renner Ways, North Garnet, Norfolk Island", new DateTime(1949, 9, 29, 7, 33, 35, 632, DateTimeKind.Utc).AddTicks(863), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Herman37@hotmail.com", "Tracy Zieme", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-720-965-7057" },
                    { 31, "1355 Laverne Pine, Port Orlandbury, Philippines", new DateTime(1982, 8, 8, 22, 25, 20, 252, DateTimeKind.Utc).AddTicks(3235), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Jace_Jacobson51@gmail.com", "Maegan Jaskolski", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "447-504-4196 x76404" },
                    { 32, "046 Legros Ridges, Durganview, New Caledonia", new DateTime(1998, 1, 11, 20, 54, 4, 762, DateTimeKind.Utc).AddTicks(269), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Paolo31@hotmail.com", "Arnulfo Shanahan", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "309-804-0208" },
                    { 33, "6253 Walter Drive, Cormierville, Cote d'Ivoire", new DateTime(2003, 7, 9, 11, 4, 8, 907, DateTimeKind.Utc).AddTicks(1489), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Retta_Romaguera27@yahoo.com", "Edwina Gutkowski", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-509-977-0684 x8696" },
                    { 34, "6268 Russel Row, Allenshire, Eritrea", new DateTime(1976, 2, 23, 14, 44, 3, 292, DateTimeKind.Utc).AddTicks(9072), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Autumn.Auer@gmail.com", "Diego Lehner", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(638) 929-5535 x332" },
                    { 35, "6300 Agnes Roads, Augustusborough, Guernsey", new DateTime(1987, 6, 11, 14, 21, 12, 424, DateTimeKind.Utc).AddTicks(4042), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Lillian79@hotmail.com", "Elena Schamberger", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "936.371.6334 x67968" },
                    { 36, "311 Dooley Trail, Carrieburgh, Moldova", new DateTime(1949, 10, 23, 1, 22, 49, 301, DateTimeKind.Utc).AddTicks(3426), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Cayla80@hotmail.com", "Leda Mitchell", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(325) 800-7603" },
                    { 37, "07182 Rasheed Mountain, North Agnes, Honduras", new DateTime(1958, 8, 2, 16, 20, 46, 617, DateTimeKind.Utc).AddTicks(838), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Jadyn64@yahoo.com", "Genoveva Padberg", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(782) 517-1070 x72474" },
                    { 38, "9215 Prohaska Extensions, Dennisbury, China", new DateTime(1967, 11, 3, 6, 11, 19, 179, DateTimeKind.Utc).AddTicks(7549), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Nakia_Schmidt19@gmail.com", "Skylar Connelly", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-550-311-7855 x353" },
                    { 39, "16197 Kuvalis Mountains, Hildegardchester, Libyan Arab Jamahiriya", new DateTime(1963, 3, 15, 6, 35, 18, 273, DateTimeKind.Utc).AddTicks(6834), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Noelia.Price@gmail.com", "Roselyn Terry", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "907.752.9098" },
                    { 40, "6371 Feil Estate, Edgarfurt, Russian Federation", new DateTime(1944, 8, 8, 7, 58, 0, 618, DateTimeKind.Utc).AddTicks(5875), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Roosevelt_Lueilwitz@yahoo.com", "Ryan Ruecker", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-614-757-9960 x9866" },
                    { 41, "403 Bauch Flats, West Alphonso, Mauritius", new DateTime(1953, 10, 14, 13, 40, 54, 27, DateTimeKind.Utc).AddTicks(7296), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Jerald14@gmail.com", "Kathleen Sporer", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "517.646.4106" },
                    { 42, "9741 Satterfield Shore, Patton, Cape Verde", new DateTime(1963, 9, 8, 22, 53, 5, 534, DateTimeKind.Utc).AddTicks(5619), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Arnulfo_Kohler@yahoo.com", "Herminio Yundt", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "602-690-1373 x06939" },
                    { 43, "087 Doyle Prairie, South Osbaldoburgh, Guinea-Bissau", new DateTime(1963, 2, 17, 17, 17, 22, 713, DateTimeKind.Utc).AddTicks(738), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Alexis_Morissette@yahoo.com", "Bill Gutmann", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "368.847.8510" },
                    { 44, "584 Rylee Flats, South Rossport, Greenland", new DateTime(1999, 3, 16, 14, 56, 25, 705, DateTimeKind.Utc).AddTicks(3803), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Loren.Pacocha@yahoo.com", "Paxton Quigley", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-505-705-8923 x69709" },
                    { 45, "270 Laverne Course, South Erickburgh, Chad", new DateTime(1953, 12, 5, 14, 46, 5, 447, DateTimeKind.Utc).AddTicks(6142), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Mohammad56@yahoo.com", "Krystina Metz", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-666-892-7887 x2180" },
                    { 46, "58056 Josefa Hills, South Brianaberg, Thailand", new DateTime(1958, 3, 23, 23, 41, 35, 727, DateTimeKind.Utc).AddTicks(6911), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Ryan.Bahringer41@yahoo.com", "Bradly Senger", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(981) 542-2417 x6450" },
                    { 47, "127 Cole Forge, Roselynport, Papua New Guinea", new DateTime(1946, 2, 2, 7, 5, 46, 469, DateTimeKind.Utc).AddTicks(5514), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Gaetano_Reichel42@gmail.com", "Alvah Howell", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(647) 432-9848" },
                    { 48, "2471 Stark Lakes, South Lambertmouth, Macedonia", new DateTime(1975, 4, 15, 8, 30, 37, 228, DateTimeKind.Utc).AddTicks(68), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Ewell_Will@gmail.com", "Elias Runte", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "974.898.0243 x857" },
                    { 27, "86009 Schuster Trafficway, New Dannieborough, Australia", new DateTime(1993, 8, 2, 10, 45, 2, 245, DateTimeKind.Utc).AddTicks(1904), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Maye5@yahoo.com", "Kiana Kuphal", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(806) 493-7732 x72992" },
                    { 26, "8358 McLaughlin Isle, Lake Gardner, United States of America", new DateTime(1945, 8, 31, 18, 57, 51, 419, DateTimeKind.Utc).AddTicks(7760), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Frances.Bailey@gmail.com", "Caleigh Quitzon", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(831) 460-0525" },
                    { 25, "03119 Anastacio Falls, Mollieburgh, Dominican Republic", new DateTime(1962, 5, 10, 20, 9, 11, 237, DateTimeKind.Utc).AddTicks(3305), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Zelda_Sipes@yahoo.com", "Gordon Hilll", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(279) 214-0554" },
                    { 24, "710 O'Reilly Loaf, Naderfort, Bolivia", new DateTime(1947, 12, 6, 19, 59, 11, 981, DateTimeKind.Utc).AddTicks(5494), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Xzavier.Windler@hotmail.com", "Garland Beer", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "857-996-2305 x326" },
                    { 2, "35390 Teresa Plain, North Emilie, Saint Helena", new DateTime(2002, 5, 23, 18, 19, 39, 749, DateTimeKind.Utc).AddTicks(5664), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Bertha_Crona36@hotmail.com", "Marc Oberbrunner", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "989.204.8313 x0464" },
                    { 3, "39226 VonRueden Tunnel, North Verona, Kiribati", new DateTime(1996, 12, 18, 16, 30, 50, 844, DateTimeKind.Utc).AddTicks(7444), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Dustin97@hotmail.com", "Hailee Auer", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "715-469-0081" },
                    { 4, "8616 Collins Lock, Fletaside, Samoa", new DateTime(1982, 11, 30, 15, 57, 45, 517, DateTimeKind.Utc).AddTicks(5380), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Cory14@yahoo.com", "Kendall Leffler", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-599-943-2391" },
                    { 5, "8854 Swaniawski Mountain, Homenickside, Uzbekistan", new DateTime(1991, 9, 8, 3, 59, 19, 672, DateTimeKind.Utc).AddTicks(1800), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Dean_Greenfelder72@hotmail.com", "Estefania Lockman", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "316.257.1632 x44802" },
                    { 6, "65901 Keyshawn Turnpike, Alvenaton, Bulgaria", new DateTime(1992, 11, 27, 8, 10, 27, 673, DateTimeKind.Utc).AddTicks(866), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Katharina_Price@yahoo.com", "Jerod Sanford", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "979.215.8512" },
                    { 7, "34565 Jacobi Lane, Lawsonmouth, Dominica", new DateTime(1997, 7, 16, 13, 12, 12, 538, DateTimeKind.Utc).AddTicks(3448), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Peyton84@gmail.com", "Kayleigh Rogahn", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "606.757.0648 x9925" },
                    { 8, "43514 Vernon Ferry, Kiehnstad, Puerto Rico", new DateTime(1951, 4, 21, 0, 8, 22, 11, DateTimeKind.Utc).AddTicks(9522), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Michael.Zemlak70@hotmail.com", "Ahmed Jacobson", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "838.626.5626 x0851" },
                    { 9, "18607 Johnnie Mill, North Delbertburgh, New Caledonia", new DateTime(1965, 5, 5, 21, 44, 1, 132, DateTimeKind.Utc).AddTicks(8594), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Herman_Greenholt36@hotmail.com", "Trent Tillman", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(741) 223-7179" },
                    { 10, "677 Edna Ports, New Israel, Hong Kong", new DateTime(1947, 5, 3, 22, 48, 9, 653, DateTimeKind.Utc).AddTicks(5108), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Isabel84@gmail.com", "Ricky King", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-486-340-0623" },
                    { 11, "4161 Schiller Ports, Mohrmouth, Belgium", new DateTime(1970, 3, 19, 17, 16, 16, 64, DateTimeKind.Utc).AddTicks(8148), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Corene_Cummings97@gmail.com", "Leonel Gislason", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-820-637-2604 x38339" },
                    { 49, "7948 Kurtis Drive, Ziemannfort, Qatar", new DateTime(1955, 8, 12, 7, 38, 12, 386, DateTimeKind.Utc).AddTicks(28), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Jo18@yahoo.com", "Emmett Kuvalis", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "644-344-4777 x002" },
                    { 12, "450 Colt Way, Tevinside, Slovakia (Slovak Republic)", new DateTime(1975, 2, 26, 10, 24, 46, 196, DateTimeKind.Utc).AddTicks(7338), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Robbie.Nienow@yahoo.com", "Augustus Gaylord", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(627) 880-1329 x72119" },
                    { 14, "7405 Rosemary Trail, South Emmittfurt, Oman", new DateTime(1963, 3, 6, 2, 30, 39, 991, DateTimeKind.Utc).AddTicks(1720), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Afton_Mohr@gmail.com", "Eleanora Abbott", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-899-638-9141 x97553" },
                    { 15, "037 Sonny Pine, Jadeville, Guinea-Bissau", new DateTime(1955, 1, 25, 20, 1, 47, 585, DateTimeKind.Utc).AddTicks(3372), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Britney88@gmail.com", "Joshuah Fisher", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-659-958-0055" },
                    { 16, "502 Wyman Shore, Lucyland, Netherlands", new DateTime(1981, 2, 14, 18, 57, 4, 791, DateTimeKind.Utc).AddTicks(5322), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Odessa82@hotmail.com", "Armando Cartwright", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(520) 730-7405" },
                    { 17, "0131 River Pines, New Luigihaven, Saint Kitts and Nevis", new DateTime(1949, 11, 15, 12, 54, 15, 107, DateTimeKind.Utc).AddTicks(8948), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Nat.Bradtke@yahoo.com", "Tyreek Renner", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "541.674.9010 x6599" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Birthday", "created_date", "Email", "FullName", "IsDel", "modified_by", "modified_date", "Phone" },
                values: new object[,]
                {
                    { 18, "94951 Weissnat Lock, Chaimville, Russian Federation", new DateTime(1949, 1, 4, 13, 55, 19, 856, DateTimeKind.Utc).AddTicks(9005), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Timmothy.Wisoky87@gmail.com", "Zita Bechtelar", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-813-690-0098 x9579" },
                    { 19, "5878 Jason Overpass, North Kathryne, New Caledonia", new DateTime(1947, 9, 27, 5, 40, 34, 383, DateTimeKind.Utc).AddTicks(522), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Velda31@gmail.com", "Peggie Blanda", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "794-294-2726" },
                    { 20, "412 Dooley Unions, Janisport, Nepal", new DateTime(1947, 12, 17, 23, 59, 31, 925, DateTimeKind.Utc).AddTicks(9998), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Isaias_Abbott@yahoo.com", "Ursula Yundt", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-673-625-7503" },
                    { 21, "2007 Dan Spurs, North Dylanburgh, Moldova", new DateTime(1983, 7, 4, 8, 26, 56, 218, DateTimeKind.Utc).AddTicks(8040), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Joesph14@yahoo.com", "Bert Konopelski", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-435-554-6280" },
                    { 22, "67695 Rosalinda Fords, New Jevon, Bahamas", new DateTime(1965, 6, 27, 12, 49, 10, 166, DateTimeKind.Utc).AddTicks(7649), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Crystal16@gmail.com", "Sienna Mraz", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "307.962.8388 x01622" },
                    { 23, "7970 Legros Junction, Lake Hermann, Zambia", new DateTime(1951, 1, 4, 10, 57, 3, 415, DateTimeKind.Utc).AddTicks(5441), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Misael.OConner17@gmail.com", "Carissa Nolan", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-682-506-4487" },
                    { 13, "987 Baumbach River, Lake Kareem, Austria", new DateTime(1970, 7, 17, 5, 6, 55, 440, DateTimeKind.Utc).AddTicks(4013), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Ahmed50@gmail.com", "Beatrice Sipes", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(611) 981-3186 x865" },
                    { 50, "0485 Schmeler Trail, Auerburgh, Indonesia", new DateTime(1946, 5, 3, 2, 19, 31, 930, DateTimeKind.Utc).AddTicks(3345), new DateTime(2022, 6, 9, 10, 12, 50, 972, DateTimeKind.Utc).AddTicks(9842), "Kieran_Ernser@hotmail.com", "Willy Berge", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-881-272-2718 x95776" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Code", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FullName", "IsDel", "LockoutEnabled", "LockoutEnd", "Logo", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", 0, null, null, "502368fb-6758-4a1c-ac9a-662c56ab6824", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, 0, false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEKDMHs4Jh+QcAAZI/sPHPeGkGOjm4pMIYZy0JtFB8Jnaw+9YXAIirf720sktbm/gRQ==", null, false, "e0f9e06a-5062-46d9-a1c3-a9bd95233cd7", 0, false, 0, "admin" });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "id", "amount", "created_date", "IsDel", "modified_by", "modified_date", "user_id" },
                values: new object[] { 1, 100m, new DateTime(2022, 6, 9, 16, 8, 45, 649, DateTimeKind.Local).AddTicks(8562), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b74ddd14-6340-4840-95c2-db12554843e5" });
        }
    }
}
