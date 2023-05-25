﻿using System;
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
                name: "Feedbacks",
                schema: "Comments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    FeedbackTheme = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                schema: "Comments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    CommentTheme = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CommentText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CommentPostDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 25, 20, 48, 55, 18, DateTimeKind.Local).AddTicks(5070)),
                    CommentFeedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comments_Feedbacks_CommentFeedbackId",
                        column: x => x.CommentFeedbackId,
                        principalSchema: "Comments",
                        principalTable: "Feedbacks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                schema: "Comments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ReplyText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ReplyPostDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 25, 20, 48, 55, 21, DateTimeKind.Local).AddTicks(7362)),
                    ReplyCommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Replies_Comments_ReplyCommentId",
                        column: x => x.ReplyCommentId,
                        principalSchema: "Comments",
                        principalTable: "Comments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Feedbacks",
                columns: new[] { "ID", "FeedbackTheme" },
                values: new object[,]
                {
                    { new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), "LoveIt" },
                    { new Guid("3c0fb448-22bc-40ec-8d3d-3425f5bb070c"), "Issue" },
                    { new Guid("d8bc610a-022c-4590-9283-c77ba502332d"), "Comment" },
                    { new Guid("eb659df6-0bd3-45ea-a8c9-8d745a1d1b36"), "Suggestion" }
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Comments",
                columns: new[] { "ID", "CommentFeedbackId", "CommentPostDate", "CommentText", "CommentTheme" },
                values: new object[,]
                {
                    { new Guid("06493211-65f5-4046-9883-905d0ef242e3"), new Guid("eb659df6-0bd3-45ea-a8c9-8d745a1d1b36"), new DateTime(2022, 8, 5, 10, 35, 44, 824, DateTimeKind.Local).AddTicks(454), "Nostrum eligendi et ullam dolor minus voluptatem minus animi.", "quia" },
                    { new Guid("0c653add-f887-4b80-8f5c-74790b5a2521"), new Guid("d8bc610a-022c-4590-9283-c77ba502332d"), new DateTime(2023, 2, 19, 3, 47, 52, 185, DateTimeKind.Local).AddTicks(3397), "Eos sed eum assumenda ea optio est nulla.\nConsequuntur nihil rerum sequi molestiae ducimus.", "eius" },
                    { new Guid("12202a45-0810-45f4-a224-450d51791c28"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2023, 4, 23, 12, 20, 9, 873, DateTimeKind.Local).AddTicks(2007), "Voluptas accusantium eaque in ipsam et.\nId ea quam quo dolorem.\nAt quisquam dolore aut dolor quam sunt fugit.", "est" },
                    { new Guid("1d238f4d-43b1-4aff-87fc-8c5001fba1ec"), new Guid("3c0fb448-22bc-40ec-8d3d-3425f5bb070c"), new DateTime(2022, 6, 5, 13, 55, 29, 429, DateTimeKind.Local).AddTicks(20), "Odit non quaerat nihil voluptas id rerum cumque vel quis.\nMagnam quia fuga ducimus.\nVoluptatem rem et necessitatibus rerum ut.\nHic voluptatem velit numquam.\nNihil repudiandae omnis facilis dolore aut omnis reiciendis natus.", "rerum" },
                    { new Guid("223e1904-1761-4389-810e-a78fa930fb0e"), new Guid("eb659df6-0bd3-45ea-a8c9-8d745a1d1b36"), new DateTime(2022, 12, 23, 8, 1, 9, 164, DateTimeKind.Local).AddTicks(3587), "Est minus qui et atque praesentium culpa.\nEx repellat nihil.\nConsequatur sit doloremque odit architecto quia eum.", "at" },
                    { new Guid("2f131231-4749-49c1-a46f-323ead41ffeb"), new Guid("3c0fb448-22bc-40ec-8d3d-3425f5bb070c"), new DateTime(2023, 4, 18, 6, 10, 5, 0, DateTimeKind.Local).AddTicks(4127), "Reprehenderit beatae maxime aut.", "omnis" },
                    { new Guid("3624cbdc-9ec0-4a00-94e2-a98876038bb8"), new Guid("d8bc610a-022c-4590-9283-c77ba502332d"), new DateTime(2023, 4, 20, 19, 38, 28, 866, DateTimeKind.Local).AddTicks(107), "Et a nostrum nobis est laboriosam. Voluptatum perspiciatis aliquid consectetur iusto dolorum placeat est incidunt. Numquam numquam qui dolore dolorem nisi consectetur quasi. Consequatur harum optio impedit. Voluptas optio voluptate blanditiis fuga. Similique dolorem consequatur.", "nostrum" },
                    { new Guid("3bf064ca-06a8-4283-94e1-408d9c3b7c6e"), new Guid("3c0fb448-22bc-40ec-8d3d-3425f5bb070c"), new DateTime(2022, 9, 3, 20, 12, 5, 675, DateTimeKind.Local).AddTicks(6676), "Laboriosam debitis sit nisi qui necessitatibus ducimus enim consectetur sed.", "eveniet" },
                    { new Guid("49939c8e-b4ef-45c9-bf6a-e5133fb22b6f"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2022, 7, 27, 4, 1, 10, 49, DateTimeKind.Local).AddTicks(618), "Alias labore qui quibusdam harum vel atque exercitationem enim veniam. Aliquam aut eligendi est consequatur. Ut qui et corporis corporis amet itaque iure. Cum fuga ipsam voluptate.", "rerum" },
                    { new Guid("4a800614-fb3f-4b84-a8d2-6dd27a766cca"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2022, 7, 18, 8, 11, 4, 421, DateTimeKind.Local).AddTicks(9119), "Pariatur laudantium aut saepe laborum autem nisi.", "recusandae" },
                    { new Guid("5b52430a-2018-4f6f-9c15-986c92bd47fd"), new Guid("eb659df6-0bd3-45ea-a8c9-8d745a1d1b36"), new DateTime(2023, 4, 1, 0, 43, 24, 638, DateTimeKind.Local).AddTicks(9708), "Inventore provident nihil. Ea cupiditate quia quam sint nam veniam quae et. Eaque quaerat delectus dolores rerum iste rerum dolor. Aut quis perferendis quo expedita non non est magni. Unde excepturi cupiditate culpa harum consequuntur.", "et" },
                    { new Guid("5f36b055-9419-422f-bfde-6b5144065814"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2022, 11, 20, 1, 53, 22, 721, DateTimeKind.Local).AddTicks(3711), "quidem", "quasi" },
                    { new Guid("647b255f-efc8-43f4-9728-6a974e758f38"), new Guid("eb659df6-0bd3-45ea-a8c9-8d745a1d1b36"), new DateTime(2023, 2, 20, 19, 54, 56, 65, DateTimeKind.Local).AddTicks(1404), "Voluptatum corporis nihil molestiae quia est omnis.", "molestias" },
                    { new Guid("672ba8ef-ce68-475f-af74-6d75dfb9474c"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2022, 8, 25, 9, 25, 43, 859, DateTimeKind.Local).AddTicks(177), "Non dolorem eum incidunt necessitatibus corporis facere pariatur.\nAccusantium eum consequatur laudantium officia est commodi amet doloribus et.", "voluptas" },
                    { new Guid("731e3fc1-f37a-48fc-a3b3-f67c25766f85"), new Guid("3c0fb448-22bc-40ec-8d3d-3425f5bb070c"), new DateTime(2022, 6, 20, 20, 23, 7, 385, DateTimeKind.Local).AddTicks(9171), "Corrupti temporibus qui rerum voluptatem sit.\nCorrupti et ipsum harum maxime.\nVelit ut at in.\nCumque et hic eos ipsum nihil quidem.\nIste molestias totam.", "suscipit" },
                    { new Guid("79e013cd-c3ec-4843-9cdd-39aef9183984"), new Guid("3c0fb448-22bc-40ec-8d3d-3425f5bb070c"), new DateTime(2022, 6, 10, 1, 39, 58, 219, DateTimeKind.Local).AddTicks(5075), "adipisci", "ratione" },
                    { new Guid("7ecf98bb-d716-458e-ba90-53a29b7fe0fa"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2023, 4, 14, 10, 44, 8, 172, DateTimeKind.Local).AddTicks(7521), "Doloremque ipsam ut iure expedita.", "delectus" },
                    { new Guid("8876f1ac-d54a-4e8b-8045-00465428a495"), new Guid("d8bc610a-022c-4590-9283-c77ba502332d"), new DateTime(2022, 11, 12, 13, 31, 28, 196, DateTimeKind.Local).AddTicks(311), "ut", "excepturi" },
                    { new Guid("8a8dfd87-9c42-4a28-b2f9-e08c3e193836"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2022, 6, 16, 14, 17, 15, 27, DateTimeKind.Local).AddTicks(4787), "rem", "totam" },
                    { new Guid("91c6e75b-4e89-4712-8f46-73f61b5b11e5"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2022, 6, 22, 21, 37, 37, 755, DateTimeKind.Local).AddTicks(9464), "Quia facilis labore aut.\nAmet aliquid temporibus eligendi blanditiis voluptas vero rerum iure minima.\nExpedita et laborum.\nSit voluptatem beatae.\nQuisquam aliquid nobis veniam aut.\nVoluptatum non omnis.", "facere" },
                    { new Guid("95fd23df-173c-40b7-bf5d-db00effdaa97"), new Guid("3c0fb448-22bc-40ec-8d3d-3425f5bb070c"), new DateTime(2022, 8, 13, 15, 54, 34, 99, DateTimeKind.Local).AddTicks(2191), "Dolores adipisci saepe eius. Porro fugiat accusamus dolor voluptatem occaecati voluptatum cupiditate nam eveniet. Officia sit sequi. Laudantium soluta ab. Quis sit perspiciatis.", "ea" },
                    { new Guid("a7c2c267-2d07-45e7-9176-0d21bcfb8dd0"), new Guid("d8bc610a-022c-4590-9283-c77ba502332d"), new DateTime(2022, 12, 18, 22, 15, 55, 38, DateTimeKind.Local).AddTicks(5778), "dolorem", "quia" },
                    { new Guid("aae6bd3c-4836-4b98-9dce-1d6731d171b5"), new Guid("eb659df6-0bd3-45ea-a8c9-8d745a1d1b36"), new DateTime(2023, 4, 12, 18, 28, 12, 190, DateTimeKind.Local).AddTicks(9708), "Totam quis quisquam rem inventore excepturi quia molestiae. Ipsa qui voluptas. Aliquid officiis consectetur omnis quia doloremque commodi. Et vel nihil. Fuga animi unde facilis.", "aut" },
                    { new Guid("b457e91e-5486-4ff3-b8dc-81edecdab9ac"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2023, 4, 5, 10, 21, 32, 273, DateTimeKind.Local).AddTicks(3906), "Minus dolorem quos quia.", "ut" },
                    { new Guid("b60625ce-9604-4393-a486-5c599550661f"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2022, 12, 13, 13, 55, 33, 245, DateTimeKind.Local).AddTicks(459), "At ad laborum vero sint exercitationem sapiente voluptatem qui.", "et" },
                    { new Guid("bfb55c6e-54da-49a1-bb5d-4298b2e413c5"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2023, 1, 23, 0, 2, 53, 663, DateTimeKind.Local).AddTicks(7985), "Quo harum aut est quia aliquam unde nihil sed veniam. Ullam velit iste tempora nam et ad maxime atque alias. Ipsam libero cum est ut quam vero fugiat. Tempore sit reprehenderit adipisci exercitationem in sequi ducimus quis. Vel et molestiae et. Voluptatum eos rerum est dolor ipsam enim explicabo velit reprehenderit.", "provident" },
                    { new Guid("ceaffe91-3d80-42e4-ba12-229c9f62c4d3"), new Guid("30359c4f-3866-49de-9287-55a59ef2c8e1"), new DateTime(2023, 2, 26, 19, 27, 5, 7, DateTimeKind.Local).AddTicks(9231), "Debitis asperiores quia quisquam ut reprehenderit est hic ipsum.", "ut" },
                    { new Guid("d5441f41-d897-41b1-a006-a893b5af8ff3"), new Guid("eb659df6-0bd3-45ea-a8c9-8d745a1d1b36"), new DateTime(2022, 11, 13, 5, 1, 52, 403, DateTimeKind.Local).AddTicks(1872), "laudantium", "sit" },
                    { new Guid("f5b01151-5574-4f5e-aa3f-24507e689cbc"), new Guid("d8bc610a-022c-4590-9283-c77ba502332d"), new DateTime(2022, 9, 8, 11, 42, 6, 210, DateTimeKind.Local).AddTicks(498), "Praesentium ipsa voluptatum officiis et molestiae aut earum.", "et" },
                    { new Guid("f67ab578-eba2-4420-8187-a2ace9173f79"), new Guid("3c0fb448-22bc-40ec-8d3d-3425f5bb070c"), new DateTime(2022, 8, 19, 20, 6, 0, 204, DateTimeKind.Local).AddTicks(825), "cupiditate", "est" }
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Replies",
                columns: new[] { "ID", "ReplyCommentId", "ReplyPostDate", "ReplyText" },
                values: new object[,]
                {
                    { new Guid("0331ea63-f4cb-4311-adb8-bfc64231b103"), new Guid("06493211-65f5-4046-9883-905d0ef242e3"), new DateTime(2023, 1, 13, 13, 32, 19, 280, DateTimeKind.Local).AddTicks(1839), "voluptatem" },
                    { new Guid("0944be8c-91be-40a7-b58f-7ede6134d7eb"), new Guid("1d238f4d-43b1-4aff-87fc-8c5001fba1ec"), new DateTime(2022, 8, 1, 14, 8, 3, 128, DateTimeKind.Local).AddTicks(4203), "aut" },
                    { new Guid("13813ba8-c4e2-4c0e-b935-58b3e1caaa05"), new Guid("3bf064ca-06a8-4283-94e1-408d9c3b7c6e"), new DateTime(2022, 7, 17, 10, 9, 30, 33, DateTimeKind.Local).AddTicks(9105), "Tempore modi minima debitis saepe dolorum minima amet." },
                    { new Guid("22cf90ec-1564-4a91-990b-865627df0848"), new Guid("aae6bd3c-4836-4b98-9dce-1d6731d171b5"), new DateTime(2022, 8, 3, 9, 44, 22, 987, DateTimeKind.Local).AddTicks(2024), "Repudiandae quia tempore repudiandae qui dignissimos. Aut ut est et repellendus sed dolores deleniti provident praesentium. Eos ducimus non unde. Harum nihil nihil voluptas molestiae. Earum libero repudiandae odio eos. Ut asperiores sapiente aspernatur et autem." },
                    { new Guid("2977bf9e-0811-48ba-893b-7618b495b113"), new Guid("2f131231-4749-49c1-a46f-323ead41ffeb"), new DateTime(2023, 3, 2, 16, 51, 50, 275, DateTimeKind.Local).AddTicks(86), "Et molestias amet iusto facere.\nAtque voluptas quam expedita minus ut dignissimos et blanditiis.\nVoluptatibus commodi magni omnis ex dolore sed molestiae." },
                    { new Guid("3066c45b-684d-4149-a563-ca58c00074d8"), new Guid("d5441f41-d897-41b1-a006-a893b5af8ff3"), new DateTime(2022, 6, 17, 10, 35, 21, 279, DateTimeKind.Local).AddTicks(7412), "Porro facere et magnam cupiditate.\nRepudiandae est porro aliquid enim blanditiis qui totam.\nEos similique voluptas at nulla id.\nSaepe accusantium facilis autem laborum consequatur quaerat.\nNon quo repellendus exercitationem nemo optio ullam consequatur eius." },
                    { new Guid("34e03478-da7f-4723-a62e-80861a0f7d34"), new Guid("0c653add-f887-4b80-8f5c-74790b5a2521"), new DateTime(2022, 8, 20, 7, 18, 58, 667, DateTimeKind.Local).AddTicks(3383), "Cum animi voluptas beatae minima.\nQui possimus modi ea numquam reiciendis.\nFuga nihil qui cupiditate quam.\nVeritatis repellat qui in impedit ut dolore unde voluptas ea.\nPlaceat dolores exercitationem minima reprehenderit qui eum ut." },
                    { new Guid("437d5bcf-a594-49d7-9440-69198a729956"), new Guid("95fd23df-173c-40b7-bf5d-db00effdaa97"), new DateTime(2022, 12, 12, 0, 36, 24, 667, DateTimeKind.Local).AddTicks(8219), "Voluptas non ratione expedita. Aut necessitatibus iusto temporibus nemo explicabo. Nihil veritatis et sit perferendis. Minima a nam." },
                    { new Guid("5034a53e-9f90-4721-9a95-aded7cb4f6ca"), new Guid("91c6e75b-4e89-4712-8f46-73f61b5b11e5"), new DateTime(2022, 8, 25, 19, 48, 32, 788, DateTimeKind.Local).AddTicks(4596), "Fugit voluptatem facere qui natus.\nNostrum aut pariatur sint voluptas veniam magni.\nUt ea a tenetur et vel ea voluptatem ab voluptates.\nNam magnam quos et nesciunt voluptatem odio at.\nQuis at vero voluptas necessitatibus recusandae quas magnam.\nQuia consectetur occaecati esse enim." },
                    { new Guid("60574cb3-64d5-4735-845f-1895283ec7b7"), new Guid("f5b01151-5574-4f5e-aa3f-24507e689cbc"), new DateTime(2022, 11, 13, 7, 39, 4, 163, DateTimeKind.Local).AddTicks(3729), "Harum dolores architecto repudiandae voluptatem quod laborum debitis nulla libero.\nIpsam dolore consequuntur quae nihil similique mollitia quo.\nQui quisquam illo quasi.\nReprehenderit quo saepe eligendi voluptas vel eum voluptates ipsum.\nFugiat voluptatum est." },
                    { new Guid("615592d2-a310-4c77-a0f7-6a49e15dcc76"), new Guid("647b255f-efc8-43f4-9728-6a974e758f38"), new DateTime(2022, 9, 20, 20, 19, 26, 47, DateTimeKind.Local).AddTicks(9039), "Aut laboriosam et quod dolores illo.\nFuga explicabo et aut." },
                    { new Guid("7255cd49-d83e-43ea-809b-20dece7016c3"), new Guid("223e1904-1761-4389-810e-a78fa930fb0e"), new DateTime(2022, 8, 10, 13, 0, 11, 571, DateTimeKind.Local).AddTicks(5), "Numquam rem eum saepe corporis doloribus.\nIncidunt et vero ullam repellat autem harum voluptates.\nTemporibus nulla reiciendis.\nQuis quia vitae nisi explicabo iusto ut aliquam sed.\nRepudiandae sunt eos ipsum explicabo corrupti ex alias." },
                    { new Guid("89264139-9a57-4de0-9523-85490293532a"), new Guid("bfb55c6e-54da-49a1-bb5d-4298b2e413c5"), new DateTime(2022, 6, 10, 9, 26, 28, 431, DateTimeKind.Local).AddTicks(9316), "Ad ipsam non deleniti praesentium illum sit dolorum illum. Laboriosam debitis delectus natus qui aut officiis ea quae ut. Non minus consequatur earum repellendus laboriosam accusamus dicta itaque porro." },
                    { new Guid("8f13a403-6bd1-4192-a175-c7aa4ee3e04e"), new Guid("7ecf98bb-d716-458e-ba90-53a29b7fe0fa"), new DateTime(2023, 3, 31, 16, 42, 8, 129, DateTimeKind.Local).AddTicks(863), "rerum" },
                    { new Guid("995de2e2-40a2-4296-ba05-e1d8c16bb2d9"), new Guid("3624cbdc-9ec0-4a00-94e2-a98876038bb8"), new DateTime(2023, 2, 4, 10, 51, 6, 628, DateTimeKind.Local).AddTicks(5123), "Blanditiis eum praesentium est qui officiis. Nesciunt id sed officia occaecati dicta et qui tempore cumque. Tempora officia omnis. Enim dolorem sed saepe. Deleniti officia eum magnam repellendus dolores." },
                    { new Guid("9a1ec609-10d3-4ac5-aa1b-cf6f818c9a9b"), new Guid("b457e91e-5486-4ff3-b8dc-81edecdab9ac"), new DateTime(2022, 11, 27, 21, 32, 11, 921, DateTimeKind.Local).AddTicks(5756), "Iure eius et." },
                    { new Guid("9a9b3aa1-c005-47af-860f-807438ca953f"), new Guid("a7c2c267-2d07-45e7-9176-0d21bcfb8dd0"), new DateTime(2022, 6, 1, 16, 29, 20, 229, DateTimeKind.Local).AddTicks(3163), "Pariatur inventore earum dolorem non temporibus molestias expedita excepturi rerum. Sint cum quaerat aut iure. Praesentium quod quia non eius tenetur." },
                    { new Guid("a99f4455-8218-4756-881d-9f19ee03578a"), new Guid("12202a45-0810-45f4-a224-450d51791c28"), new DateTime(2022, 8, 2, 8, 22, 9, 743, DateTimeKind.Local).AddTicks(9316), "Atque molestiae quis laudantium alias.\nOmnis voluptatibus magnam sit sint iste voluptatibus aut.\nSunt vero voluptatibus corporis consequatur tempora vero." },
                    { new Guid("abd18ba2-a436-473e-8c31-618b0b281f0a"), new Guid("5f36b055-9419-422f-bfde-6b5144065814"), new DateTime(2022, 12, 28, 13, 54, 23, 695, DateTimeKind.Local).AddTicks(8040), "Occaecati tempore cumque dolorem placeat facere accusantium qui eligendi error. Molestiae sit eaque et. Quia sed voluptas illum." },
                    { new Guid("af583468-55bf-4db5-bfcd-2f1e0a0e7fb0"), new Guid("79e013cd-c3ec-4843-9cdd-39aef9183984"), new DateTime(2022, 10, 12, 17, 34, 7, 114, DateTimeKind.Local).AddTicks(6420), "Iste dolorem molestiae quaerat iusto inventore ipsa." },
                    { new Guid("b1e30d0d-8738-4c1e-a05a-bc388529c042"), new Guid("49939c8e-b4ef-45c9-bf6a-e5133fb22b6f"), new DateTime(2023, 2, 2, 14, 19, 54, 298, DateTimeKind.Local).AddTicks(8700), "Quo magnam molestiae saepe aut.\nCorrupti vel quo aut aut eligendi dolores.\nAssumenda consequatur hic aut.\nExplicabo et ut.\nEius eius ipsa fuga laudantium et dolor vel." },
                    { new Guid("bccc7f35-958d-4cef-a60c-3c4c3b5e34fa"), new Guid("f67ab578-eba2-4420-8187-a2ace9173f79"), new DateTime(2022, 6, 2, 22, 53, 5, 775, DateTimeKind.Local).AddTicks(1091), "Ut voluptatem molestias. Autem nobis in sit culpa est. In hic eaque voluptas dicta sit est. Rem nulla cumque quia corrupti earum et et et atque. Enim eum blanditiis vitae quo reprehenderit. Totam earum ex magni et sed dolorem cum quia." },
                    { new Guid("c6bad041-74e2-48b8-8b8f-c7fb96be9056"), new Guid("b60625ce-9604-4393-a486-5c599550661f"), new DateTime(2023, 4, 19, 15, 15, 22, 784, DateTimeKind.Local).AddTicks(9145), "Repellendus non ullam et sed." },
                    { new Guid("cffb0017-200a-430c-b765-533e11b8ec3b"), new Guid("5b52430a-2018-4f6f-9c15-986c92bd47fd"), new DateTime(2023, 2, 6, 22, 45, 4, 141, DateTimeKind.Local).AddTicks(5092), "Facere soluta qui.\nCulpa magni ut omnis asperiores illo cumque.\nNatus voluptatem et ut fugiat aspernatur sunt est.\nDeserunt eos voluptas omnis.\nAut voluptatem reiciendis odio." },
                    { new Guid("d224b21f-288e-4d0b-8130-c19e4316a516"), new Guid("672ba8ef-ce68-475f-af74-6d75dfb9474c"), new DateTime(2023, 3, 18, 5, 9, 51, 231, DateTimeKind.Local).AddTicks(8722), "Qui placeat quam asperiores eaque consequatur beatae explicabo. Id a quaerat. Rem nihil non qui accusamus magnam incidunt voluptates ipsam fugiat. Soluta aspernatur doloribus praesentium corrupti. Molestiae dolorem numquam." },
                    { new Guid("dd92bec2-34e3-41db-bc2f-59829f4cfa00"), new Guid("4a800614-fb3f-4b84-a8d2-6dd27a766cca"), new DateTime(2023, 2, 6, 23, 54, 47, 752, DateTimeKind.Local).AddTicks(5431), "fugit" },
                    { new Guid("e2cd960d-5fe3-4e81-ab28-da18fe9c784f"), new Guid("8876f1ac-d54a-4e8b-8045-00465428a495"), new DateTime(2022, 11, 23, 20, 53, 12, 708, DateTimeKind.Local).AddTicks(8036), "Libero possimus quo exercitationem unde." },
                    { new Guid("e66a48e4-c038-49a1-920e-db18c9336540"), new Guid("731e3fc1-f37a-48fc-a3b3-f67c25766f85"), new DateTime(2022, 12, 19, 15, 0, 45, 889, DateTimeKind.Local).AddTicks(1757), "Tenetur aut quae aut ut odio et autem aut." },
                    { new Guid("f279be5b-2d02-4e6e-bb1f-91c541c67be9"), new Guid("8a8dfd87-9c42-4a28-b2f9-e08c3e193836"), new DateTime(2022, 10, 20, 20, 2, 59, 444, DateTimeKind.Local).AddTicks(9355), "Reprehenderit iste ex mollitia sed debitis animi et.\nQuas quod autem tempora.\nCommodi nulla ullam et iste enim." },
                    { new Guid("f31ef23b-2e9e-498a-bed7-5bf4ec54206e"), new Guid("ceaffe91-3d80-42e4-ba12-229c9f62c4d3"), new DateTime(2022, 7, 15, 14, 35, 53, 473, DateTimeKind.Local).AddTicks(7064), "Fugiat quis deleniti eos sed odio odit ut. Eum porro rerum omnis facilis est. Voluptatem vel ipsum debitis soluta aut quasi dignissimos error id." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentFeedbackId",
                schema: "Comments",
                table: "Comments",
                column: "CommentFeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_ReplyCommentId",
                schema: "Comments",
                table: "Replies",
                column: "ReplyCommentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Replies",
                schema: "Comments");

            migrationBuilder.DropTable(
                name: "Comments",
                schema: "Comments");

            migrationBuilder.DropTable(
                name: "Feedbacks",
                schema: "Comments");
        }
    }
}
