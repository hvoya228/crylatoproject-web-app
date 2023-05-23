using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Comments.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Comments");

            migrationBuilder.CreateTable(
                name: "Comments",
                schema: "Comments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Theme = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FeedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                schema: "Comments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeedbackTheme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Comments_CommentId",
                        column: x => x.CommentId,
                        principalSchema: "Comments",
                        principalTable: "Comments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                schema: "Comments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Replies_Comments_CommentId",
                        column: x => x.CommentId,
                        principalSchema: "Comments",
                        principalTable: "Comments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Comments",
                columns: new[] { "ID", "FeedbackId", "PostDate", "Text", "Theme" },
                values: new object[,]
                {
                    { new Guid("04d21d33-a0da-4a7e-a936-488705db16db"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 7, 3, 6, 50, 53, 881, DateTimeKind.Local).AddTicks(8158), "repellat", "suscipit" },
                    { new Guid("145331a8-af26-4009-a991-1113eb656a54"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 8, 17, 8, 58, 15, 387, DateTimeKind.Local).AddTicks(3655), "Exercitationem nostrum accusantium dolor ducimus.\nVel sit et illo dolore aut iste tempora qui.\nEveniet ea animi eligendi voluptatem sint suscipit cum quaerat.\nAd sed velit eum.\nNobis iure nihil sit.\nMinima deleniti aut ut illum est tempore dolor voluptatem sed.", "fugiat" },
                    { new Guid("19fa9004-64bf-4cd6-bde2-a9efd845a6e1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 12, 4, 12, 0, 48, 297, DateTimeKind.Local).AddTicks(7419), "Nesciunt et hic consequatur atque nostrum occaecati.", "officia" },
                    { new Guid("1d24d398-ec78-41e2-be23-2c3de86ca8d1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 8, 15, 10, 27, 43, 236, DateTimeKind.Local).AddTicks(742), "sint", "ea" },
                    { new Guid("1ef9b8ca-baca-40f6-b6e4-8a9583800475"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 9, 19, 5, 8, 3, 387, DateTimeKind.Local).AddTicks(2111), "Sit voluptatem eligendi iusto eveniet.", "a" },
                    { new Guid("27163ef6-b75f-423c-94e5-cfb93c45c989"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 3, 6, 0, 42, 39, 399, DateTimeKind.Local).AddTicks(1377), "Consequuntur sunt reprehenderit mollitia omnis aut tenetur provident et harum.\nIncidunt placeat aut et rerum quis est eaque.\nReprehenderit fugit aliquam sed explicabo.\nAb est rerum aut ratione non rerum quia et neque.\nPlaceat et voluptate sit inventore culpa.\nVoluptatibus quo perferendis eum neque est excepturi quisquam.", "voluptatem" },
                    { new Guid("2c2cab88-11dc-48d5-8466-15a5e0d3e9fb"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 9, 23, 11, 59, 36, 866, DateTimeKind.Local).AddTicks(9985), "quos", "a" },
                    { new Guid("2db37b25-03b6-48c2-a39f-439bd6d3daf3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 19, 9, 24, 21, 474, DateTimeKind.Local).AddTicks(285), "Ipsum distinctio maxime commodi enim.\nQuibusdam modi itaque omnis quos.\nFugiat et cupiditate ut doloribus dolor odio.\nQuia quaerat odit tempore alias ab occaecati magni blanditiis.\nQuia minus dolorem cum perferendis neque non qui expedita.", "vel" },
                    { new Guid("30371de7-0c5e-436d-a4ae-49d344269ab6"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 9, 13, 0, 36, 3, 389, DateTimeKind.Local).AddTicks(3595), "Debitis enim nostrum optio voluptatem qui eius.", "dolorum" },
                    { new Guid("34ee4e3a-45d4-455a-b069-7c39a312ab08"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 6, 28, 20, 22, 16, 923, DateTimeKind.Local).AddTicks(8344), "voluptas", "molestias" },
                    { new Guid("3892b4e2-369f-4184-8a88-81706960d694"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 9, 20, 9, 58, 40, 620, DateTimeKind.Local).AddTicks(5004), "Et asperiores ipsam perferendis natus totam. Est nostrum exercitationem. Voluptatem nostrum nulla officiis doloribus velit sunt nemo consequatur. Animi autem ipsa sit itaque eveniet. Non sed ex numquam sit doloribus consequatur.", "eligendi" },
                    { new Guid("409e9bbf-e29c-4395-9aa4-c0d2da2bbb8d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 7, 14, 13, 2, 45, 590, DateTimeKind.Local).AddTicks(5340), "Natus omnis culpa ut sequi et reiciendis aperiam quia.", "laboriosam" },
                    { new Guid("449d3eaa-9eb1-43ec-b304-811a6dff8c1e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 7, 11, 9, 1, 3, 753, DateTimeKind.Local).AddTicks(8559), "Necessitatibus quia totam.\nEligendi inventore et blanditiis commodi ut consequatur.\nQuo sed voluptate corrupti omnis omnis beatae.\nHic ea accusamus iure consequatur quia qui cumque in minus.", "saepe" },
                    { new Guid("47e257d7-ed53-40e5-99b4-c20d04d91eb2"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 10, 28, 9, 24, 16, 219, DateTimeKind.Local).AddTicks(4518), "A voluptas ullam sequi vero adipisci libero mollitia voluptas.\nTotam facere voluptatem laudantium asperiores consequatur vitae.\nEos illo eum perferendis quod saepe.", "recusandae" },
                    { new Guid("499da793-7e00-4d78-9fba-5406cb1c090c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 9, 27, 16, 35, 19, 421, DateTimeKind.Local).AddTicks(8194), "Qui suscipit quo quaerat dignissimos non ut. Nobis consequatur et. Repudiandae qui id consequatur qui. Error debitis suscipit omnis sint eum.", "temporibus" },
                    { new Guid("6d20f885-a18e-47c6-8d01-6d5241e009c1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 8, 11, 19, 48, 19, 332, DateTimeKind.Local).AddTicks(8631), "Dolorum voluptatum voluptas alias.", "esse" },
                    { new Guid("74d3b621-020f-4ee3-976d-2118f3b777bb"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 8, 20, 3, 13, 58, 16, DateTimeKind.Local).AddTicks(6105), "Accusantium mollitia rerum ut odio totam molestias eligendi quisquam modi. Dolores velit optio dicta rerum aliquid. Alias sed perferendis eos omnis.", "atque" },
                    { new Guid("771f9110-ddbb-4473-b242-9592f8454161"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 3, 10, 16, 41, 57, 790, DateTimeKind.Local).AddTicks(806), "Nobis ipsa nihil aut quibusdam sit.", "fuga" },
                    { new Guid("8722eb57-e451-48d1-8b82-5ff767d58e17"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 29, 2, 48, 4, 190, DateTimeKind.Local).AddTicks(1552), "Ut hic fugiat.\nQui aut hic numquam asperiores temporibus.\nAut libero praesentium voluptatem voluptatem.\nEst et maiores.", "excepturi" },
                    { new Guid("928d8324-c8c2-4aed-8aaa-59438e0d1142"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 4, 7, 14, 8, 36, 219, DateTimeKind.Local).AddTicks(5770), "Explicabo ut omnis.\nQuam nobis et.\nEt in aut perferendis maxime repudiandae nisi minima laudantium rerum.\nDolor rerum aut sunt est quae hic.\nQuibusdam soluta in dolorem rerum rem debitis aut dolor.", "debitis" },
                    { new Guid("95f00057-2785-4a06-a8cd-4928b57d7727"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 9, 19, 6, 30, 26, 394, DateTimeKind.Local).AddTicks(7546), "Enim ut error occaecati sed cum exercitationem modi ex et. Dolores commodi libero est. Corporis nemo eligendi. Vel veniam tenetur reprehenderit et commodi perspiciatis mollitia. Eos ut possimus cum aut libero.", "a" },
                    { new Guid("986cca32-6160-4570-981d-5648e896e4ee"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 6, 14, 14, 46, 29, 562, DateTimeKind.Local).AddTicks(6459), "itaque", "dicta" },
                    { new Guid("a972e1a0-6776-4f40-9973-8f91b0e66b8c"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 8, 10, 17, 57, 5, 735, DateTimeKind.Local).AddTicks(442), "Est voluptatem nisi sequi perspiciatis.", "accusantium" },
                    { new Guid("b46f35e8-162b-4dd5-ad9d-9645d3a5af0b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 12, 12, 18, 46, 6, 628, DateTimeKind.Local).AddTicks(8354), "sit", "voluptatem" },
                    { new Guid("b4d17469-4bb3-4ad5-b77b-0405339dcd20"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 11, 2, 11, 42, 3, 680, DateTimeKind.Local).AddTicks(2969), "Nobis explicabo facere aut laboriosam ut quia velit. Quam non recusandae. Enim qui aut aut vel ut omnis eaque ratione voluptas. Eum cupiditate quis. Ratione iure consequatur.", "saepe" },
                    { new Guid("bb2400dc-75f5-438a-8c52-a81869b1d233"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 9, 13, 13, 1, 31, 618, DateTimeKind.Local).AddTicks(4848), "minima", "exercitationem" },
                    { new Guid("c6c0ebbc-e61a-479a-ba27-babc4b679634"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 7, 7, 7, 58, 55, 734, DateTimeKind.Local).AddTicks(6603), "necessitatibus", "est" },
                    { new Guid("d3fd6617-125a-46a1-aefc-34e8a77e1fce"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 2, 20, 10, 54, 25, 726, DateTimeKind.Local).AddTicks(8978), "At voluptates et nisi iste velit qui. Eos voluptas reprehenderit eos ea veritatis aliquam possimus quaerat consequuntur. Quidem quo hic consequatur autem. Corrupti amet itaque iusto nostrum dolor illum. Et totam in eius.", "fugiat" },
                    { new Guid("dd62c50c-609d-4152-8a4a-c0edf26dbb82"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 16, 11, 26, 4, 739, DateTimeKind.Local).AddTicks(42), "Quia fugit consectetur nulla. Velit provident sapiente consequatur libero et molestias voluptate. Quae aut maxime vel alias repudiandae molestias. Omnis et provident expedita sed non illum fugiat.", "praesentium" },
                    { new Guid("e916bfb2-3621-42e2-a476-13f3d9d229af"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 8, 4, 33, 49, 953, DateTimeKind.Local).AddTicks(2601), "Vitae esse et doloribus.\nConsequatur quis est voluptatem in molestiae id neque rerum.\nDolorem aspernatur placeat sunt molestias rem quo voluptas dolorum quis.", "est" }
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Feedbacks",
                columns: new[] { "ID", "CommentId", "FeedbackTheme" },
                values: new object[,]
                {
                    { new Guid("072be93a-bc67-4210-a52a-9e3cf1782a32"), new Guid("47e257d7-ed53-40e5-99b4-c20d04d91eb2"), "LoveIt" },
                    { new Guid("09745ada-16b8-4eaa-8521-bf7c4f4cf013"), new Guid("6d20f885-a18e-47c6-8d01-6d5241e009c1"), "Comment" },
                    { new Guid("09d88014-1ed8-4643-b894-669adbd82672"), new Guid("bb2400dc-75f5-438a-8c52-a81869b1d233"), "LoveIt" },
                    { new Guid("1a5e229c-64bc-48a4-803f-9e38bab07456"), new Guid("95f00057-2785-4a06-a8cd-4928b57d7727"), "Issue" },
                    { new Guid("29ec375c-ff11-41c8-98f9-0a364a4712f0"), new Guid("449d3eaa-9eb1-43ec-b304-811a6dff8c1e"), "Issue" },
                    { new Guid("2af6cf83-fb34-4b37-8ab6-8e257ed69485"), new Guid("145331a8-af26-4009-a991-1113eb656a54"), "LoveIt" },
                    { new Guid("3028df73-73ef-4fed-a1fc-3bdb55120388"), new Guid("e916bfb2-3621-42e2-a476-13f3d9d229af"), "Issue" },
                    { new Guid("32352100-8758-4118-898d-e7b7e5ad9864"), new Guid("1d24d398-ec78-41e2-be23-2c3de86ca8d1"), "LoveIt" },
                    { new Guid("384fc0c4-a778-4f04-a96e-5703c7990588"), new Guid("986cca32-6160-4570-981d-5648e896e4ee"), "Suggestion" },
                    { new Guid("4e6cfb0a-f81a-4de9-9ab9-f829e19e2646"), new Guid("a972e1a0-6776-4f40-9973-8f91b0e66b8c"), "LoveIt" },
                    { new Guid("6611ce07-71be-43bd-9480-3a332301f5b3"), new Guid("409e9bbf-e29c-4395-9aa4-c0d2da2bbb8d"), "Comment" },
                    { new Guid("6b3596cf-078f-4ee5-9096-3ceb67a0b056"), new Guid("771f9110-ddbb-4473-b242-9592f8454161"), "Issue" },
                    { new Guid("76a1a4c4-f1c1-4989-abca-ffcfe6e27aaa"), new Guid("499da793-7e00-4d78-9fba-5406cb1c090c"), "LoveIt" },
                    { new Guid("7d40098c-7b37-4288-ab5d-af52c41b92b5"), new Guid("04d21d33-a0da-4a7e-a936-488705db16db"), "Comment" },
                    { new Guid("8fe024e6-ec36-41df-8b79-405748c93971"), new Guid("74d3b621-020f-4ee3-976d-2118f3b777bb"), "Issue" },
                    { new Guid("939eac44-e210-4d1a-968e-0d1503507d9a"), new Guid("3892b4e2-369f-4184-8a88-81706960d694"), "Issue" },
                    { new Guid("99f5ed78-7462-46f8-b05b-d1f6517bf00e"), new Guid("27163ef6-b75f-423c-94e5-cfb93c45c989"), "Issue" },
                    { new Guid("a211ca06-0a44-4412-8368-541b72ba941d"), new Guid("19fa9004-64bf-4cd6-bde2-a9efd845a6e1"), "Suggestion" },
                    { new Guid("a4a56f2d-0135-47a9-a66b-2fd260f903bc"), new Guid("30371de7-0c5e-436d-a4ae-49d344269ab6"), "LoveIt" },
                    { new Guid("a5ed943e-8ad6-4db5-9d67-ea130196a39f"), new Guid("c6c0ebbc-e61a-479a-ba27-babc4b679634"), "Issue" },
                    { new Guid("aa24a61d-081d-4680-a255-8af876c98b40"), new Guid("34ee4e3a-45d4-455a-b069-7c39a312ab08"), "Issue" },
                    { new Guid("b3f7a682-8194-43d5-95e5-449c9f00b5b9"), new Guid("2c2cab88-11dc-48d5-8466-15a5e0d3e9fb"), "Suggestion" },
                    { new Guid("bbd3c3a4-984d-4603-a5b7-ea92654c8d51"), new Guid("dd62c50c-609d-4152-8a4a-c0edf26dbb82"), "Comment" },
                    { new Guid("d2794bf9-7f50-4b59-b728-27b476720bf9"), new Guid("b4d17469-4bb3-4ad5-b77b-0405339dcd20"), "Comment" },
                    { new Guid("dfaf91fe-2b85-4cdc-a75c-8762b28f9911"), new Guid("1ef9b8ca-baca-40f6-b6e4-8a9583800475"), "LoveIt" },
                    { new Guid("e455b905-270f-4cfa-944b-34e9752ec1da"), new Guid("d3fd6617-125a-46a1-aefc-34e8a77e1fce"), "LoveIt" },
                    { new Guid("e5ad2c9f-5b94-4895-82c1-6fa24b2309c1"), new Guid("8722eb57-e451-48d1-8b82-5ff767d58e17"), "LoveIt" },
                    { new Guid("ed9e2e99-be69-409a-ae73-aed04277de8c"), new Guid("2db37b25-03b6-48c2-a39f-439bd6d3daf3"), "LoveIt" },
                    { new Guid("f013d319-b12c-41fe-8555-3db4c4bbba77"), new Guid("928d8324-c8c2-4aed-8aaa-59438e0d1142"), "Suggestion" },
                    { new Guid("f619fc19-91a6-4eb7-a23d-dcdb0d479c10"), new Guid("b46f35e8-162b-4dd5-ad9d-9645d3a5af0b"), "Comment" }
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Replies",
                columns: new[] { "ID", "CommentId", "PostDate", "Text" },
                values: new object[,]
                {
                    { new Guid("089a83e2-371f-4afd-a368-b1e707da5aca"), new Guid("6d20f885-a18e-47c6-8d01-6d5241e009c1"), new DateTime(2023, 5, 11, 3, 38, 38, 347, DateTimeKind.Local).AddTicks(8242), "Iure consequuntur laudantium accusamus incidunt veniam aspernatur." },
                    { new Guid("0c6bb331-7938-46c3-b956-e943d809fede"), new Guid("771f9110-ddbb-4473-b242-9592f8454161"), new DateTime(2023, 1, 13, 2, 58, 18, 649, DateTimeKind.Local).AddTicks(3744), "Consequatur corporis exercitationem qui molestiae.\nQuisquam sint ab dolorum excepturi ut reiciendis.\nOptio dolor blanditiis debitis totam eos sed sed.\nPraesentium voluptate dolorum.\nAlias et in.\nTempora dolor exercitationem consequuntur sunt rem et deleniti." },
                    { new Guid("0f2a6c37-272f-4e12-8c9d-37c55a7deff5"), new Guid("74d3b621-020f-4ee3-976d-2118f3b777bb"), new DateTime(2023, 1, 6, 17, 33, 58, 743, DateTimeKind.Local).AddTicks(9402), "Reprehenderit cupiditate in voluptas dolorem amet itaque animi.\nEt autem veniam nulla qui eveniet qui voluptatem eveniet aperiam.\nVoluptatem quia rerum est corporis tempora inventore et dolores necessitatibus.\nFugiat placeat nihil aliquid quam saepe nam beatae.\nSapiente deleniti dolorem id sit consequatur aliquid." },
                    { new Guid("129c41ec-09a0-482a-8cf8-64542f516334"), new Guid("27163ef6-b75f-423c-94e5-cfb93c45c989"), new DateTime(2023, 4, 7, 9, 33, 1, 950, DateTimeKind.Local).AddTicks(3251), "nobis" },
                    { new Guid("18920a16-067f-4f76-a20d-9239422c5fed"), new Guid("409e9bbf-e29c-4395-9aa4-c0d2da2bbb8d"), new DateTime(2022, 9, 1, 1, 58, 3, 242, DateTimeKind.Local).AddTicks(3101), "Quibusdam rem ipsa et repellat aliquid. Similique dolorem omnis rerum et praesentium dolor voluptas provident id. Nostrum beatae porro sequi." },
                    { new Guid("23cd32f0-3925-4d97-9160-06dd08a91970"), new Guid("8722eb57-e451-48d1-8b82-5ff767d58e17"), new DateTime(2023, 3, 14, 20, 12, 0, 968, DateTimeKind.Local).AddTicks(6639), "odit" },
                    { new Guid("24404c23-15ca-4ad4-8b04-d4d7666571e1"), new Guid("34ee4e3a-45d4-455a-b069-7c39a312ab08"), new DateTime(2022, 11, 7, 11, 35, 21, 906, DateTimeKind.Local).AddTicks(5825), "Id quibusdam aperiam vel repudiandae mollitia facere." },
                    { new Guid("322fbdfe-c0d2-4435-885f-2f503fccd92f"), new Guid("1d24d398-ec78-41e2-be23-2c3de86ca8d1"), new DateTime(2023, 1, 22, 19, 21, 11, 359, DateTimeKind.Local).AddTicks(5410), "Culpa cum quibusdam quis ut nesciunt at eveniet qui blanditiis." },
                    { new Guid("33528453-b175-4d79-bb42-f2834178d060"), new Guid("bb2400dc-75f5-438a-8c52-a81869b1d233"), new DateTime(2022, 10, 8, 18, 28, 20, 967, DateTimeKind.Local).AddTicks(597), "Expedita dolores velit praesentium saepe nam earum consequatur.\nMollitia rem vitae nesciunt facere tenetur eaque voluptatem.\nAlias velit incidunt suscipit tempora numquam sit itaque.\nDistinctio aut autem." },
                    { new Guid("370bebc3-6129-4fbf-869f-e504f41bff5a"), new Guid("dd62c50c-609d-4152-8a4a-c0edf26dbb82"), new DateTime(2022, 8, 5, 2, 28, 24, 820, DateTimeKind.Local).AddTicks(9962), "Eligendi unde ut quasi. Velit odio inventore magni. Nostrum reprehenderit voluptatem omnis ab aut saepe cumque alias. Vero dolore perferendis ut quo ea libero sint. Eos aliquam saepe provident repellendus ratione quidem." },
                    { new Guid("38269ae7-d595-4a47-999a-846863990940"), new Guid("1ef9b8ca-baca-40f6-b6e4-8a9583800475"), new DateTime(2023, 3, 2, 22, 6, 22, 89, DateTimeKind.Local).AddTicks(7758), "tempora" },
                    { new Guid("3caef44d-293c-40fe-9fbc-4d16f50fa00a"), new Guid("2c2cab88-11dc-48d5-8466-15a5e0d3e9fb"), new DateTime(2022, 8, 15, 5, 6, 44, 9, DateTimeKind.Local).AddTicks(1921), "Dignissimos necessitatibus blanditiis quia quis enim voluptas consequatur eius. Enim fugiat facilis ad mollitia quod sunt error ratione deserunt. Quo nemo maxime iste occaecati placeat mollitia sed velit. Dolores velit non est provident inventore provident voluptas et iusto." },
                    { new Guid("3edf1839-9ef2-46cd-aa10-81b50f8ab362"), new Guid("3892b4e2-369f-4184-8a88-81706960d694"), new DateTime(2022, 11, 4, 3, 5, 53, 206, DateTimeKind.Local).AddTicks(6945), "laboriosam" },
                    { new Guid("51eaebbd-0f54-4a7f-8d29-d002e95f6552"), new Guid("95f00057-2785-4a06-a8cd-4928b57d7727"), new DateTime(2023, 1, 1, 22, 24, 55, 674, DateTimeKind.Local).AddTicks(8173), "Eum quo ea.\nOfficia totam quia ut aperiam voluptas vero sapiente rerum eum.\nFacilis rerum fugiat aperiam provident asperiores modi optio nesciunt recusandae.\nSunt cum sit labore quo qui eum ut in neque.\nEnim illum molestiae ratione facere aliquid quae deleniti tenetur.\nMaiores nostrum omnis architecto labore eum voluptas omnis rerum deserunt." },
                    { new Guid("6337dfee-f4bb-4244-bd99-8a0176ebce4e"), new Guid("2db37b25-03b6-48c2-a39f-439bd6d3daf3"), new DateTime(2023, 3, 18, 9, 46, 50, 146, DateTimeKind.Local).AddTicks(4984), "Omnis aliquam suscipit. Doloremque necessitatibus aut quibusdam. Rerum dolores minima ea quisquam vero ut. Fuga nulla consectetur voluptas. Nostrum quis nihil ex." },
                    { new Guid("647f4399-92fb-4d78-a45b-cb849c58fa06"), new Guid("d3fd6617-125a-46a1-aefc-34e8a77e1fce"), new DateTime(2022, 9, 14, 19, 28, 20, 822, DateTimeKind.Local).AddTicks(3779), "Quisquam et non dicta et sequi consectetur. Rerum ullam dicta possimus rerum animi laborum sint qui. Ab ut ut dolore. Molestiae cumque ad." },
                    { new Guid("6a297b48-3d36-420a-82b6-d9090a507d86"), new Guid("928d8324-c8c2-4aed-8aaa-59438e0d1142"), new DateTime(2023, 4, 21, 0, 27, 34, 849, DateTimeKind.Local).AddTicks(2053), "Voluptas corporis sequi. Sit perferendis enim quia. Iste minus consequatur illo cum. Ipsa deserunt nihil maiores." },
                    { new Guid("6a3fa97e-cac7-4c86-a9dc-cf0ce8e72db3"), new Guid("a972e1a0-6776-4f40-9973-8f91b0e66b8c"), new DateTime(2022, 12, 10, 21, 15, 19, 879, DateTimeKind.Local).AddTicks(9134), "Voluptas sunt quibusdam rerum est est autem omnis dolorum. Eum est voluptatum perferendis eos sit esse aut vel animi. Consequatur voluptatum ab ab impedit aut. Autem est nostrum." },
                    { new Guid("80bc3c03-d1e9-4aa8-bb4f-e85cbb27b21c"), new Guid("e916bfb2-3621-42e2-a476-13f3d9d229af"), new DateTime(2022, 8, 2, 6, 38, 20, 971, DateTimeKind.Local).AddTicks(6801), "Vel accusamus est non unde nemo occaecati est veniam." },
                    { new Guid("963cc9a1-77b4-4c4d-9d90-3a4a50097d05"), new Guid("145331a8-af26-4009-a991-1113eb656a54"), new DateTime(2023, 2, 18, 6, 29, 5, 330, DateTimeKind.Local).AddTicks(3227), "Quod repellendus quidem magnam quam et voluptates dolorem architecto.\nDignissimos ea amet enim soluta dicta fuga aliquid id." },
                    { new Guid("a0dded82-5f95-4356-a007-e2313131788d"), new Guid("b46f35e8-162b-4dd5-ad9d-9645d3a5af0b"), new DateTime(2023, 5, 6, 12, 30, 30, 918, DateTimeKind.Local).AddTicks(8101), "Maiores eum sed laborum ea fugiat quis saepe. Et quam officia odio. Earum qui sunt minima ut. Eius eveniet quasi vel enim. Quisquam quia autem dolorum voluptatum ducimus non vel." },
                    { new Guid("a7b3ac3a-995d-40a5-ba58-bc77d08a90c8"), new Guid("499da793-7e00-4d78-9fba-5406cb1c090c"), new DateTime(2022, 7, 6, 15, 25, 40, 368, DateTimeKind.Local).AddTicks(5071), "Tempore saepe minima saepe ad eum. Voluptatem occaecati hic nulla. Est vel eveniet deserunt est inventore odit quo laudantium. Quasi molestiae recusandae consequuntur soluta." },
                    { new Guid("bac61919-a109-413a-b1fc-d174ecf45d89"), new Guid("19fa9004-64bf-4cd6-bde2-a9efd845a6e1"), new DateTime(2022, 10, 10, 7, 9, 2, 971, DateTimeKind.Local).AddTicks(9412), "Quam asperiores sit neque quo voluptatem." },
                    { new Guid("bb7419a4-131c-4f40-90c1-0cbf900487f6"), new Guid("04d21d33-a0da-4a7e-a936-488705db16db"), new DateTime(2023, 1, 25, 10, 44, 37, 75, DateTimeKind.Local).AddTicks(1613), "Labore pariatur fugiat maxime sint non natus." },
                    { new Guid("ce09a873-71a9-481a-b1fc-edfc64642620"), new Guid("47e257d7-ed53-40e5-99b4-c20d04d91eb2"), new DateTime(2023, 5, 7, 1, 15, 16, 161, DateTimeKind.Local).AddTicks(8230), "iure" },
                    { new Guid("d01b519d-1c4f-47f7-ac50-31ec62dc476f"), new Guid("986cca32-6160-4570-981d-5648e896e4ee"), new DateTime(2022, 6, 13, 13, 6, 16, 708, DateTimeKind.Local).AddTicks(9676), "Voluptatum voluptas error quo ut." },
                    { new Guid("d1b51eac-f33d-4180-a49a-62fd499e68db"), new Guid("b4d17469-4bb3-4ad5-b77b-0405339dcd20"), new DateTime(2023, 1, 31, 0, 45, 30, 78, DateTimeKind.Local).AddTicks(5298), "Sit voluptas deleniti. Enim velit modi provident consequatur culpa error fuga voluptatibus magni. Numquam qui ut." },
                    { new Guid("d947ca00-6e70-4228-8f29-dee86993160b"), new Guid("30371de7-0c5e-436d-a4ae-49d344269ab6"), new DateTime(2022, 10, 1, 4, 34, 58, 510, DateTimeKind.Local).AddTicks(770), "vitae" },
                    { new Guid("e05ca72e-5f91-46ac-9fc8-5572b00c7d06"), new Guid("c6c0ebbc-e61a-479a-ba27-babc4b679634"), new DateTime(2023, 4, 21, 19, 19, 56, 955, DateTimeKind.Local).AddTicks(5515), "perferendis" },
                    { new Guid("e59eee9e-7d19-4ad7-b73d-53696a2fa372"), new Guid("449d3eaa-9eb1-43ec-b304-811a6dff8c1e"), new DateTime(2022, 7, 27, 7, 19, 18, 416, DateTimeKind.Local).AddTicks(2530), "Perferendis sit delectus alias aliquid quas exercitationem consequatur eius eum." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_CommentId",
                schema: "Comments",
                table: "Feedbacks",
                column: "CommentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Replies_CommentId",
                schema: "Comments",
                table: "Replies",
                column: "CommentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks",
                schema: "Comments");

            migrationBuilder.DropTable(
                name: "Replies",
                schema: "Comments");

            migrationBuilder.DropTable(
                name: "Comments",
                schema: "Comments");
        }
    }
}
