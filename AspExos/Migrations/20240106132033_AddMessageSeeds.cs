using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspExos.Migrations
{
    /// <inheritdoc />
    public partial class AddMessageSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Contenu", "Date", "Emetteur" },
                values: new object[,]
                {
                    { 1, "Voluptas harum repudiandae voluptatem. Cupiditate nostrum doloremque illum repudiandae.", new DateOnly(2023, 5, 25), "Ivan Cummerata" },
                    { 2, "Fuga ab dolores distinctio. Et ut vitae magnam qui adipisci autem iste omnis enim. Voluptas sapiente velit sed nisi sed dicta. Animi voluptatum doloremque natus.", new DateOnly(2023, 3, 8), "Alton Kirlin" },
                    { 3, "Ut dolores animi suscipit. Id provident a est ipsam quasi et magni. Ex et debitis mollitia earum et ea.", new DateOnly(2023, 3, 17), "Eula Waelchi" },
                    { 4, "Et ea sunt. Tempore sequi eos quos dolorem ab vel officiis est labore. Sunt nihil ut. Dolores consequatur et accusamus nihil blanditiis repellendus doloremque sunt.", new DateOnly(2023, 11, 3), "Tyler Johnston" },
                    { 5, "Voluptatum praesentium architecto quidem numquam nobis. Architecto vel rerum sed quam et. Omnis voluptas nostrum commodi atque id saepe. Modi minus dolorum dolorem a ut.", new DateOnly(2023, 12, 6), "Alfred Reilly" },
                    { 6, "Harum explicabo enim qui soluta velit. Non quasi sed aliquam sed. Amet maxime repellendus quae saepe nihil accusantium error eum perspiciatis. Nostrum quaerat eos placeat sequi qui.", new DateOnly(2023, 7, 9), "Juanita Waelchi" },
                    { 7, "Facilis sapiente fuga eaque cupiditate aut et libero. In porro qui. Omnis ea dolorem et eos repellendus quidem voluptatem assumenda. Temporibus laudantium omnis facilis ut tempora laboriosam rerum quis amet.", new DateOnly(2023, 11, 25), "Tara Sanford" },
                    { 8, "Ipsam et nobis. Officiis nemo modi. Quis quidem qui quis. Numquam earum quae cum quibusdam ad est illo.", new DateOnly(2023, 4, 5), "Johanna Corwin" },
                    { 9, "Ratione cum sit saepe consequatur in non rerum. Eveniet dolor magnam consectetur quis.", new DateOnly(2023, 4, 29), "Johnnie Hettinger" },
                    { 10, "Et architecto quam magnam soluta dolor voluptatem animi aut. Iusto culpa beatae et voluptatem odit perferendis. Suscipit eum numquam odio voluptatibus accusantium rerum.", new DateOnly(2023, 5, 28), "Chester Bogisich" },
                    { 11, "Sint hic itaque tempore consequuntur culpa. Veniam est alias a atque ex est fuga ullam esse.", new DateOnly(2023, 11, 4), "Lester Erdman" },
                    { 12, "Rerum et quam nesciunt quam et minus id nobis et. Sint sunt ratione quis odio aperiam et beatae autem.", new DateOnly(2023, 11, 13), "Jeannie McClure" },
                    { 13, "Quibusdam qui non aut adipisci vel. Et laudantium exercitationem sit optio autem consectetur.", new DateOnly(2023, 4, 9), "Crystal Cassin" },
                    { 14, "Suscipit velit sit quam fuga dolores sed occaecati et. Voluptatem quia est sed repellat alias doloribus quam.", new DateOnly(2023, 4, 23), "Natasha Kunze" },
                    { 15, "Ipsum exercitationem cupiditate et. Est maiores omnis qui.", new DateOnly(2023, 9, 12), "Shelia Ernser" },
                    { 16, "Similique voluptas natus rerum laboriosam repellat iure et consequuntur natus.", new DateOnly(2023, 9, 25), "Eugene Kautzer" },
                    { 17, "Eos accusamus dolorem itaque consectetur est cupiditate sit accusantium ea. Ad quidem fuga a alias quas optio in. Veritatis id non ut sed quam.", new DateOnly(2023, 2, 13), "Robin Smitham" },
                    { 18, "Omnis sequi illum consequatur quia rerum qui cumque ut. Architecto accusantium omnis est modi qui atque accusamus. Mollitia qui omnis veniam exercitationem quo. Corrupti fugiat sequi dolorem autem dolorem.", new DateOnly(2023, 10, 2), "Angelo Bogisich" },
                    { 19, "Sit aut rerum ea vero.", new DateOnly(2023, 5, 14), "Kathy Cummings" },
                    { 20, "Suscipit voluptatem et excepturi illum molestiae consequatur quisquam. Aliquid ut veniam explicabo dicta vel ratione ipsa nesciunt cumque. Reprehenderit qui aut temporibus voluptatem vitae.", new DateOnly(2023, 5, 12), "Roxanne Weissnat" },
                    { 21, "Qui voluptatem ipsa quod voluptatem et sequi. Aut voluptates consequuntur ut esse sed tenetur. Asperiores eligendi soluta veniam.", new DateOnly(2023, 5, 8), "Teri Blick" },
                    { 22, "Nisi fuga culpa hic eos.", new DateOnly(2023, 1, 9), "Lawrence Tillman" },
                    { 23, "Qui corrupti quis omnis accusamus aliquam.", new DateOnly(2023, 2, 10), "Rickey Runte" },
                    { 24, "Alias cumque culpa. Alias sint consequatur laboriosam distinctio ea aut iste veniam est. Consequatur ut deleniti dolores adipisci magnam sit.", new DateOnly(2023, 9, 15), "Maureen Collins" },
                    { 25, "Culpa facilis voluptatem veritatis culpa. Et debitis dolor et ab placeat iusto et explicabo praesentium. Ut dolor blanditiis ullam ut omnis modi et unde doloremque. Omnis nulla et.", new DateOnly(2023, 7, 27), "Alison Pagac" },
                    { 26, "In recusandae nisi omnis blanditiis accusantium. Dolore iste est alias voluptatibus ut vitae quam. Expedita ea consequuntur fugiat pariatur et est. Sunt et et illo a nesciunt.", new DateOnly(2023, 8, 22), "Mercedes Rolfson" },
                    { 27, "Expedita ullam quam deserunt accusamus sint ut. Ut pariatur atque ut illum soluta dolor quia veritatis deserunt. Atque ullam praesentium voluptate qui maiores qui. Enim rerum corporis.", new DateOnly(2023, 6, 13), "Eugene Stehr" },
                    { 28, "Et animi dolor quaerat fugiat sit optio harum maxime. Iste qui placeat quod ipsa. Ut inventore ipsam id ducimus necessitatibus quis. Autem consequatur et non explicabo at et.", new DateOnly(2023, 7, 10), "Ricky Gutmann" },
                    { 29, "Sint cumque qui fugit et voluptatibus explicabo sed sapiente non. Animi odio autem at in suscipit nam. Quaerat et nemo et ullam et consequatur.", new DateOnly(2023, 8, 25), "Allen Hudson" },
                    { 30, "Dignissimos sit ea ut voluptas ratione voluptate. Magni iure quaerat et totam assumenda veniam et harum delectus. Vitae nulla nulla necessitatibus est minima accusamus sunt vel.", new DateOnly(2023, 3, 9), "Stacy Lesch" },
                    { 31, "Voluptatem nostrum excepturi molestiae assumenda ut aut non. Id sint consequuntur itaque asperiores et nulla aut officia. Deleniti et a.", new DateOnly(2023, 9, 4), "Jeff Kunze" },
                    { 32, "Ipsum et cumque aliquam non voluptatem est. Qui voluptatem quis laudantium quaerat suscipit.", new DateOnly(2023, 11, 10), "Rochelle Cummings" },
                    { 33, "Aut possimus itaque dolore. Eum consectetur voluptate ut. Voluptatem tenetur adipisci et distinctio illo doloremque voluptatem accusantium qui. Doloremque minima quia id.", new DateOnly(2023, 5, 28), "Mattie Jenkins" },
                    { 34, "Repellat et veritatis aut assumenda quaerat voluptatum. Veniam animi saepe necessitatibus dignissimos alias rerum soluta tempora. Deleniti perferendis quia itaque fugit quidem debitis qui aliquid est. Et et velit veniam maxime autem qui dolores est.", new DateOnly(2023, 10, 26), "Amy Toy" },
                    { 35, "Rem voluptas omnis sit provident qui. Et architecto inventore eaque occaecati optio enim voluptatem.", new DateOnly(2023, 6, 29), "Christina Gleichner" },
                    { 36, "Quis impedit incidunt enim numquam veniam eius. Sit iusto nulla voluptas et. Quia vel sit. Quo et non.", new DateOnly(2023, 10, 21), "Evelyn Roberts" },
                    { 37, "Illum odit illo vel natus ut quas praesentium. Est ut ut maiores ut. Est veritatis nisi iste expedita aut itaque. Magni ducimus rem eius.", new DateOnly(2023, 3, 11), "Jon VonRueden" },
                    { 38, "Rem quia dolorem in aliquam et a. Repellat quia sapiente officia quo cupiditate provident aut. Et qui unde corporis debitis mollitia laborum quae.", new DateOnly(2023, 8, 19), "Eugene Wisoky" },
                    { 39, "Mollitia voluptatem voluptas in. Et voluptatem quis iste. Et aut accusantium. Assumenda aut aut consectetur voluptates explicabo eos earum.", new DateOnly(2023, 2, 6), "Geneva Lakin" },
                    { 40, "Atque voluptas exercitationem quos enim. Distinctio deleniti quibusdam beatae voluptas. Voluptas voluptas autem. Architecto dolorem sit tenetur sunt omnis ducimus reiciendis.", new DateOnly(2023, 7, 14), "Bert Kunze" },
                    { 41, "Voluptatum libero voluptatem totam fugiat consequatur.", new DateOnly(2023, 9, 16), "Brad Oberbrunner" },
                    { 42, "Ut non incidunt voluptas voluptate fugiat error rerum. Maxime nihil repellendus sed et laudantium.", new DateOnly(2023, 4, 26), "Abraham Franecki" },
                    { 43, "Deserunt enim et eaque qui omnis rerum laboriosam deleniti. Fuga iure sequi molestias atque optio exercitationem fugit beatae. Possimus nisi placeat doloremque.", new DateOnly(2023, 11, 16), "Wilson Klocko" },
                    { 44, "Qui dolorum quo dolores et quia qui. Est consequatur velit asperiores et ea nisi fuga. Error fuga ducimus ut ut dolor a sed repellat voluptates.", new DateOnly(2023, 3, 26), "Constance Jacobs" },
                    { 45, "Quo rem saepe alias ipsam debitis asperiores animi saepe.", new DateOnly(2023, 3, 14), "Genevieve Kuhlman" },
                    { 46, "A neque necessitatibus aperiam nobis suscipit quod sit. Magni ut qui est voluptatem in odit corporis.", new DateOnly(2023, 4, 11), "Wilma MacGyver" },
                    { 47, "Doloremque eligendi dolor et fugit provident enim. Nostrum voluptatem velit repellendus. Hic inventore qui quis enim.", new DateOnly(2023, 1, 7), "Marlon Swift" },
                    { 48, "Possimus omnis sed quibusdam corrupti est assumenda quisquam incidunt. At nihil doloribus fugit voluptas itaque animi architecto id impedit.", new DateOnly(2023, 2, 17), "Marie Pouros" },
                    { 49, "Sint sunt dolorum. Ipsum voluptatibus saepe eaque itaque incidunt velit est autem necessitatibus. Dolorum et maxime eius ullam at ea est est.", new DateOnly(2023, 1, 17), "Lynn Larson" },
                    { 50, "Repellat vero quis rerum. Esse eos commodi fuga quibusdam et. Fugit sed est. Rerum ea consequuntur rerum.", new DateOnly(2023, 11, 17), "Tommy Rolfson" },
                    { 51, "Quis corporis eos ab sapiente. Veniam temporibus fuga harum possimus et odio quis dolorem. Voluptatem aut cupiditate. Officia in sunt nesciunt aperiam sapiente.", new DateOnly(2023, 11, 14), "Morris Stanton" },
                    { 52, "Adipisci tempore provident dolores saepe saepe consequatur ratione quo doloremque. Esse unde provident mollitia qui. Nobis cumque est deleniti ut eaque nesciunt cum hic debitis.", new DateOnly(2023, 12, 6), "Carl Langworth" },
                    { 53, "Quis deleniti nesciunt fugiat rerum. Id ut nam ipsum aut.", new DateOnly(2023, 6, 23), "Robin Smitham" },
                    { 54, "Dolores dolor cum adipisci provident delectus ut quidem.", new DateOnly(2023, 12, 8), "Stephanie Marquardt" },
                    { 55, "Accusamus fugiat beatae vel. Nostrum eveniet fugit saepe tempore voluptatem repellat natus. Assumenda voluptas ad aut neque aliquid error ullam dolorem illum.", new DateOnly(2023, 12, 27), "Derek Mann" },
                    { 56, "Nihil ea eaque excepturi numquam modi cumque esse. Quibusdam eaque rerum quisquam totam. Veniam ipsum cumque voluptatibus occaecati et eaque voluptatibus velit.", new DateOnly(2023, 6, 6), "Bobby Bergstrom" },
                    { 57, "Iste tempore delectus ducimus quo illum voluptatum reprehenderit sed possimus. Deserunt facere numquam quam veritatis soluta qui tempore fuga. Voluptates eveniet quos et. Culpa omnis ut et reprehenderit hic quibusdam corporis unde.", new DateOnly(2023, 1, 6), "Bradford Gutkowski" },
                    { 58, "Cumque exercitationem vitae illo quia ratione libero. Labore repellat est consequatur nemo autem est nesciunt velit. Sed vel voluptatem consectetur unde accusantium rem. Et fugiat enim veritatis rerum distinctio fugit.", new DateOnly(2023, 12, 20), "Rudy Johnson" },
                    { 59, "Iste iure molestiae et id ipsum sit omnis sed consequatur.", new DateOnly(2023, 8, 4), "Jim Rice" },
                    { 60, "Eaque cum natus quasi maxime molestiae ut molestias alias. Et placeat dolorum sit recusandae fuga. Molestiae corrupti eligendi est fugit quia.", new DateOnly(2023, 8, 14), "Beth Casper" },
                    { 61, "Facere sunt similique. Rerum mollitia dolorem mollitia sequi esse id voluptatem animi facere. Distinctio blanditiis quia et non saepe commodi eaque temporibus et.", new DateOnly(2023, 4, 3), "Roxanne Stoltenberg" },
                    { 62, "Ullam labore maxime autem tempore soluta quaerat qui.", new DateOnly(2023, 3, 6), "Meredith Ernser" },
                    { 63, "Necessitatibus animi non ut et debitis vel et. Rerum consequatur in. Aut est distinctio iusto alias rerum qui et. In est voluptates molestias quidem.", new DateOnly(2023, 2, 19), "Terry Hilpert" },
                    { 64, "Perspiciatis omnis sunt odit iusto repellendus nobis architecto. Unde qui necessitatibus voluptas sint a. Quia est iste culpa totam est quasi quas.", new DateOnly(2024, 1, 4), "Arlene Hilll" },
                    { 65, "Ullam quia dolorem. Sint voluptates repellendus.", new DateOnly(2023, 5, 3), "Jeanne Johns" },
                    { 66, "Non porro quaerat officiis. Explicabo sint iste ut molestias doloribus cumque tempora deleniti.", new DateOnly(2023, 6, 13), "Inez Brekke" },
                    { 67, "Culpa assumenda quis impedit ut dolorum dolor.", new DateOnly(2023, 9, 15), "Sophie Rempel" },
                    { 68, "Voluptatem eos voluptate et veritatis velit vel qui. Soluta consequatur fugiat doloremque at sint asperiores sed. Ea quae possimus. Porro assumenda consequatur magni adipisci sint quis et.", new DateOnly(2023, 3, 30), "Noah Russel" },
                    { 69, "Consequuntur quisquam quisquam reiciendis dolorem veritatis. Dolorum exercitationem quis ipsum necessitatibus omnis. Deserunt fugiat aliquam possimus aut nam deleniti est nihil voluptas. Est quis et accusamus doloremque modi.", new DateOnly(2023, 9, 28), "Marc Erdman" },
                    { 70, "Voluptate deleniti consequatur et inventore dolorum.", new DateOnly(2023, 1, 28), "Willis Predovic" },
                    { 71, "Cum provident velit. Culpa sunt enim debitis possimus molestiae.", new DateOnly(2023, 11, 14), "Matt Padberg" },
                    { 72, "Quisquam nostrum dolores autem veritatis eius laudantium voluptas voluptatem cupiditate. Et rerum necessitatibus molestiae et id molestiae a. Rem tempore impedit laudantium vero molestias omnis debitis recusandae sit.", new DateOnly(2023, 6, 6), "Sammy Blanda" },
                    { 73, "Numquam sunt laboriosam. Aut alias dicta dolorem. Et id saepe. Nostrum ipsum eius ut odio sint.", new DateOnly(2023, 2, 27), "Pedro Parker" },
                    { 74, "Asperiores quam quidem eos praesentium eos. In voluptatem eos aut temporibus commodi autem provident. Et alias pariatur eaque aliquam aliquid. Saepe fugit ut.", new DateOnly(2023, 8, 15), "Joel Metz" },
                    { 75, "Eaque ipsa quia accusantium explicabo voluptates eveniet velit et. Est est ut recusandae natus et qui ipsam. Ad voluptatum ut soluta.", new DateOnly(2023, 12, 14), "Ernestine Senger" },
                    { 76, "Id tempore rerum dolorem ut rem ea est sit dolores. Maiores aut aut dolorum enim.", new DateOnly(2023, 6, 30), "Meredith Romaguera" },
                    { 77, "Unde non quasi ea. Rerum et cupiditate odio eos maxime et dolor aliquam.", new DateOnly(2023, 9, 18), "Edward Barton" },
                    { 78, "Pariatur adipisci perspiciatis dicta.", new DateOnly(2023, 5, 16), "Sonja Simonis" },
                    { 79, "Ut placeat nostrum distinctio perferendis occaecati. Aliquam amet incidunt est laborum. Quasi a et quo eos neque maxime fugiat. Velit aut optio quas corporis quidem.", new DateOnly(2023, 3, 27), "Hope Mosciski" },
                    { 80, "Dolor qui officia pariatur labore harum asperiores facere.", new DateOnly(2023, 12, 15), "Jessie Schmitt" },
                    { 81, "Ducimus nemo dignissimos a laboriosam dolores nostrum in sit ducimus.", new DateOnly(2023, 12, 1), "Loren Smitham" },
                    { 82, "Tempora hic reiciendis quis temporibus quam earum voluptas. Dolor et et laudantium veniam architecto doloribus necessitatibus ut ut. Illo quae alias non id in accusamus nostrum impedit qui.", new DateOnly(2023, 3, 26), "Bert Brown" },
                    { 83, "Vero itaque deleniti esse corrupti dicta magnam commodi omnis officia. Ea ad architecto.", new DateOnly(2023, 9, 14), "Danielle Schuppe" },
                    { 84, "Quo sed dolorem quasi veritatis qui beatae laborum sed. Dolorem qui esse enim facere assumenda nemo. Et quis incidunt laudantium repellat et non voluptas.", new DateOnly(2023, 1, 21), "Hope Braun" },
                    { 85, "Distinctio expedita aut sit deserunt soluta praesentium sunt similique vel.", new DateOnly(2023, 8, 20), "Elaine Corkery" },
                    { 86, "Voluptates doloribus consequatur molestiae voluptatem et.", new DateOnly(2023, 7, 12), "Myra McCullough" },
                    { 87, "Est sed et labore neque. Deserunt iusto repellat labore facilis consequatur eius pariatur. Minima temporibus unde dolorem et sed odit adipisci.", new DateOnly(2023, 4, 29), "Fannie O'Keefe" },
                    { 88, "Omnis eveniet voluptatibus fugiat. Similique aut adipisci laudantium libero sed. Culpa quis quod atque doloribus qui inventore. Adipisci sed voluptas sit dolorem iure omnis.", new DateOnly(2024, 1, 2), "Micheal Denesik" },
                    { 89, "Repudiandae nulla nulla aliquid assumenda et sit culpa sit. Omnis doloremque hic aut molestiae expedita deserunt enim. Consequatur ab voluptatem aut sunt labore quo vel consequatur.", new DateOnly(2023, 3, 20), "Donnie Miller" },
                    { 90, "Voluptas voluptatem quibusdam consequatur qui temporibus qui eligendi illum. Sunt neque qui qui quidem sint et voluptatibus. A molestiae voluptatibus sed eos eos dolore aut quibusdam itaque.", new DateOnly(2023, 7, 27), "Lamar Little" },
                    { 91, "Tempore soluta dolores aut eos iusto sit. Voluptatem sunt ut pariatur et. Eum exercitationem nostrum non laudantium nisi aut id est. Sint est doloribus et ut qui sunt corrupti.", new DateOnly(2023, 12, 14), "Austin Rohan" },
                    { 92, "Unde voluptas velit.", new DateOnly(2023, 7, 28), "Marlene Grimes" },
                    { 93, "Harum amet et et dolores illum eius dolorem dicta. Aut aperiam neque eaque maxime magni ut. Voluptatem modi aut.", new DateOnly(2023, 2, 13), "Kerry Greenholt" },
                    { 94, "Corporis odit in molestias cupiditate molestias possimus dolor. Voluptatum voluptatem odio in a et. Ea in amet aperiam aliquid rerum temporibus eveniet neque. At itaque totam culpa voluptatibus laboriosam.", new DateOnly(2023, 6, 10), "Darren Walsh" },
                    { 95, "Exercitationem dolores rem dolor provident velit corrupti. Saepe dolorum quidem delectus nam inventore commodi quia rerum cupiditate. Voluptatibus sunt minus consequuntur minus necessitatibus.", new DateOnly(2023, 8, 30), "Valerie White" },
                    { 96, "Consequatur dolor et nulla cupiditate ut totam labore cum provident. Quam est placeat placeat. Quisquam sapiente perferendis magnam.", new DateOnly(2023, 12, 24), "Shirley Stracke" },
                    { 97, "Molestiae sint iusto tempora.", new DateOnly(2023, 4, 27), "Daniel Ullrich" },
                    { 98, "Assumenda possimus repellat nihil repudiandae soluta similique voluptatem. Rem cumque quam sint. Et voluptatum repellat.", new DateOnly(2023, 8, 5), "Samuel O'Kon" },
                    { 99, "Impedit corrupti consequuntur debitis. Ratione labore ut suscipit magnam impedit consequatur totam quidem inventore.", new DateOnly(2023, 1, 28), "Lila Durgan" },
                    { 100, "Voluptas inventore est ipsam. Aut assumenda debitis unde eligendi reprehenderit.", new DateOnly(2023, 11, 11), "Gerald Kautzer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
