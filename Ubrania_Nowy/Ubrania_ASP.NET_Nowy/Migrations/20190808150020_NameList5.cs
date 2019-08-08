using Microsoft.EntityFrameworkCore.Migrations;

namespace Ubrania_ASP.NET_Nowy.Migrations
{
    public partial class NameList5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NamesLists",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Ada" },
                    { 383, "Nikodema" },
                    { 382, "Nika" },
                    { 381, "Nela" },
                    { 380, "Natasza" },
                    { 379, "Natalia" },
                    { 378, "Narcyza" },
                    { 377, "Najsława" },
                    { 376, "Najmiła" },
                    { 375, "Nadzieja" },
                    { 374, "Nadia" },
                    { 373, "Morzena" },
                    { 372, "Morzana" },
                    { 371, "Monika" },
                    { 370, "Mojmira" },
                    { 369, "Mirosława" },
                    { 368, "Mirołada" },
                    { 367, "Miroda" },
                    { 353, "Michalina" },
                    { 354, "Mieczysława" },
                    { 355, "Milena" },
                    { 356, "Milomira" },
                    { 357, "Miłosława" },
                    { 358, "Miłowita" },
                    { 384, "Nikola" },
                    { 359, "Minerwa" },
                    { 361, "Mira" },
                    { 362, "Mirabela" },
                    { 363, "Miranda" },
                    { 364, "Mirela" },
                    { 365, "Miriam" },
                    { 366, "Mirka" },
                    { 360, "Mina" },
                    { 352, "Melania" },
                    { 385, "Nikita" },
                    { 387, "Nina" },
                    { 418, "Polmira" },
                    { 417, "Pola" },
                    { 416, "Placyda" },
                    { 415, "Petronia" },
                    { 414, "Petronela" },
                    { 413, "Petra" },
                    { 412, "Pelagia" },
                    { 411, "Paulina" },
                    { 410, "Paula" },
                    { 409, "Patrycja" },
                    { 408, "Pamela" },
                    { 407, "Pabiana" },
                    { 406, "Olena" },
                    { 405, "Ożanna" },
                    { 404, "Otylia" },
                    { 403, "Ota" },
                    { 402, "Oriana" },
                    { 388, "Noemi" },
                    { 389, "Nora" },
                    { 390, "Norberta" },
                    { 391, "Norma" },
                    { 392, "Oda" },
                    { 393, "Odeta" },
                    { 386, "Nikoleta" },
                    { 394, "Odyla" },
                    { 396, "Oksana" },
                    { 397, "Oktawia" },
                    { 398, "Ola" },
                    { 399, "Olga" },
                    { 400, "Olimpia" },
                    { 401, "Oliwia" },
                    { 395, "Ofelia" },
                    { 419, "Przemysława" },
                    { 351, "Matylda" },
                    { 349, "Maryna" },
                    { 313, "Ludmiła" },
                    { 312, "Lucyna" },
                    { 311, "Lucjola" },
                    { 310, "Lucjana" },
                    { 309, "Luborada" },
                    { 308, "Lora" },
                    { 307, "Liwia" },
                    { 306, "Linda" },
                    { 305, "Liliana" },
                    { 304, "Lilia" },
                    { 303, "Ligia" },
                    { 302, "Lidia" },
                    { 301, "Leopolda" },
                    { 300, "Leonora" },
                    { 299, "Leoncja" },
                    { 298, "Leonarda" },
                    { 297, "Leona" },
                    { 283, "Kwiatosława" },
                    { 284, "Kwietosława" },
                    { 285, "Laila" },
                    { 286, "Lajla" },
                    { 287, "Lana" },
                    { 288, "Larisa" },
                    { 314, "Ludolfa" },
                    { 289, "Larysa" },
                    { 291, "Laura" },
                    { 292, "Laurenjca" },
                    { 293, "Lea" },
                    { 294, "Lejla" },
                    { 295, "Lena" },
                    { 296, "Leokadia" },
                    { 290, "Latifa" },
                    { 350, "Marzena" },
                    { 315, "Ludwika" },
                    { 317, "Luiza" },
                    { 348, "Maryla" },
                    { 347, "Maryja" },
                    { 346, "Martyna" },
                    { 345, "Marta" },
                    { 344, "Marlena" },
                    { 343, "Mariola" },
                    { 342, "Marika" },
                    { 341, "Marietta" },
                    { 340, "Marianna" },
                    { 339, "Mariam" },
                    { 338, "Maria" },
                    { 337, "Marcjanna" },
                    { 336, "Marcjana" },
                    { 335, "Marcelina" },
                    { 334, "Marcela" },
                    { 333, "Manuela" },
                    { 332, "Małgorzata" },
                    { 318, "Luna" },
                    { 319, "Lilianna" },
                    { 320, "Ładana" },
                    { 321, "Ładysława" },
                    { 322, "Łagoda" },
                    { 323, "Łucja" },
                    { 316, "Ludwina" },
                    { 324, "Macieja" },
                    { 326, "Magdalena" },
                    { 327, "Maja" },
                    { 328, "Maksa" },
                    { 329, "Maksyma" },
                    { 330, "Malina" },
                    { 331, "Malwina" },
                    { 325, "Magda" },
                    { 420, "Przybysława" },
                    { 421, "Rachela" },
                    { 422, "Ramona" },
                    { 524, "Wesna" },
                    { 523, "Weronika" },
                    { 522, "Wera" },
                    { 521, "Wanessa" },
                    { 520, "Wanda" },
                    { 519, "Waleria" },
                    { 518, "Walentyna" },
                    { 517, "Wacława" },
                    { 516, "Uta" },
                    { 515, "Urszula" },
                    { 514, "Unima" },
                    { 513, "Una" },
                    { 512, "Uma" },
                    { 511, "Ulryka" },
                    { 510, "Ulana" },
                    { 509, "Tessa" },
                    { 508, "Tulimira" },
                    { 494, "Tacjana" },
                    { 495, "Tadea" },
                    { 496, "Tamara" },
                    { 497, "Tatiana" },
                    { 498, "Tekla" },
                    { 499, "Telimena" },
                    { 525, "Wiara" },
                    { 500, "Teodora" },
                    { 502, "Teresa" },
                    { 503, "Tęgomira" },
                    { 504, "Tina" },
                    { 505, "Tolisława" },
                    { 506, "Tomiła" },
                    { 507, "Tomisława" },
                    { 501, "Teodozja" },
                    { 493, "Tabita" },
                    { 526, "Wielina" },
                    { 528, "Wierada" },
                    { 559, "Żużanna" },
                    { 558, "Żelisława" },
                    { 557, "Żanna" },
                    { 556, "Żaneta" },
                    { 555, "Żaklina" },
                    { 554, "Zyta" },
                    { 553, "Zygfryda" },
                    { 552, "Zwinisława" },
                    { 551, "Zuzanna" },
                    { 550, "Zoja" },
                    { 549, "Zofia" },
                    { 548, "Zenona" },
                    { 547, "Zenobia" },
                    { 546, "Zefiryna" },
                    { 545, "Zdzisława" },
                    { 544, "Zaira" },
                    { 543, "Zaida" },
                    { 529, "Wiesława" },
                    { 530, "Wiktoria" },
                    { 531, "Wilhelmina" },
                    { 532, "Wilma" },
                    { 533, "Wincentyna" },
                    { 534, "Wioleta" },
                    { 527, "Wiera" },
                    { 535, "Wirgilia" },
                    { 537, "Wisława" },
                    { 538, "Witosława" },
                    { 539, "Władysława" },
                    { 540, "Włodzimiera" },
                    { 541, "Wolimira" },
                    { 542, "Wrocisława" },
                    { 536, "Wirginia" },
                    { 492, "Świętosława" },
                    { 491, "Świętomira" },
                    { 490, "Świetlana" },
                    { 453, "Salma" },
                    { 452, "Safira" },
                    { 451, "Sabina" },
                    { 450, "Ryszarda" },
                    { 449, "Ruta" },
                    { 448, "Rudolfina" },
                    { 447, "Róża" },
                    { 446, "Rozwita" },
                    { 445, "Rozetta" },
                    { 444, "Rozamunda" },
                    { 443, "Rozalinda" },
                    { 442, "Rozalia" },
                    { 441, "Romualda" },
                    { 440, "Romana" },
                    { 439, "Roma" },
                    { 438, "Roksana" },
                    { 437, "Rodzisława" },
                    { 423, "Radmiła" },
                    { 424, "Radomiła" },
                    { 425, "Radomira" },
                    { 426, "Radosława" },
                    { 427, "Rafaela" },
                    { 428, "Rajmunda" },
                    { 454, "Saloma" },
                    { 429, "Rajna" },
                    { 431, "Rebeka" },
                    { 432, "Regina" },
                    { 433, "Remigia" },
                    { 434, "Renata" },
                    { 435, "Rita" },
                    { 436, "Roberta" },
                    { 430, "Raszyda" },
                    { 455, "Salomea" },
                    { 456, "Samanta" },
                    { 457, "Sandra" },
                    { 476, "Stella" },
                    { 477, "Sydney" },
                    { 478, "Strzeżymira" },
                    { 479, "Subisława" },
                    { 480, "Sulima" },
                    { 481, "Sulisława" },
                    { 475, "Stoisława" },
                    { 482, "Sybilla" },
                    { 484, "Sylwia" },
                    { 485, "Szarlota" },
                    { 486, "Szarlin" },
                    { 487, "Szarlina" },
                    { 488, "Szejma" },
                    { 489, "Szymona" },
                    { 483, "Sylwana" },
                    { 282, "Kunegunda" },
                    { 474, "Stela" },
                    { 472, "Stanisława" },
                    { 458, "Sara" },
                    { 459, "Sebastiana" },
                    { 460, "Selena" },
                    { 461, "Selma" },
                    { 462, "Serafina" },
                    { 463, "Seweryna" },
                    { 473, "Stefania" },
                    { 464, "Sędomira" },
                    { 466, "Sława" },
                    { 467, "Sławina" },
                    { 468, "Sławomira" },
                    { 469, "Sobiesława" },
                    { 470, "Sonia" },
                    { 471, "Stamira" },
                    { 465, "Sędzisława" },
                    { 560, "Żywia" },
                    { 281, "Ksenia" },
                    { 279, "Krzysztofa" },
                    { 102, "Czesława" },
                    { 101, "Cina" },
                    { 100, "Cinosława" },
                    { 99, "Ciesława" },
                    { 98, "Ciechosława" },
                    { 97, "Chwalisława" },
                    { 96, "Chociemira" },
                    { 95, "Cezaryna" },
                    { 94, "Cezaria" },
                    { 93, "Celina" },
                    { 92, "Celestyna" },
                    { 91, "Cecylia" },
                    { 90, "Brygida" },
                    { 89, "Brunhilda" },
                    { 88, "Bronisława" },
                    { 87, "Bromira" },
                    { 86, "Bożena" },
                    { 72, "Berta" },
                    { 73, "Betina" },
                    { 74, "Bianka" },
                    { 75, "Bibiana" },
                    { 76, "Blanka" },
                    { 77, "Błażena" },
                    { 103, "Dajmira" },
                    { 78, "Bogdana" },
                    { 80, "Boguchwała" },
                    { 81, "Bogumiła" },
                    { 82, "Bogusława" },
                    { 83, "Bojana" },
                    { 84, "Bolesława" },
                    { 85, "Bona" },
                    { 79, "Bogna" },
                    { 71, "Bernadeta" },
                    { 104, "Dagna" },
                    { 106, "Dalia" },
                    { 137, "Elżbieta" },
                    { 136, "Elwira" },
                    { 135, "Eliza" },
                    { 134, "Eleonora" },
                    { 133, "Edyta" },
                    { 132, "Edeltruda" },
                    { 131, "Dżesika" },
                    { 130, "Dżamila" },
                    { 129, "Dżanan" },
                    { 128, "Dyzma" },
                    { 127, "Dorota" },
                    { 126, "Dorosława" },
                    { 125, "Donata" },
                    { 124, "Dominika" },
                    { 123, "Domasława" },
                    { 122, "Dobiesława" },
                    { 121, "Dilara" },
                    { 107, "Dalila" },
                    { 108, "Dalmira" },
                    { 109, "Damroka" },
                    { 110, "Dana" },
                    { 111, "Daniela" },
                    { 112, "Danisława" },
                    { 105, "Dagmara" },
                    { 113, "Danuta" },
                    { 115, "Dargosława" },
                    { 116, "Daria" },
                    { 117, "Dąbrówka" },
                    { 118, "Delfina" },
                    { 119, "Delia" },
                    { 120, "Diana" },
                    { 114, "Dargomira" },
                    { 138, "Elmira" },
                    { 70, "Bernarda" },
                    { 68, "Beniamina" },
                    { 32, "Ana" },
                    { 31, "Amira" },
                    { 30, "Amina" },
                    { 29, "Amelia" },
                    { 28, "Amber" },
                    { 27, "Amanda" },
                    { 26, "Amalia" },
                    { 25, "Alojza" },
                    { 24, "Alina" },
                    { 23, "Alida" },
                    { 22, "Alicja" },
                    { 21, "Alfreda" },
                    { 20, "Aleksja" },
                    { 19, "Aleksandra" },
                    { 18, "Aleksa" },
                    { 17, "Aldona" },
                    { 16, "Albina" },
                    { 2, "Adamina" },
                    { 3, "Adela" },
                    { 4, "Adelajda" },
                    { 5, "Adriana" },
                    { 6, "Adrianna" },
                    { 7, "Agata" },
                    { 33, "Anastazja" },
                    { 8, "Agnieszka" },
                    { 10, "Afra" },
                    { 11, "Aida" },
                    { 12, "Aisza" },
                    { 13, "Ajna" },
                    { 14, "Alberta" },
                    { 15, "Albertyna" },
                    { 9, "Agrypina" },
                    { 69, "Berenika" },
                    { 34, "Andrea" },
                    { 36, "Andżelika" },
                    { 67, "Benedykta" },
                    { 66, "Beatryksa" },
                    { 65, "Beatrycze" },
                    { 64, "Beatrycja" },
                    { 63, "Beata" },
                    { 62, "Bartłomieja" },
                    { 61, "Barbara" },
                    { 60, "Balbina" },
                    { 59, "Babeta" },
                    { 58, "Aurora" },
                    { 57, "Aurelia" },
                    { 56, "Augustyna" },
                    { 55, "Augusta" },
                    { 54, "Atena" },
                    { 53, "Astryda" },
                    { 52, "Arnolda" },
                    { 51, "Arleta" },
                    { 37, "Aneta" },
                    { 38, "Angela" },
                    { 39, "Angelika" },
                    { 40, "Angelina" },
                    { 41, "Aniela" },
                    { 42, "Anita" },
                    { 35, "Andrzeja" },
                    { 43, "Anna" },
                    { 45, "Anzelma" },
                    { 46, "Apollona" },
                    { 47, "Apollina" },
                    { 48, "Apolonia" },
                    { 49, "Arabella" },
                    { 50, "Ariadna" },
                    { 44, "Antonina" },
                    { 139, "Emanuela" },
                    { 140, "Emilia" },
                    { 141, "Emina" },
                    { 243, "Józefina" },
                    { 242, "Józefa" },
                    { 241, "Jowita" },
                    { 240, "Jolanta" },
                    { 239, "Joanna" },
                    { 238, "Joachima" },
                    { 237, "Jaśmina" },
                    { 236, "Jasława" },
                    { 235, "Jarosława" },
                    { 234, "Jaromira" },
                    { 233, "Jaromiła" },
                    { 232, "Jarmiła" },
                    { 231, "Janina" },
                    { 230, "Jana" },
                    { 229, "Jago" },
                    { 228, "Jadwiga" },
                    { 227, "Izydora" },
                    { 213, "Ildefonsa" },
                    { 214, "Ilia" },
                    { 215, "Iliana" },
                    { 216, "Ilona" },
                    { 217, "Ilza" },
                    { 218, "Inga" },
                    { 244, "Judyta" },
                    { 219, "Ingeborga" },
                    { 221, "Irena" },
                    { 222, "Iryda" },
                    { 223, "Iwa" },
                    { 224, "Iwona" },
                    { 225, "Izabela" },
                    { 226, "Izolda" },
                    { 220, "Ingryda" },
                    { 212, "Iga" },
                    { 245, "Julia" },
                    { 247, "Julisława" },
                    { 278, "Krystyna" },
                    { 277, "Krystiana" },
                    { 276, "Koryna" },
                    { 275, "Kornelia" },
                    { 274, "Kordula" },
                    { 273, "Konstancja" },
                    { 272, "Klotylda" },
                    { 271, "Kleopatra" },
                    { 270, "Klementyna" },
                    { 269, "Klaudyna" },
                    { 268, "Klaudia" },
                    { 267, "Klarysa" },
                    { 266, "Klara" },
                    { 265, "Kira" },
                    { 264, "Kinga" },
                    { 263, "Kiliana" },
                    { 262, "Kiara" },
                    { 248, "Julita" },
                    { 249, "Justyna" },
                    { 250, "Juta" },
                    { 251, "Kaja" },
                    { 252, "Kalina" },
                    { 253, "Kamila" },
                    { 246, "Julianna" },
                    { 254, "Karima" },
                    { 256, "Karola" },
                    { 257, "Karolina" },
                    { 258, "Karyna" },
                    { 259, "Katarzyna" },
                    { 260, "Kasandra" },
                    { 261, "Kazimiera" },
                    { 255, "Karina" },
                    { 211, "Idzisława" },
                    { 210, "Idalia" },
                    { 209, "Idzia" },
                    { 172, "Gerarda" },
                    { 171, "Genowefa" },
                    { 170, "Gaja" },
                    { 169, "Gabriela" },
                    { 168, "Fryderyka" },
                    { 167, "Franciszka" },
                    { 166, "Floriana" },
                    { 165, "Florentyna" },
                    { 164, "Flora" },
                    { 163, "Filipina" },
                    { 162, "Filipa" },
                    { 161, "Ferdynanda" },
                    { 160, "Feliksa" },
                    { 159, "Felicyta" },
                    { 158, "Felicjana" },
                    { 157, "Felicja" },
                    { 156, "Faustyna" },
                    { 142, "Emma" },
                    { 143, "Ernesta" },
                    { 144, "Ernestyna" },
                    { 145, "Eryka" },
                    { 146, "Estera" },
                    { 147, "Eugenia" },
                    { 173, "Gertruda" },
                    { 148, "Ewa" },
                    { 150, "Fabia" },
                    { 151, "Fabiana" },
                    { 152, "Fabiola" },
                    { 153, "Farida" },
                    { 154, "Fatima" },
                    { 155, "Fatma" },
                    { 149, "Ewelina" },
                    { 174, "Gizela" },
                    { 175, "Gloria" },
                    { 176, "Gniewomira" },
                    { 195, "Hermana" },
                    { 196, "Hermenegilda" },
                    { 197, "Hermina" },
                    { 198, "Hestia" },
                    { 199, "Hiacynta" },
                    { 200, "Hilaria" },
                    { 194, "Herma" },
                    { 201, "Hildegarda" },
                    { 203, "Honorata" },
                    { 204, "Hortensja" },
                    { 205, "Huberta" },
                    { 206, "Husaria" },
                    { 207, "Ida" },
                    { 208, "Idosława" },
                    { 202, "Hipolit" },
                    { 280, "Ksawera" },
                    { 193, "Henryka" },
                    { 191, "Helga" },
                    { 177, "Gracja" },
                    { 178, "Gracjana" },
                    { 179, "Grażyna" },
                    { 180, "Greta" },
                    { 181, "Gryzelda" },
                    { 182, "Grzymisława" },
                    { 192, "Henrieta" },
                    { 183, "Gustawa" },
                    { 185, "Hadriana" },
                    { 186, "Halina" },
                    { 187, "Halszka" },
                    { 188, "Hanna" },
                    { 189, "Hedwiga" },
                    { 190, "Helena" },
                    { 184, "Gwidona" },
                    { 561, "Żywisław" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "NamesLists",
                keyColumn: "ID",
                keyValue: 561);
        }
    }
}
