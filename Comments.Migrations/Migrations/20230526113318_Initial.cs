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
                    CommentPostDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 26, 14, 33, 18, 180, DateTimeKind.Local).AddTicks(3198)),
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
                    ReplyPostDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 26, 14, 33, 18, 182, DateTimeKind.Local).AddTicks(3809)),
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
                    { new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), "LoveIt" },
                    { new Guid("9d9d989c-3785-4068-895d-27ab2531d12b"), "Issue" },
                    { new Guid("a76b2a22-eabd-4bcd-a3f5-e18d27d23e1e"), "Comment" },
                    { new Guid("fddb8aa4-82c2-4968-9547-93bf228aee6a"), "Suggestion" }
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Comments",
                columns: new[] { "ID", "CommentFeedbackId", "CommentPostDate", "CommentText", "CommentTheme" },
                values: new object[,]
                {
                    { new Guid("05f7b036-78b9-4439-86f4-f314536d572c"), new Guid("9d9d989c-3785-4068-895d-27ab2531d12b"), new DateTime(2022, 10, 23, 6, 19, 24, 693, DateTimeKind.Local).AddTicks(5229), "Recusandae est in consequatur accusantium aut non.\nBeatae et fugit ab.\nEt consequatur consequatur voluptatem.\nQuo ducimus sed debitis consequuntur.\nVoluptas aliquam optio deleniti ut eveniet vitae odit.", "modi" },
                    { new Guid("0cbe2b7f-037a-45a2-b3c3-422f16a7c455"), new Guid("fddb8aa4-82c2-4968-9547-93bf228aee6a"), new DateTime(2022, 6, 14, 11, 28, 27, 939, DateTimeKind.Local).AddTicks(6613), "Et quo eveniet nemo.\nEt nostrum enim.", "quam" },
                    { new Guid("15eaf0ed-c9f7-49b8-a6e9-52ed7c1554f4"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2023, 4, 26, 6, 15, 6, 330, DateTimeKind.Local).AddTicks(4566), "Quidem illo corporis aut veritatis.", "blanditiis" },
                    { new Guid("26857110-d0db-4b5e-927e-ff5ee050a49b"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2022, 10, 23, 15, 31, 39, 468, DateTimeKind.Local).AddTicks(6660), "Quaerat nobis aut quis magnam aut vero et.\nImpedit illum recusandae nesciunt non quasi placeat.\nPorro beatae qui molestias.\nRepellat totam quaerat quas autem ut numquam.\nEst deserunt optio.", "sequi" },
                    { new Guid("2e007472-dc1b-490b-a8c7-edd143921a50"), new Guid("9d9d989c-3785-4068-895d-27ab2531d12b"), new DateTime(2022, 9, 9, 21, 21, 20, 686, DateTimeKind.Local).AddTicks(9783), "Qui tenetur inventore culpa dicta hic reiciendis accusantium.", "at" },
                    { new Guid("4a60bdfd-94a5-4be4-aa72-77e5fcba2ca6"), new Guid("a76b2a22-eabd-4bcd-a3f5-e18d27d23e1e"), new DateTime(2023, 2, 6, 23, 15, 40, 533, DateTimeKind.Local).AddTicks(9134), "Voluptatem et quidem similique aliquam officiis excepturi eos.", "aut" },
                    { new Guid("51571eed-03e6-4d17-9096-372425c53455"), new Guid("fddb8aa4-82c2-4968-9547-93bf228aee6a"), new DateTime(2023, 3, 21, 8, 12, 43, 222, DateTimeKind.Local).AddTicks(3324), "Consequatur officiis quaerat nemo.\nAliquam molestias voluptate et deserunt et amet sit.\nDolor dolor corrupti quis et qui laboriosam sit.", "voluptatibus" },
                    { new Guid("5547a2f5-64bf-4ebd-bd54-d6d5f1496073"), new Guid("fddb8aa4-82c2-4968-9547-93bf228aee6a"), new DateTime(2023, 4, 14, 22, 59, 10, 615, DateTimeKind.Local).AddTicks(7288), "Cumque occaecati odit beatae aspernatur.", "iste" },
                    { new Guid("5975090f-8d4d-4173-8f02-1eb254eba791"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2022, 8, 2, 17, 44, 24, 713, DateTimeKind.Local).AddTicks(7985), "Qui doloremque esse dolorem.\nVoluptas eum sit.\nPorro unde dolorum necessitatibus hic adipisci quia dolorem.\nOfficiis et totam.\nCupiditate repellendus dolores laborum ea enim sed molestiae ut.\nConsequatur quisquam velit praesentium soluta.", "maiores" },
                    { new Guid("613ae13f-ba26-41d0-9825-e95eeaed21b2"), new Guid("a76b2a22-eabd-4bcd-a3f5-e18d27d23e1e"), new DateTime(2022, 11, 26, 18, 0, 39, 548, DateTimeKind.Local).AddTicks(8892), "Dicta ut rerum rerum vitae repellendus et molestiae libero.\nIusto tempore quam sunt et rerum omnis consectetur quo.\nIllum est quibusdam facilis non ullam corrupti sequi.", "quibusdam" },
                    { new Guid("64bee9c9-fab9-484f-a93a-254be91e6c59"), new Guid("fddb8aa4-82c2-4968-9547-93bf228aee6a"), new DateTime(2022, 11, 29, 8, 21, 31, 780, DateTimeKind.Local).AddTicks(1368), "Incidunt numquam officiis ratione eum aut est.\nQuia possimus molestiae itaque pariatur adipisci dicta id.", "minus" },
                    { new Guid("64e40013-05b7-4901-b563-b1f9f2daec5e"), new Guid("fddb8aa4-82c2-4968-9547-93bf228aee6a"), new DateTime(2023, 5, 13, 18, 49, 36, 174, DateTimeKind.Local).AddTicks(8431), "Quae unde ut dolorem sunt. Ut delectus nostrum ex velit id iste ea. Ipsam ut unde ratione incidunt illo neque illum consequatur. Qui distinctio aperiam natus.", "occaecati" },
                    { new Guid("65b7c646-3aad-4c23-b7c8-3523ba14bf72"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2023, 5, 10, 13, 25, 8, 544, DateTimeKind.Local).AddTicks(5215), "suscipit", "excepturi" },
                    { new Guid("69eed741-64ec-4426-9035-2c4a2983c21e"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2022, 9, 8, 16, 21, 23, 71, DateTimeKind.Local).AddTicks(9921), "Rerum quaerat harum doloribus reiciendis omnis ut. Et qui nisi libero velit deserunt et ut atque. Nam temporibus dolores et dicta nemo sint. Omnis neque consequatur minus dolores exercitationem alias explicabo. Ut provident id modi officia officiis perferendis. Et consequatur dolores dolores corrupti modi ea fuga quasi.", "est" },
                    { new Guid("6e11b813-13fa-47f0-baed-1e9afb259c93"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2023, 2, 5, 17, 5, 3, 945, DateTimeKind.Local).AddTicks(4080), "possimus", "in" },
                    { new Guid("8e38cfbf-e27d-4818-a31e-c81c99a81d59"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2023, 4, 1, 6, 18, 35, 576, DateTimeKind.Local).AddTicks(9268), "Nihil qui voluptatum quia sit nesciunt quidem et nulla. Deleniti modi quas blanditiis esse suscipit veniam ipsam corporis soluta. Veritatis maiores voluptatum et nobis est error ea esse. Odio in qui ipsam unde veniam.", "dignissimos" },
                    { new Guid("9260eb42-cdd7-4703-bcb7-a99c7cfdd8b7"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2023, 4, 23, 13, 34, 9, 43, DateTimeKind.Local).AddTicks(8569), "Repellendus dignissimos dolore at.\nRerum similique soluta ipsa et est.\nAliquid ad ut quos quaerat culpa.", "officiis" },
                    { new Guid("9aab4bbf-79c6-4326-8588-a4060346c48b"), new Guid("fddb8aa4-82c2-4968-9547-93bf228aee6a"), new DateTime(2022, 8, 28, 14, 52, 30, 14, DateTimeKind.Local).AddTicks(1157), "Dolores nemo eos qui corrupti voluptas impedit enim.\nQuos molestias voluptatem eum.\nIste nemo cumque quia ut quia non omnis.\nAb ipsum id.", "in" },
                    { new Guid("a0272ada-4d13-4332-9eb4-b219e01c2519"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2022, 12, 26, 19, 53, 34, 378, DateTimeKind.Local).AddTicks(8855), "Sed iusto alias recusandae rerum.\nEveniet recusandae cupiditate quia accusantium deserunt commodi.\nPlaceat eveniet eum autem.", "perspiciatis" },
                    { new Guid("a3b1c440-1606-4f8b-989c-f9e3ea91613f"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2022, 9, 15, 9, 36, 10, 123, DateTimeKind.Local).AddTicks(7606), "veniam", "qui" },
                    { new Guid("a9ffbb66-1777-4d8a-8b3c-88678bcecab8"), new Guid("9d9d989c-3785-4068-895d-27ab2531d12b"), new DateTime(2023, 3, 12, 0, 46, 51, 614, DateTimeKind.Local).AddTicks(715), "Laborum aut veniam qui dolorem magni cumque porro.\nQuia cumque sint esse.\nEum velit nihil dolores excepturi.\nUt porro nisi.", "deserunt" },
                    { new Guid("acbfc143-4a90-4155-a717-c2f7a6dbd9d4"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2023, 5, 17, 2, 55, 50, 346, DateTimeKind.Local).AddTicks(4958), "Quaerat est et assumenda.\nQuae nulla porro voluptatem exercitationem quasi illum consequatur omnis.\nAliquam vitae iste placeat eligendi.\nQuidem possimus et debitis voluptas.\nConsequuntur consectetur praesentium aut rerum qui veniam consequuntur consequatur enim.", "qui" },
                    { new Guid("bd88b5c9-c884-49a8-a9b4-c144d3e803df"), new Guid("fddb8aa4-82c2-4968-9547-93bf228aee6a"), new DateTime(2023, 5, 17, 0, 0, 41, 234, DateTimeKind.Local).AddTicks(9226), "Non natus id.\nCumque possimus enim iure rerum nobis.\nOdio commodi tempore ut aut facilis et vero.\nVoluptatibus pariatur ex voluptatem exercitationem quae rerum iure.", "hic" },
                    { new Guid("cd5100d7-f042-4ded-8ded-dd2d671a5b93"), new Guid("9d9d989c-3785-4068-895d-27ab2531d12b"), new DateTime(2023, 5, 20, 18, 45, 3, 818, DateTimeKind.Local).AddTicks(713), "Autem ducimus ducimus.", "omnis" },
                    { new Guid("d1ac6890-9992-4c3d-b02b-51b782407fdf"), new Guid("9d9d989c-3785-4068-895d-27ab2531d12b"), new DateTime(2022, 11, 27, 8, 35, 36, 651, DateTimeKind.Local).AddTicks(3284), "Natus dicta sed delectus accusamus qui est molestiae possimus exercitationem.", "et" },
                    { new Guid("d21e44bf-e8f5-4e10-82bf-be7b090b4d54"), new Guid("9d9d989c-3785-4068-895d-27ab2531d12b"), new DateTime(2022, 10, 6, 13, 9, 18, 964, DateTimeKind.Local).AddTicks(33), "Molestias non qui ea rem earum sit architecto ipsum.\nVoluptates dolorem rem est voluptates.", "placeat" },
                    { new Guid("e086b092-07cc-4cb1-9ceb-000672c28796"), new Guid("a76b2a22-eabd-4bcd-a3f5-e18d27d23e1e"), new DateTime(2022, 8, 31, 22, 14, 22, 820, DateTimeKind.Local).AddTicks(5559), "Numquam laboriosam nemo placeat minus ducimus sit alias ut. Sit totam illum rerum suscipit natus. Magni corrupti distinctio laborum consequatur ut.", "ut" },
                    { new Guid("f3099c27-22ce-4b82-960a-714b5ff0a355"), new Guid("a76b2a22-eabd-4bcd-a3f5-e18d27d23e1e"), new DateTime(2022, 9, 29, 9, 13, 49, 174, DateTimeKind.Local).AddTicks(1005), "Sint aut corrupti distinctio nulla et ad qui cupiditate.", "magnam" },
                    { new Guid("f5ea452f-7503-4183-8509-bc20f8a14ca2"), new Guid("69d4a452-b1f6-43bd-adcc-a395286c37fb"), new DateTime(2022, 8, 9, 8, 1, 27, 387, DateTimeKind.Local).AddTicks(3904), "Consequatur consequatur perferendis itaque ullam. Expedita deserunt exercitationem. Quas in voluptates voluptatum laborum cumque voluptate assumenda dolorem unde. Perferendis dolorem enim non modi odit eligendi consectetur. Sunt praesentium at officia necessitatibus molestias similique sed. Voluptatum modi porro amet hic nesciunt tempore itaque labore placeat.", "nulla" },
                    { new Guid("fbc18a39-f5f5-4aa1-a614-9d341a025a97"), new Guid("a76b2a22-eabd-4bcd-a3f5-e18d27d23e1e"), new DateTime(2022, 8, 9, 15, 46, 24, 260, DateTimeKind.Local).AddTicks(6566), "Voluptate quis consectetur quos magnam illo ut autem omnis expedita.\nMollitia culpa ratione nisi nesciunt voluptas modi et qui.\nEaque sit similique voluptatem.", "voluptatem" }
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Replies",
                columns: new[] { "ID", "ReplyCommentId", "ReplyPostDate", "ReplyText" },
                values: new object[,]
                {
                    { new Guid("14e3c381-5157-4576-b585-ef2e4f5da6df"), new Guid("69eed741-64ec-4426-9035-2c4a2983c21e"), new DateTime(2022, 7, 25, 11, 46, 58, 802, DateTimeKind.Local).AddTicks(5884), "Culpa itaque qui voluptate velit consequatur ullam aperiam quia. Qui sed ratione id quia sit et. Neque eum eligendi eligendi aliquid quos culpa dicta ad. Nulla accusamus deserunt consequuntur et." },
                    { new Guid("17a22900-aa0a-4e10-b1e4-c3bef90f4af3"), new Guid("f5ea452f-7503-4183-8509-bc20f8a14ca2"), new DateTime(2022, 7, 31, 12, 9, 21, 884, DateTimeKind.Local).AddTicks(1435), "Quae aut commodi non ipsum iure sed occaecati vitae.\nDoloribus iusto praesentium reiciendis libero est libero.\nNon facere ut occaecati molestias ex dolorem fugit laborum.\nReiciendis quaerat est dolor et consequatur velit ut vitae.\nEnim tempore velit fugiat explicabo sit." },
                    { new Guid("225a1a90-8d67-479c-9386-c7b5a1d58356"), new Guid("64e40013-05b7-4901-b563-b1f9f2daec5e"), new DateTime(2022, 9, 25, 22, 35, 28, 528, DateTimeKind.Local).AddTicks(1056), "molestiae" },
                    { new Guid("3081679f-8707-4f88-b344-d7ee0a09dd29"), new Guid("65b7c646-3aad-4c23-b7c8-3523ba14bf72"), new DateTime(2022, 7, 31, 15, 53, 44, 914, DateTimeKind.Local).AddTicks(7610), "quas" },
                    { new Guid("32907e92-1d22-451d-a33c-aea9390957fa"), new Guid("cd5100d7-f042-4ded-8ded-dd2d671a5b93"), new DateTime(2022, 5, 31, 10, 55, 15, 345, DateTimeKind.Local).AddTicks(4636), "Accusamus inventore voluptatem et officia accusamus beatae deleniti est voluptate." },
                    { new Guid("33edcda5-25a9-45d2-ac00-aa7437b70f89"), new Guid("e086b092-07cc-4cb1-9ceb-000672c28796"), new DateTime(2023, 5, 14, 8, 15, 18, 263, DateTimeKind.Local).AddTicks(3604), "Nisi dolores sed est facere molestiae minus earum.\nVoluptatem numquam et eaque sit ducimus omnis dolore dolores eveniet.\nEst rerum velit in vitae.\nDoloremque explicabo libero consequuntur similique repellat aut ea enim." },
                    { new Guid("3e88f9ce-0a17-4ef8-8763-b355bc1ebcb7"), new Guid("a9ffbb66-1777-4d8a-8b3c-88678bcecab8"), new DateTime(2022, 9, 4, 21, 10, 16, 353, DateTimeKind.Local).AddTicks(3480), "Autem eaque dolorum suscipit non perferendis rerum laudantium consequuntur voluptas.\nFacere nam quis beatae laboriosam veritatis.\nVel quia nisi et numquam.\nSed laborum fuga dolorem occaecati beatae labore." },
                    { new Guid("42298e08-3c7b-4404-9319-fc317e1afab6"), new Guid("9aab4bbf-79c6-4326-8588-a4060346c48b"), new DateTime(2022, 6, 7, 9, 29, 21, 940, DateTimeKind.Local).AddTicks(4566), "Architecto ut debitis ea consequatur est quo.\nQui sint cupiditate sint et corrupti culpa veritatis reprehenderit." },
                    { new Guid("42943998-84e9-4d4a-b8c2-a8d30f77c261"), new Guid("613ae13f-ba26-41d0-9825-e95eeaed21b2"), new DateTime(2023, 2, 3, 8, 10, 33, 70, DateTimeKind.Local).AddTicks(2142), "unde" },
                    { new Guid("4466bbd3-b641-482a-8d53-92f3e1ea22ee"), new Guid("6e11b813-13fa-47f0-baed-1e9afb259c93"), new DateTime(2023, 2, 19, 9, 43, 39, 936, DateTimeKind.Local).AddTicks(6983), "Possimus ab molestiae eum qui facilis non incidunt." },
                    { new Guid("4b1b746f-274c-4e48-9ef2-536c76e8cbc6"), new Guid("64bee9c9-fab9-484f-a93a-254be91e6c59"), new DateTime(2022, 7, 16, 12, 57, 18, 873, DateTimeKind.Local).AddTicks(2914), "Sequi neque officia temporibus quaerat laboriosam et et ut." },
                    { new Guid("5ad7d4e8-3bbe-4182-ad98-26edb71ce253"), new Guid("a0272ada-4d13-4332-9eb4-b219e01c2519"), new DateTime(2023, 3, 29, 18, 20, 16, 567, DateTimeKind.Local).AddTicks(4013), "Eveniet et dolores et eos asperiores." },
                    { new Guid("5ec68327-2e64-4651-88d4-4e6af7eb5007"), new Guid("f3099c27-22ce-4b82-960a-714b5ff0a355"), new DateTime(2022, 8, 25, 23, 22, 42, 885, DateTimeKind.Local).AddTicks(1180), "Magni aut voluptatem repellat. Aliquid dolores et molestiae facere et a recusandae. Odit voluptatem laudantium dolor ratione voluptatem voluptas." },
                    { new Guid("7bc72b89-a68d-4264-a766-7e5e41af5e3c"), new Guid("0cbe2b7f-037a-45a2-b3c3-422f16a7c455"), new DateTime(2023, 4, 4, 13, 39, 12, 43, DateTimeKind.Local).AddTicks(964), "Voluptatibus consequatur dolore sunt aperiam." },
                    { new Guid("85f6a96a-7cc6-4321-a546-cf46345c63fb"), new Guid("4a60bdfd-94a5-4be4-aa72-77e5fcba2ca6"), new DateTime(2022, 7, 2, 19, 15, 29, 844, DateTimeKind.Local).AddTicks(1489), "architecto" },
                    { new Guid("8e9a8646-c6df-4372-8d1e-26dc5779cd5d"), new Guid("fbc18a39-f5f5-4aa1-a614-9d341a025a97"), new DateTime(2023, 5, 5, 18, 43, 20, 564, DateTimeKind.Local).AddTicks(4575), "Vero qui non sed et quia nostrum.\nRecusandae natus adipisci ipsum et laboriosam maxime quo quia." },
                    { new Guid("99b6e951-59fb-41e6-b2c4-bedd622abed6"), new Guid("bd88b5c9-c884-49a8-a9b4-c144d3e803df"), new DateTime(2023, 5, 8, 3, 1, 58, 162, DateTimeKind.Local).AddTicks(3545), "Magnam voluptates nam nihil autem.\nQuis laboriosam veniam quo nisi sit.\nExpedita similique ullam sint et repellat voluptatem." },
                    { new Guid("9e1ed3ff-5380-4f95-9874-09c18bea2220"), new Guid("acbfc143-4a90-4155-a717-c2f7a6dbd9d4"), new DateTime(2023, 1, 30, 8, 35, 36, 287, DateTimeKind.Local).AddTicks(1520), "assumenda" },
                    { new Guid("aa3efa60-81b9-4c1d-abce-25d4ebafc889"), new Guid("d21e44bf-e8f5-4e10-82bf-be7b090b4d54"), new DateTime(2023, 1, 5, 1, 16, 49, 853, DateTimeKind.Local).AddTicks(6501), "Et ipsum doloremque ab repellat id libero quasi quae praesentium." },
                    { new Guid("acdd613d-1045-43f0-8f8f-f82eb6925a43"), new Guid("5975090f-8d4d-4173-8f02-1eb254eba791"), new DateTime(2022, 12, 9, 18, 40, 50, 589, DateTimeKind.Local).AddTicks(9900), "fuga" },
                    { new Guid("b2d735f2-a9b5-4945-8cb0-d8a0358bb628"), new Guid("2e007472-dc1b-490b-a8c7-edd143921a50"), new DateTime(2022, 7, 21, 7, 46, 1, 39, DateTimeKind.Local).AddTicks(5205), "Mollitia vel reprehenderit qui quos totam blanditiis rerum ab autem. Et nemo tempore maxime dolor dicta ea. Molestiae quibusdam neque. Ipsam totam et quae. Quia quam voluptatum quisquam ipsam ut tenetur ad fugit. Rerum error tempore distinctio accusantium ipsam earum et ipsum consequatur." },
                    { new Guid("b39c85da-f008-408c-b5bd-4b6282074bdf"), new Guid("26857110-d0db-4b5e-927e-ff5ee050a49b"), new DateTime(2022, 11, 16, 9, 39, 1, 546, DateTimeKind.Local).AddTicks(3191), "Aliquam quia ut.\nNon numquam dolorem.\nRepellat atque possimus impedit est pariatur voluptas est aut.\nUt aut molestiae quia debitis et dolorem ea tempora facere." },
                    { new Guid("bd096b23-ca26-454b-8757-538b90d700d2"), new Guid("9260eb42-cdd7-4703-bcb7-a99c7cfdd8b7"), new DateTime(2023, 3, 20, 12, 10, 53, 28, DateTimeKind.Local).AddTicks(8163), "Omnis non et dignissimos sapiente perferendis cupiditate eaque blanditiis.\nCorrupti qui aut et." },
                    { new Guid("c326b8be-6ac9-4e89-93f3-67ce9046e800"), new Guid("51571eed-03e6-4d17-9096-372425c53455"), new DateTime(2022, 10, 25, 15, 42, 48, 193, DateTimeKind.Local).AddTicks(4656), "Suscipit enim ut earum voluptas dolorum delectus esse et commodi." },
                    { new Guid("d9a3db28-4ab0-4f2a-a5b9-51f64e29a361"), new Guid("d1ac6890-9992-4c3d-b02b-51b782407fdf"), new DateTime(2023, 3, 6, 13, 3, 9, 527, DateTimeKind.Local).AddTicks(5983), "voluptatem" },
                    { new Guid("dbf03d06-a5a7-4cb1-a1ce-0669d784c58e"), new Guid("5547a2f5-64bf-4ebd-bd54-d6d5f1496073"), new DateTime(2022, 6, 9, 10, 32, 27, 190, DateTimeKind.Local).AddTicks(6926), "Atque necessitatibus modi.\nExpedita eum voluptas perferendis ab in temporibus qui ea tenetur.\nQuia neque et voluptas fuga numquam repudiandae fugit quod.\nSit ratione delectus possimus est quidem odit ducimus." },
                    { new Guid("e1ff0edf-a791-4b96-9872-1f909530de25"), new Guid("05f7b036-78b9-4439-86f4-f314536d572c"), new DateTime(2023, 2, 5, 11, 34, 0, 994, DateTimeKind.Local).AddTicks(7902), "Velit sit minima explicabo molestiae autem non id. Aliquam possimus repellendus deleniti doloribus asperiores. Est et iusto at iusto accusamus sit dolorem in. Enim est velit ut nam dolorem. Ea sed omnis totam. Earum officia magnam ut a sapiente corrupti." },
                    { new Guid("e2daf5da-919c-482a-bb06-a17bf46e4675"), new Guid("a3b1c440-1606-4f8b-989c-f9e3ea91613f"), new DateTime(2022, 6, 16, 0, 51, 31, 146, DateTimeKind.Local).AddTicks(7997), "Velit quod sit quos est perferendis dignissimos quis rerum voluptatem." },
                    { new Guid("e6e654b9-afb8-4fd9-9b05-0f68252d99a2"), new Guid("8e38cfbf-e27d-4818-a31e-c81c99a81d59"), new DateTime(2023, 4, 18, 9, 56, 43, 855, DateTimeKind.Local).AddTicks(3141), "Ea quo distinctio." },
                    { new Guid("f2ea82f0-5f8a-4c90-90b1-d832ab03fec8"), new Guid("15eaf0ed-c9f7-49b8-a6e9-52ed7c1554f4"), new DateTime(2022, 7, 24, 16, 36, 26, 158, DateTimeKind.Local).AddTicks(3181), "Quis beatae quis. Ea cumque mollitia nostrum eaque asperiores temporibus. Quisquam dolor in est. Assumenda nam ad omnis doloribus facilis eligendi aspernatur distinctio. Accusamus ex dicta quae sequi quo eum et dicta unde." }
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
