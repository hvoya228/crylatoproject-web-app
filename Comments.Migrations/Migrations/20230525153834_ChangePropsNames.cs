using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Comments.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class ChangePropsNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Feedbacks_FeedbackId",
                schema: "Comments",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Comments_CommentId",
                schema: "Comments",
                table: "Replies");

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("03d3cfe0-b42e-4033-9ca0-0f1e2cb18a65"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("142a4c7b-dafc-4cd0-9de7-79f4176cc8a3"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("1f1c34c4-331b-478c-b3b5-cd5c486faf27"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("2736375f-2d15-4abf-89d6-bbaeb7575b94"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("346421bc-ca35-4abe-bee1-6b74f58be2a8"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("3eb6b5e2-f602-4d49-a97b-35d931987e82"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("40644db0-f8d4-4e87-943e-eed33256c825"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("4820206e-1cbf-4098-9b60-56cc99a8b753"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("4e5e765d-05b7-450d-9c78-0d5bd48776a4"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("4eab761b-860b-407d-a56e-6b66f1c57f5b"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("6e019b9b-683e-46ec-9951-32e648e5a090"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("74c64464-3eb3-4d85-b98a-bdfc24fb4437"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("80ca66a7-4a43-4dc5-b2e9-9d83aeac89e0"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("923e9cc6-d68c-4244-880e-9a81326b4570"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("98ccffb3-3bf9-4890-8e71-afa37badcfe7"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("9e9160c0-ac53-4766-af24-4057be9be7e3"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("a091e439-1f3e-475f-8f88-ba61cf56cf65"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("afa6f096-db70-436a-84f5-3da975786510"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("b52a4e60-d80d-497c-813a-fed1df055d91"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("b538f6b9-b19b-4053-b499-da794a88fdb1"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("c240b9a1-8271-47b3-a581-9a0312ba70c2"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("c64f7c35-c404-4ac7-9f95-468f535bb74f"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("d41c3c73-4920-448c-9707-82c3a5e3926b"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("d5daa88f-065d-459e-8d63-6d6ce71e1414"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("d728d6b1-89d3-4283-86a8-8eb617968a9b"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("e69c31bd-f613-4db0-ba82-914300bc36c5"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("eb2562d5-336d-4e24-bdf7-5360085bdf42"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("f04793d6-2899-4790-a0fa-84a9dabd6af3"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("f6102b09-1e2f-4306-bf16-ff0fa400146d"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("f92ddac9-7efb-4ab0-ad44-aef3ef86c4c1"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("15e48967-ed7b-4e5d-a321-77590de6537c"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("1bd599a3-2731-4bbe-8524-623d8fb740a0"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("1ed4c36d-328b-47e9-95b8-488bcffd1e1f"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("213d4df5-e3f3-4218-8823-a7dc05ea61a8"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("2bd17bf5-d102-4d60-99da-c0978a2b53ba"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("489638af-43cf-43c5-b460-a8ed51a99f07"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("4af6a591-030f-4623-88d5-8347a416485d"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("576b3ca9-b530-477d-a765-25d76479cb5d"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("5ba48dba-ddbe-4756-84fc-40721b90e925"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("5e3fda18-9542-4d4a-8cc4-fdad379c0311"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("7b58fcff-054a-47b6-8b80-277efd517596"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("895b8b28-17d9-4a8b-952d-b7245e004e1d"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("8d828728-356d-484f-9b35-bfd6c4af4e16"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("97bfdf74-5501-4ee1-9321-9888ea07a3bc"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("a3efc9b3-5e17-47ec-8442-eaff025447d8"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("b2e61069-1a39-467e-a2eb-ebf97a653413"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("b7877d18-4103-493f-87aa-15ed6071387c"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("b9a373bb-ef54-4784-9643-522deaf0c0ae"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("bbeaa05b-ef78-413e-9ea7-95cf760bbb6c"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("bbeb8304-87e9-496e-9c45-986b04711b20"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("bf172b85-cbea-498e-a0ba-7c35d6efeeb5"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("bf2eeaa4-2fdc-49eb-aa14-8ccf4a10dcc9"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("c1b8d33f-4517-4be9-aec3-9e0818070cd5"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("c61e53c9-0f4a-4c03-bce1-b422c40f0ca8"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("d0fe831a-2ac0-4964-b99f-618e448758a8"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("d1bb8ef9-aab4-43ab-a89f-171d9fc3e5e3"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc089c97-35a4-4ddc-aaac-68f57d4859d0"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("e70060dc-d57b-4eb9-82c9-83aced0e28d9"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ea18d609-8114-44f5-aa94-41f6d6e47f6f"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("f9047885-c25a-475d-b1e2-7899c22c5c6a"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Feedbacks",
                keyColumn: "ID",
                keyValue: new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Feedbacks",
                keyColumn: "ID",
                keyValue: new Guid("ba864a71-55a7-4ea8-868a-4a000b0422da"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Feedbacks",
                keyColumn: "ID",
                keyValue: new Guid("d0f1c668-d17d-43f6-b06f-57b4462939c7"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Feedbacks",
                keyColumn: "ID",
                keyValue: new Guid("d7725adf-ba7d-4d7a-9ff6-9ae41c7e4d76"));

            migrationBuilder.RenameColumn(
                name: "Text",
                schema: "Comments",
                table: "Replies",
                newName: "ReplyText");

            migrationBuilder.RenameColumn(
                name: "PostDate",
                schema: "Comments",
                table: "Replies",
                newName: "ReplyPostDate");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                schema: "Comments",
                table: "Replies",
                newName: "ReplyCommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_CommentId",
                schema: "Comments",
                table: "Replies",
                newName: "IX_Replies_ReplyCommentId");

            migrationBuilder.RenameColumn(
                name: "Theme",
                schema: "Comments",
                table: "Comments",
                newName: "CommentTheme");

            migrationBuilder.RenameColumn(
                name: "Text",
                schema: "Comments",
                table: "Comments",
                newName: "CommentText");

            migrationBuilder.RenameColumn(
                name: "PostDate",
                schema: "Comments",
                table: "Comments",
                newName: "CommentPostDate");

            migrationBuilder.RenameColumn(
                name: "FeedbackId",
                schema: "Comments",
                table: "Comments",
                newName: "CommentFeedbackId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_FeedbackId",
                schema: "Comments",
                table: "Comments",
                newName: "IX_Comments_CommentFeedbackId");

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Feedbacks",
                columns: new[] { "ID", "FeedbackTheme" },
                values: new object[,]
                {
                    { new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"), "LoveIt" },
                    { new Guid("9b79c8b2-45c1-498e-802c-45730ed91181"), "Suggestion" },
                    { new Guid("9fa263eb-e0ca-4646-aef8-74f9f5fdb9c4"), "Comment" },
                    { new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"), "Issue" }
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Comments",
                columns: new[] { "ID", "CommentFeedbackId", "CommentPostDate", "CommentText", "CommentTheme" },
                values: new object[,]
                {
                    { new Guid("034dcfe2-f065-4e26-b0d3-8ef3dc29ba50"), new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"), new DateTime(2022, 8, 15, 23, 11, 47, 90, DateTimeKind.Local).AddTicks(1527), "Ducimus ipsa nemo hic accusamus. Placeat ullam dolorem et autem id. Sed amet quis hic ut sunt alias nihil.", "in" },
                    { new Guid("1323d20a-3bfe-4088-9296-2a20e8028bbc"), new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"), new DateTime(2022, 8, 5, 0, 2, 11, 538, DateTimeKind.Local).AddTicks(5147), "Debitis aperiam officia. Sit corrupti accusantium. Alias eum illo illo eos ut accusamus.", "modi" },
                    { new Guid("18611973-ae6e-43e8-bf4d-4a094c88f1ba"), new Guid("9b79c8b2-45c1-498e-802c-45730ed91181"), new DateTime(2022, 8, 23, 5, 24, 43, 257, DateTimeKind.Local).AddTicks(8790), "Consequatur voluptatem eum.\nQui incidunt tempora.\nOptio aspernatur quasi rerum atque laborum.\nUt perspiciatis dicta.", "fuga" },
                    { new Guid("18d81b75-378c-4daa-ba68-e3ce723ae502"), new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"), new DateTime(2023, 5, 19, 1, 17, 23, 166, DateTimeKind.Local).AddTicks(7214), "Natus corporis aut veritatis in sed ea et mollitia.\nConsequatur ut inventore labore.\nEnim eligendi soluta dolor.\nUt amet sed animi deleniti corporis fuga.\nTemporibus ex id dignissimos.", "numquam" },
                    { new Guid("31a55e74-e566-4302-92e4-77b34240637e"), new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"), new DateTime(2023, 4, 1, 11, 57, 30, 628, DateTimeKind.Local).AddTicks(5059), "doloremque", "pariatur" },
                    { new Guid("47cdaa48-c1b6-46b2-a7f2-4781d581da0f"), new Guid("9b79c8b2-45c1-498e-802c-45730ed91181"), new DateTime(2022, 7, 9, 6, 41, 42, 464, DateTimeKind.Local).AddTicks(3651), "ipsum", "ut" },
                    { new Guid("47f55c4b-65bc-43cd-a450-10202006338d"), new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"), new DateTime(2022, 9, 12, 18, 32, 5, 851, DateTimeKind.Local).AddTicks(4316), "Est exercitationem ipsum.", "eveniet" },
                    { new Guid("48c954de-ae23-4759-98fb-0c124bfadc87"), new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"), new DateTime(2023, 3, 9, 23, 29, 12, 201, DateTimeKind.Local).AddTicks(4050), "Qui rerum nesciunt necessitatibus qui velit culpa.", "cupiditate" },
                    { new Guid("4ae7e910-ed61-4852-a80c-e7cd955c5f89"), new Guid("9b79c8b2-45c1-498e-802c-45730ed91181"), new DateTime(2022, 10, 10, 20, 6, 15, 971, DateTimeKind.Local).AddTicks(39), "Et omnis qui aut exercitationem doloribus nemo nostrum est deserunt. In provident aspernatur et. Soluta sit odit.", "eum" },
                    { new Guid("4c4e7eef-ea3e-41ac-bf5a-255a89d7a632"), new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"), new DateTime(2022, 6, 24, 15, 45, 20, 621, DateTimeKind.Local).AddTicks(3013), "Rem ea adipisci animi et facere placeat non et. Dolorem praesentium repellendus tenetur magnam. Repellat dolorum itaque doloremque doloremque blanditiis odit aut nostrum qui. Aut eos deserunt occaecati in commodi pariatur cumque. Minima iusto officia voluptatem ut voluptas.", "minima" },
                    { new Guid("51165c35-e1eb-41c9-965a-045c4bf6dec3"), new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"), new DateTime(2022, 10, 4, 16, 4, 32, 899, DateTimeKind.Local).AddTicks(6893), "Modi et ipsum ea voluptatum quisquam.", "tempora" },
                    { new Guid("516eab17-30f1-401d-af6e-8992f666354e"), new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"), new DateTime(2022, 7, 25, 22, 3, 18, 727, DateTimeKind.Local).AddTicks(8503), "Aut nesciunt aut. Qui voluptatibus sed possimus in ut et deleniti. Magnam itaque corrupti ducimus dignissimos possimus doloremque voluptatem sapiente dolorem. Cum consequatur neque magnam quia sit voluptatem harum. Iure nihil atque. Dolor unde illum expedita reprehenderit rem voluptatem vitae non hic.", "est" },
                    { new Guid("5610e6ef-282c-4be1-828c-57b0b5202d33"), new Guid("9fa263eb-e0ca-4646-aef8-74f9f5fdb9c4"), new DateTime(2022, 11, 3, 12, 11, 32, 137, DateTimeKind.Local).AddTicks(8207), "Dolorem quia iusto cumque blanditiis.", "facilis" },
                    { new Guid("589cbd4c-ce46-4139-bd08-72bdb764de9c"), new Guid("9b79c8b2-45c1-498e-802c-45730ed91181"), new DateTime(2022, 7, 31, 21, 48, 2, 920, DateTimeKind.Local).AddTicks(7459), "Sequi ut sint magnam et.", "molestiae" },
                    { new Guid("6c927d62-9b0b-4e94-b0ea-ea2f6f2178c8"), new Guid("9fa263eb-e0ca-4646-aef8-74f9f5fdb9c4"), new DateTime(2022, 8, 3, 8, 45, 30, 715, DateTimeKind.Local).AddTicks(3177), "Deleniti dolores eum.\nEos qui qui et dolores et ducimus labore dolores.\nQui quas vitae perferendis commodi id.\nQuo dolorum expedita reprehenderit expedita molestias at sint.\nMaiores voluptate similique atque id maiores.", "fugiat" },
                    { new Guid("6e9318f8-1fe8-45ab-b519-ccbb23c73818"), new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"), new DateTime(2022, 9, 9, 3, 29, 36, 684, DateTimeKind.Local).AddTicks(477), "Aperiam soluta dolor hic maiores laboriosam non quasi eos vel. Distinctio et adipisci molestias molestiae in amet fuga consequatur est. Similique deleniti iusto odit. Illo in et. Pariatur perferendis optio. Eos debitis nemo culpa.", "nostrum" },
                    { new Guid("78e5172e-edcf-4a33-a68e-3c882e3ace28"), new Guid("9b79c8b2-45c1-498e-802c-45730ed91181"), new DateTime(2023, 3, 24, 7, 15, 26, 669, DateTimeKind.Local).AddTicks(1967), "dolorum", "quae" },
                    { new Guid("7b632433-ca6d-421d-b3ab-e1daeb6ca005"), new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"), new DateTime(2022, 6, 17, 6, 10, 22, 556, DateTimeKind.Local).AddTicks(8798), "Et et et distinctio amet similique quibusdam. Laboriosam ut eius autem quia. Vitae dolor culpa modi magni corporis id.", "placeat" },
                    { new Guid("81923ef3-6adb-4d51-aace-d671a0382227"), new Guid("9fa263eb-e0ca-4646-aef8-74f9f5fdb9c4"), new DateTime(2022, 10, 24, 18, 53, 24, 498, DateTimeKind.Local).AddTicks(4140), "impedit", "quia" },
                    { new Guid("8c12089f-173f-4012-993b-1088798c4990"), new Guid("9fa263eb-e0ca-4646-aef8-74f9f5fdb9c4"), new DateTime(2022, 7, 18, 0, 55, 24, 422, DateTimeKind.Local).AddTicks(9236), "Voluptatum vel vero dolor quam beatae sed enim.\nEt eligendi at optio vitae.\nPerferendis et ex commodi sed.\nAspernatur illum asperiores sed.\nEa error quam culpa distinctio corporis sed quo a.", "a" },
                    { new Guid("924cc7ef-791b-4abe-8665-c914c6de51ba"), new Guid("9b79c8b2-45c1-498e-802c-45730ed91181"), new DateTime(2023, 2, 14, 16, 30, 15, 52, DateTimeKind.Local).AddTicks(4387), "Voluptate labore unde sint.\nAccusantium rerum quia.\nQuia excepturi aliquam distinctio deserunt qui optio.\nUllam officia adipisci.\nId voluptas eum tempore beatae sed sapiente itaque sit asperiores.\nEt adipisci sed expedita nulla facere quis officiis voluptatem.", "et" },
                    { new Guid("9aa6e95e-bc99-4ffb-bc78-62e6feab399b"), new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"), new DateTime(2023, 2, 10, 17, 24, 1, 994, DateTimeKind.Local).AddTicks(9568), "temporibus", "a" },
                    { new Guid("a29535b5-405e-4d16-b70f-89a270c242c0"), new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"), new DateTime(2023, 2, 12, 12, 35, 31, 164, DateTimeKind.Local).AddTicks(9131), "Voluptates doloremque ipsa ut.", "quia" },
                    { new Guid("a596c921-9a75-4bee-8d07-8fc558411501"), new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"), new DateTime(2023, 5, 10, 13, 16, 47, 993, DateTimeKind.Local).AddTicks(5560), "Eum veritatis at molestias ducimus doloremque sed rerum aspernatur amet. Sint nihil eum placeat aut. Hic voluptatibus sit qui quis consequatur ut. Illum nobis modi culpa unde fugit sed eaque consectetur adipisci. Dolorum quam vel modi autem.", "facere" },
                    { new Guid("b6b45b44-7102-4414-ac51-cc502adeb873"), new Guid("9fa263eb-e0ca-4646-aef8-74f9f5fdb9c4"), new DateTime(2022, 6, 2, 22, 4, 7, 186, DateTimeKind.Local).AddTicks(2565), "ad", "iure" },
                    { new Guid("ca01b1cf-a0dc-4611-b6bc-77c51afbb255"), new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"), new DateTime(2022, 8, 19, 18, 7, 47, 467, DateTimeKind.Local).AddTicks(142), "modi", "commodi" },
                    { new Guid("ca52595c-706d-4596-816a-e3c5e6d21543"), new Guid("9fa263eb-e0ca-4646-aef8-74f9f5fdb9c4"), new DateTime(2023, 4, 19, 1, 7, 11, 949, DateTimeKind.Local).AddTicks(6356), "Qui quasi nostrum optio sequi dolorum quam dolorem occaecati illum.", "adipisci" },
                    { new Guid("cd368a36-f4da-4b1b-9ce7-2fc2ace6dcc0"), new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"), new DateTime(2022, 9, 30, 14, 10, 45, 600, DateTimeKind.Local).AddTicks(5619), "Minima quo dicta cumque qui.\nSunt similique amet voluptates eos voluptatum adipisci.", "voluptates" },
                    { new Guid("d0ef0f9c-bedf-422f-867e-e412fadb26ea"), new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"), new DateTime(2022, 8, 22, 20, 21, 51, 870, DateTimeKind.Local).AddTicks(6167), "consequatur", "eos" },
                    { new Guid("df7fb061-24db-474f-9748-6eda40e83412"), new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"), new DateTime(2022, 12, 14, 17, 30, 42, 945, DateTimeKind.Local).AddTicks(8647), "et", "exercitationem" }
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Replies",
                columns: new[] { "ID", "ReplyCommentId", "ReplyPostDate", "ReplyText" },
                values: new object[,]
                {
                    { new Guid("01090724-404f-463a-a156-bdafce2d4f8e"), new Guid("924cc7ef-791b-4abe-8665-c914c6de51ba"), new DateTime(2022, 9, 15, 5, 39, 2, 587, DateTimeKind.Local).AddTicks(7418), "tenetur" },
                    { new Guid("0bb39075-d196-4df8-8010-a6ca8526a580"), new Guid("cd368a36-f4da-4b1b-9ce7-2fc2ace6dcc0"), new DateTime(2022, 12, 12, 20, 17, 38, 254, DateTimeKind.Local).AddTicks(4485), "Dignissimos dolores aliquam." },
                    { new Guid("221dae9d-05b2-4b0f-91a4-a6c40d6617e7"), new Guid("48c954de-ae23-4759-98fb-0c124bfadc87"), new DateTime(2022, 12, 7, 4, 14, 43, 315, DateTimeKind.Local).AddTicks(7374), "Omnis cupiditate eos sed omnis modi odio et.\nPossimus facilis fugiat dignissimos ea ad nesciunt quia veniam aut.\nUllam temporibus dolorem quam consequatur quasi doloribus.\nExplicabo doloribus ut iste esse.\nAsperiores vel consequuntur fugiat adipisci minima voluptatem libero est eius." },
                    { new Guid("4181608b-d6ee-47cd-81c6-bed5f419e0d8"), new Guid("4c4e7eef-ea3e-41ac-bf5a-255a89d7a632"), new DateTime(2022, 11, 3, 8, 12, 52, 931, DateTimeKind.Local).AddTicks(7116), "Vero deleniti qui ea quis fugit dolorem et unde qui." },
                    { new Guid("45f4a3d9-11f6-4b65-9559-934da54f8a34"), new Guid("ca01b1cf-a0dc-4611-b6bc-77c51afbb255"), new DateTime(2022, 12, 22, 10, 37, 56, 88, DateTimeKind.Local).AddTicks(1771), "autem" },
                    { new Guid("55a36926-529a-421b-b768-3d4aca2d0787"), new Guid("6e9318f8-1fe8-45ab-b519-ccbb23c73818"), new DateTime(2022, 9, 18, 18, 12, 41, 931, DateTimeKind.Local).AddTicks(4174), "Sint hic aut. Temporibus ratione sunt expedita tempore praesentium. Sit culpa numquam. Enim et fuga. Praesentium rerum amet quas eveniet doloribus optio odit. Enim dolorem libero voluptas quidem." },
                    { new Guid("58a425ce-4809-426e-9cab-11e47d3e26df"), new Guid("ca52595c-706d-4596-816a-e3c5e6d21543"), new DateTime(2023, 2, 9, 4, 49, 1, 575, DateTimeKind.Local).AddTicks(9074), "Necessitatibus explicabo ut iusto iste ea. Rerum tempora corrupti rerum tempora voluptas aut. Et sint et est. Numquam dolor qui debitis quae. Qui dignissimos ipsam necessitatibus neque. Maxime praesentium nostrum sint corporis repudiandae cumque commodi totam." },
                    { new Guid("5ae55e5b-bdb2-4a60-98cb-74a59146a407"), new Guid("1323d20a-3bfe-4088-9296-2a20e8028bbc"), new DateTime(2022, 7, 11, 18, 17, 52, 375, DateTimeKind.Local).AddTicks(2549), "Explicabo ea consequuntur. Ex deserunt molestiae suscipit quisquam occaecati. Fugiat iusto sunt maiores. Cumque est cumque minima culpa debitis nobis a id porro. Sequi consequatur explicabo sequi perferendis qui vel. Vel aut officiis vel sed." },
                    { new Guid("617e6071-6ea1-4461-941d-0670ae4e584c"), new Guid("6c927d62-9b0b-4e94-b0ea-ea2f6f2178c8"), new DateTime(2022, 10, 30, 13, 41, 49, 89, DateTimeKind.Local).AddTicks(6560), "Maxime vero vero cupiditate libero adipisci laudantium occaecati.\nDolorum incidunt est delectus aut.\nConsectetur modi aut ea dicta quo cupiditate molestiae delectus magni.\nInventore voluptate aperiam doloremque dolorum voluptatem quia sint sed hic.\nUt distinctio totam ipsam quasi." },
                    { new Guid("758ffdff-077a-4778-8227-9c4bff8f4f6c"), new Guid("5610e6ef-282c-4be1-828c-57b0b5202d33"), new DateTime(2023, 4, 17, 5, 10, 21, 45, DateTimeKind.Local).AddTicks(6001), "Eveniet rerum ut odit esse et eius id placeat.\nTempore quas necessitatibus doloremque.\nAsperiores nostrum esse debitis veniam quis sapiente facere.\nRerum deleniti culpa temporibus modi facere sed corporis ullam.\nEa tenetur corrupti.\nAb eaque et quia voluptatem et aliquid." },
                    { new Guid("7bd20b07-a4d4-425f-b613-c897fdefcfd9"), new Guid("df7fb061-24db-474f-9748-6eda40e83412"), new DateTime(2023, 4, 14, 15, 24, 20, 647, DateTimeKind.Local).AddTicks(4621), "Et non et ut ut. Sint iure dolorum in molestiae nihil odio quo nemo. Beatae vel fugiat qui voluptatum fuga. Rerum rerum consequatur. Officia praesentium ut architecto amet explicabo quis." },
                    { new Guid("7d8c89f8-fb1b-426a-ac1f-365e32bb2fdc"), new Guid("18611973-ae6e-43e8-bf4d-4a094c88f1ba"), new DateTime(2023, 2, 21, 6, 3, 50, 468, DateTimeKind.Local).AddTicks(7157), "Aut deserunt numquam." },
                    { new Guid("90dc8deb-0c0e-4ffa-a847-fe024ee2e900"), new Guid("589cbd4c-ce46-4139-bd08-72bdb764de9c"), new DateTime(2023, 5, 11, 17, 36, 7, 533, DateTimeKind.Local).AddTicks(6456), "Quod voluptate eius nesciunt minima perspiciatis harum dicta facere non.\nIpsum ut doloremque ea quia natus eos.\nAsperiores blanditiis eum a." },
                    { new Guid("a699856f-f589-4e7f-aaa6-b3f819208aa9"), new Guid("18d81b75-378c-4daa-ba68-e3ce723ae502"), new DateTime(2022, 5, 28, 6, 3, 32, 592, DateTimeKind.Local).AddTicks(8629), "qui" },
                    { new Guid("a9f9a1a6-2bb2-4394-b81e-f77f80b4eb29"), new Guid("47f55c4b-65bc-43cd-a450-10202006338d"), new DateTime(2023, 5, 20, 5, 1, 58, 174, DateTimeKind.Local).AddTicks(1254), "iure" },
                    { new Guid("aab7a3e4-aea5-423c-99e6-1f09ed63d47b"), new Guid("31a55e74-e566-4302-92e4-77b34240637e"), new DateTime(2022, 9, 17, 17, 42, 7, 799, DateTimeKind.Local).AddTicks(7816), "Impedit et odit reprehenderit possimus doloremque aperiam cum. Ut assumenda tempora cumque ducimus quidem officia sed veritatis rerum. Repellendus quis quam aut sequi a enim corrupti. Et nihil ea aperiam. Quibusdam dolor officia deserunt." },
                    { new Guid("ac9e8706-5fa8-4d48-99b7-5e8e89d24bcd"), new Guid("7b632433-ca6d-421d-b3ab-e1daeb6ca005"), new DateTime(2023, 1, 28, 19, 16, 12, 424, DateTimeKind.Local).AddTicks(9950), "rerum" },
                    { new Guid("b2e51c9e-a7a6-40c0-a896-b0c6c6376f7c"), new Guid("78e5172e-edcf-4a33-a68e-3c882e3ace28"), new DateTime(2022, 10, 25, 12, 41, 17, 402, DateTimeKind.Local).AddTicks(2452), "culpa" },
                    { new Guid("b37556b1-180a-4dff-8b5e-ddd811ed425e"), new Guid("516eab17-30f1-401d-af6e-8992f666354e"), new DateTime(2022, 10, 19, 17, 6, 13, 619, DateTimeKind.Local).AddTicks(6114), "Delectus distinctio sed numquam quia et voluptatem rem.\nOmnis blanditiis excepturi atque et placeat ipsa velit et et." },
                    { new Guid("b3a150f6-4aec-4e88-8598-52665bdb6a19"), new Guid("b6b45b44-7102-4414-ac51-cc502adeb873"), new DateTime(2022, 8, 16, 20, 17, 46, 274, DateTimeKind.Local).AddTicks(8878), "Et doloremque fugiat placeat voluptatem minima minima quos sapiente nihil." },
                    { new Guid("c92fe676-2e4d-45a3-abcc-dca8c10d7624"), new Guid("47cdaa48-c1b6-46b2-a7f2-4781d581da0f"), new DateTime(2022, 10, 1, 7, 39, 24, 469, DateTimeKind.Local).AddTicks(3155), "Aut fugit cupiditate eveniet atque.\nNumquam cupiditate cum rerum illum esse." },
                    { new Guid("cd554fab-1ef0-49f0-a7ed-bfbfab27e953"), new Guid("d0ef0f9c-bedf-422f-867e-e412fadb26ea"), new DateTime(2023, 5, 22, 7, 46, 54, 5, DateTimeKind.Local).AddTicks(3227), "Voluptas quidem consequuntur dolore ut ea animi. Quia rerum quod tempora ea culpa magni quia necessitatibus a. Porro incidunt atque qui. Veniam et cumque accusantium sint qui ducimus rerum eos ipsa." },
                    { new Guid("d49646bd-9505-4b5e-a290-0419b32152ab"), new Guid("034dcfe2-f065-4e26-b0d3-8ef3dc29ba50"), new DateTime(2022, 9, 13, 6, 28, 20, 355, DateTimeKind.Local).AddTicks(3823), "sequi" },
                    { new Guid("d6cb5132-5469-499c-9059-d160aa240f3b"), new Guid("4ae7e910-ed61-4852-a80c-e7cd955c5f89"), new DateTime(2022, 10, 20, 1, 20, 46, 406, DateTimeKind.Local).AddTicks(8768), "Repellat nisi et illum beatae recusandae velit." },
                    { new Guid("d6d0f0bc-5f7f-4ed3-a49b-fba650bee247"), new Guid("a596c921-9a75-4bee-8d07-8fc558411501"), new DateTime(2022, 10, 28, 8, 21, 14, 745, DateTimeKind.Local).AddTicks(9012), "Modi et omnis est ut vel sit veniam alias.\nEa sit sunt et error sequi perspiciatis.\nLaudantium sit repellendus quidem veniam est itaque voluptatum ut excepturi." },
                    { new Guid("e8140296-28dd-44d4-b6b7-d7af1f0aa7ed"), new Guid("a29535b5-405e-4d16-b70f-89a270c242c0"), new DateTime(2022, 7, 22, 23, 46, 5, 311, DateTimeKind.Local).AddTicks(2546), "Corrupti minus et corporis fuga laudantium praesentium amet distinctio excepturi. Consequatur et architecto assumenda. Inventore vel voluptatem autem nemo repellat." },
                    { new Guid("ebdc377c-8478-4e2e-90af-3a5edbeefffe"), new Guid("81923ef3-6adb-4d51-aace-d671a0382227"), new DateTime(2023, 4, 14, 13, 50, 42, 163, DateTimeKind.Local).AddTicks(1988), "Quia ut facilis velit quis sunt dolorum non." },
                    { new Guid("ed2ae412-ba5a-4f76-9188-ef2bcac9a949"), new Guid("51165c35-e1eb-41c9-965a-045c4bf6dec3"), new DateTime(2022, 7, 3, 20, 31, 6, 793, DateTimeKind.Local).AddTicks(462), "Velit ullam commodi voluptas." },
                    { new Guid("ef58d3f3-df44-477c-b19b-a5736650985a"), new Guid("8c12089f-173f-4012-993b-1088798c4990"), new DateTime(2022, 12, 14, 3, 31, 1, 283, DateTimeKind.Local).AddTicks(2685), "Consequatur quisquam facere id reiciendis explicabo nesciunt iure. Architecto quo qui in. Vero quasi ut expedita odio eos recusandae sit nihil. Optio qui qui. Soluta dolor debitis reiciendis aut iure ut sint. Quia rerum minus temporibus." },
                    { new Guid("f75a9e8d-f9ca-48dc-8554-22a5a10db64c"), new Guid("9aa6e95e-bc99-4ffb-bc78-62e6feab399b"), new DateTime(2023, 5, 3, 4, 48, 51, 952, DateTimeKind.Local).AddTicks(6472), "Eligendi enim aut dolor sed quidem ipsa facilis." }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Feedbacks_CommentFeedbackId",
                schema: "Comments",
                table: "Comments",
                column: "CommentFeedbackId",
                principalSchema: "Comments",
                principalTable: "Feedbacks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Comments_ReplyCommentId",
                schema: "Comments",
                table: "Replies",
                column: "ReplyCommentId",
                principalSchema: "Comments",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Feedbacks_CommentFeedbackId",
                schema: "Comments",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Comments_ReplyCommentId",
                schema: "Comments",
                table: "Replies");

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("01090724-404f-463a-a156-bdafce2d4f8e"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("0bb39075-d196-4df8-8010-a6ca8526a580"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("221dae9d-05b2-4b0f-91a4-a6c40d6617e7"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("4181608b-d6ee-47cd-81c6-bed5f419e0d8"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("45f4a3d9-11f6-4b65-9559-934da54f8a34"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("55a36926-529a-421b-b768-3d4aca2d0787"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("58a425ce-4809-426e-9cab-11e47d3e26df"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("5ae55e5b-bdb2-4a60-98cb-74a59146a407"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("617e6071-6ea1-4461-941d-0670ae4e584c"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("758ffdff-077a-4778-8227-9c4bff8f4f6c"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("7bd20b07-a4d4-425f-b613-c897fdefcfd9"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("7d8c89f8-fb1b-426a-ac1f-365e32bb2fdc"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("90dc8deb-0c0e-4ffa-a847-fe024ee2e900"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("a699856f-f589-4e7f-aaa6-b3f819208aa9"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("a9f9a1a6-2bb2-4394-b81e-f77f80b4eb29"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("aab7a3e4-aea5-423c-99e6-1f09ed63d47b"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("ac9e8706-5fa8-4d48-99b7-5e8e89d24bcd"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("b2e51c9e-a7a6-40c0-a896-b0c6c6376f7c"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("b37556b1-180a-4dff-8b5e-ddd811ed425e"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("b3a150f6-4aec-4e88-8598-52665bdb6a19"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("c92fe676-2e4d-45a3-abcc-dca8c10d7624"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("cd554fab-1ef0-49f0-a7ed-bfbfab27e953"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("d49646bd-9505-4b5e-a290-0419b32152ab"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("d6cb5132-5469-499c-9059-d160aa240f3b"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("d6d0f0bc-5f7f-4ed3-a49b-fba650bee247"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("e8140296-28dd-44d4-b6b7-d7af1f0aa7ed"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("ebdc377c-8478-4e2e-90af-3a5edbeefffe"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("ed2ae412-ba5a-4f76-9188-ef2bcac9a949"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("ef58d3f3-df44-477c-b19b-a5736650985a"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Replies",
                keyColumn: "ID",
                keyValue: new Guid("f75a9e8d-f9ca-48dc-8554-22a5a10db64c"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("034dcfe2-f065-4e26-b0d3-8ef3dc29ba50"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("1323d20a-3bfe-4088-9296-2a20e8028bbc"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("18611973-ae6e-43e8-bf4d-4a094c88f1ba"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("18d81b75-378c-4daa-ba68-e3ce723ae502"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("31a55e74-e566-4302-92e4-77b34240637e"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("47cdaa48-c1b6-46b2-a7f2-4781d581da0f"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("47f55c4b-65bc-43cd-a450-10202006338d"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("48c954de-ae23-4759-98fb-0c124bfadc87"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("4ae7e910-ed61-4852-a80c-e7cd955c5f89"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("4c4e7eef-ea3e-41ac-bf5a-255a89d7a632"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("51165c35-e1eb-41c9-965a-045c4bf6dec3"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("516eab17-30f1-401d-af6e-8992f666354e"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("5610e6ef-282c-4be1-828c-57b0b5202d33"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("589cbd4c-ce46-4139-bd08-72bdb764de9c"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("6c927d62-9b0b-4e94-b0ea-ea2f6f2178c8"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("6e9318f8-1fe8-45ab-b519-ccbb23c73818"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("78e5172e-edcf-4a33-a68e-3c882e3ace28"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("7b632433-ca6d-421d-b3ab-e1daeb6ca005"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("81923ef3-6adb-4d51-aace-d671a0382227"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("8c12089f-173f-4012-993b-1088798c4990"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("924cc7ef-791b-4abe-8665-c914c6de51ba"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("9aa6e95e-bc99-4ffb-bc78-62e6feab399b"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("a29535b5-405e-4d16-b70f-89a270c242c0"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("a596c921-9a75-4bee-8d07-8fc558411501"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("b6b45b44-7102-4414-ac51-cc502adeb873"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ca01b1cf-a0dc-4611-b6bc-77c51afbb255"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ca52595c-706d-4596-816a-e3c5e6d21543"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("cd368a36-f4da-4b1b-9ce7-2fc2ace6dcc0"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("d0ef0f9c-bedf-422f-867e-e412fadb26ea"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("df7fb061-24db-474f-9748-6eda40e83412"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Feedbacks",
                keyColumn: "ID",
                keyValue: new Guid("150f1b18-1fe9-4f5e-b48b-bf7d02305cfb"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Feedbacks",
                keyColumn: "ID",
                keyValue: new Guid("9b79c8b2-45c1-498e-802c-45730ed91181"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Feedbacks",
                keyColumn: "ID",
                keyValue: new Guid("9fa263eb-e0ca-4646-aef8-74f9f5fdb9c4"));

            migrationBuilder.DeleteData(
                schema: "Comments",
                table: "Feedbacks",
                keyColumn: "ID",
                keyValue: new Guid("e1d62422-5618-492e-bb0e-d1193f020ea2"));

            migrationBuilder.RenameColumn(
                name: "ReplyText",
                schema: "Comments",
                table: "Replies",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "ReplyPostDate",
                schema: "Comments",
                table: "Replies",
                newName: "PostDate");

            migrationBuilder.RenameColumn(
                name: "ReplyCommentId",
                schema: "Comments",
                table: "Replies",
                newName: "CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_ReplyCommentId",
                schema: "Comments",
                table: "Replies",
                newName: "IX_Replies_CommentId");

            migrationBuilder.RenameColumn(
                name: "CommentTheme",
                schema: "Comments",
                table: "Comments",
                newName: "Theme");

            migrationBuilder.RenameColumn(
                name: "CommentText",
                schema: "Comments",
                table: "Comments",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "CommentPostDate",
                schema: "Comments",
                table: "Comments",
                newName: "PostDate");

            migrationBuilder.RenameColumn(
                name: "CommentFeedbackId",
                schema: "Comments",
                table: "Comments",
                newName: "FeedbackId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CommentFeedbackId",
                schema: "Comments",
                table: "Comments",
                newName: "IX_Comments_FeedbackId");

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Feedbacks",
                columns: new[] { "ID", "FeedbackTheme" },
                values: new object[,]
                {
                    { new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), "Issue" },
                    { new Guid("ba864a71-55a7-4ea8-868a-4a000b0422da"), "Suggestion" },
                    { new Guid("d0f1c668-d17d-43f6-b06f-57b4462939c7"), "Comment" },
                    { new Guid("d7725adf-ba7d-4d7a-9ff6-9ae41c7e4d76"), "LoveIt" }
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Comments",
                columns: new[] { "ID", "FeedbackId", "PostDate", "Text", "Theme" },
                values: new object[,]
                {
                    { new Guid("15e48967-ed7b-4e5d-a321-77590de6537c"), new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), new DateTime(2022, 11, 16, 10, 28, 59, 267, DateTimeKind.Local).AddTicks(5748), "Laborum vel doloribus et nesciunt impedit iste vitae.", "fugiat" },
                    { new Guid("1bd599a3-2731-4bbe-8524-623d8fb740a0"), new Guid("d0f1c668-d17d-43f6-b06f-57b4462939c7"), new DateTime(2022, 6, 5, 17, 28, 21, 744, DateTimeKind.Local).AddTicks(4240), "Ducimus excepturi eum est repellendus ipsam voluptatem vel. Dolores incidunt eveniet. Beatae maxime dolorum fuga. Rem porro minima asperiores autem facilis dolore incidunt qui aut. Qui quos neque magni autem tenetur praesentium. Odit sed asperiores laudantium odit.", "amet" },
                    { new Guid("1ed4c36d-328b-47e9-95b8-488bcffd1e1f"), new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), new DateTime(2023, 2, 25, 18, 56, 58, 5, DateTimeKind.Local).AddTicks(9487), "Iusto esse officia nihil exercitationem quia.\nQui qui reiciendis repellat est et.\nNam vel harum qui possimus et.\nFuga soluta nisi rem laborum cupiditate hic placeat.\nQui et voluptate ratione quo maiores pariatur.\nSequi esse accusamus est est.", "vel" },
                    { new Guid("213d4df5-e3f3-4218-8823-a7dc05ea61a8"), new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), new DateTime(2022, 6, 1, 17, 56, 7, 115, DateTimeKind.Local).AddTicks(2533), "omnis", "optio" },
                    { new Guid("2bd17bf5-d102-4d60-99da-c0978a2b53ba"), new Guid("d0f1c668-d17d-43f6-b06f-57b4462939c7"), new DateTime(2023, 4, 12, 5, 35, 18, 145, DateTimeKind.Local).AddTicks(5296), "Officia error eum et dolores aut aut laudantium minima ex. Dolor et ut non fuga expedita ipsam consequatur. Quidem provident dolorem sint ab. Eaque aut magnam. Rem hic fugit labore quis aspernatur illum. Perspiciatis earum et itaque fugiat enim autem iste laudantium.", "magni" },
                    { new Guid("489638af-43cf-43c5-b460-a8ed51a99f07"), new Guid("ba864a71-55a7-4ea8-868a-4a000b0422da"), new DateTime(2022, 9, 16, 3, 38, 3, 112, DateTimeKind.Local).AddTicks(8834), "Voluptas distinctio dignissimos.", "soluta" },
                    { new Guid("4af6a591-030f-4623-88d5-8347a416485d"), new Guid("ba864a71-55a7-4ea8-868a-4a000b0422da"), new DateTime(2022, 7, 30, 21, 22, 50, 142, DateTimeKind.Local).AddTicks(7630), "Sit nesciunt dolorem ratione qui iure.\nDelectus necessitatibus eaque ad.", "aliquam" },
                    { new Guid("576b3ca9-b530-477d-a765-25d76479cb5d"), new Guid("d7725adf-ba7d-4d7a-9ff6-9ae41c7e4d76"), new DateTime(2023, 5, 4, 12, 3, 25, 925, DateTimeKind.Local).AddTicks(1955), "Est aperiam commodi sint.\nEst earum facilis a assumenda totam praesentium.\nOdio natus qui doloribus quidem nostrum ex animi reiciendis doloremque.\nEst repudiandae impedit praesentium at consectetur.\nQui voluptate magnam itaque qui ea ratione optio.\nSequi dolorem et quam mollitia iure ducimus.", "eum" },
                    { new Guid("5ba48dba-ddbe-4756-84fc-40721b90e925"), new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), new DateTime(2022, 6, 11, 20, 58, 6, 543, DateTimeKind.Local).AddTicks(28), "aliquam", "velit" },
                    { new Guid("5e3fda18-9542-4d4a-8cc4-fdad379c0311"), new Guid("d0f1c668-d17d-43f6-b06f-57b4462939c7"), new DateTime(2023, 3, 30, 9, 25, 27, 151, DateTimeKind.Local).AddTicks(9917), "nobis", "nemo" },
                    { new Guid("7b58fcff-054a-47b6-8b80-277efd517596"), new Guid("d7725adf-ba7d-4d7a-9ff6-9ae41c7e4d76"), new DateTime(2023, 2, 22, 19, 37, 29, 765, DateTimeKind.Local).AddTicks(9093), "Sed debitis est dolores nihil vero ea. Voluptatum doloremque autem. Molestias modi exercitationem saepe voluptatem ut corporis. Hic consequatur vel iste quasi officia et assumenda officiis.", "eos" },
                    { new Guid("895b8b28-17d9-4a8b-952d-b7245e004e1d"), new Guid("d0f1c668-d17d-43f6-b06f-57b4462939c7"), new DateTime(2022, 10, 21, 11, 15, 25, 887, DateTimeKind.Local).AddTicks(7006), "Maxime perspiciatis dolores.", "dolore" },
                    { new Guid("8d828728-356d-484f-9b35-bfd6c4af4e16"), new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), new DateTime(2022, 11, 14, 15, 3, 40, 918, DateTimeKind.Local).AddTicks(5193), "Ab non eos explicabo corporis ut possimus. In nemo voluptas nam ea consequuntur enim ut aspernatur. Amet dignissimos qui sunt. Cupiditate repellat eius vel ut nemo et non iusto eaque.", "aut" },
                    { new Guid("97bfdf74-5501-4ee1-9321-9888ea07a3bc"), new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), new DateTime(2022, 12, 23, 18, 39, 34, 454, DateTimeKind.Local).AddTicks(2284), "Nam quo aut est dolore. Dicta dolores perspiciatis rerum voluptatem. Id dicta voluptatibus libero aliquid molestiae. Expedita molestiae voluptatum officia neque qui ea totam. Suscipit et ut repellat est enim voluptas cum quo id.", "sint" },
                    { new Guid("a3efc9b3-5e17-47ec-8442-eaff025447d8"), new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), new DateTime(2023, 2, 26, 18, 14, 7, 637, DateTimeKind.Local).AddTicks(506), "Consequatur nihil quis consequuntur sed sed qui ipsam.", "recusandae" },
                    { new Guid("b2e61069-1a39-467e-a2eb-ebf97a653413"), new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), new DateTime(2022, 10, 16, 2, 16, 59, 934, DateTimeKind.Local).AddTicks(3216), "inventore", "sit" },
                    { new Guid("b7877d18-4103-493f-87aa-15ed6071387c"), new Guid("ba864a71-55a7-4ea8-868a-4a000b0422da"), new DateTime(2022, 8, 27, 6, 59, 54, 975, DateTimeKind.Local).AddTicks(2822), "Nesciunt in pariatur beatae nostrum quisquam ratione.\nQui aut sequi ipsa esse eaque quas enim exercitationem vitae.\nQuae voluptatum enim minus et odit culpa et vitae iure.\nMaiores perspiciatis dolores earum soluta sit esse aliquid unde illum.\nConsequatur modi qui amet rerum aut est qui.", "et" },
                    { new Guid("b9a373bb-ef54-4784-9643-522deaf0c0ae"), new Guid("d7725adf-ba7d-4d7a-9ff6-9ae41c7e4d76"), new DateTime(2022, 12, 17, 2, 47, 40, 207, DateTimeKind.Local).AddTicks(1338), "facere", "sit" },
                    { new Guid("bbeaa05b-ef78-413e-9ea7-95cf760bbb6c"), new Guid("d7725adf-ba7d-4d7a-9ff6-9ae41c7e4d76"), new DateTime(2022, 6, 5, 19, 31, 46, 773, DateTimeKind.Local).AddTicks(2763), "Ut quo dolorem voluptates labore aut tempore.\nAssumenda sed labore ut quod eius aut assumenda corporis quisquam.\nMagnam repudiandae sapiente eum nostrum maiores explicabo beatae molestias.\nLaboriosam saepe voluptates inventore omnis delectus ut quia numquam qui.\nVoluptate temporibus temporibus.\nRepellendus labore dolorem facilis quo fugiat animi.", "nobis" },
                    { new Guid("bbeb8304-87e9-496e-9c45-986b04711b20"), new Guid("d0f1c668-d17d-43f6-b06f-57b4462939c7"), new DateTime(2023, 2, 27, 4, 57, 18, 590, DateTimeKind.Local).AddTicks(6335), "ab", "et" },
                    { new Guid("bf172b85-cbea-498e-a0ba-7c35d6efeeb5"), new Guid("ba864a71-55a7-4ea8-868a-4a000b0422da"), new DateTime(2022, 8, 16, 21, 37, 31, 578, DateTimeKind.Local).AddTicks(63), "et", "perferendis" },
                    { new Guid("bf2eeaa4-2fdc-49eb-aa14-8ccf4a10dcc9"), new Guid("d7725adf-ba7d-4d7a-9ff6-9ae41c7e4d76"), new DateTime(2022, 6, 5, 20, 55, 10, 99, DateTimeKind.Local).AddTicks(2415), "officiis", "eum" },
                    { new Guid("c1b8d33f-4517-4be9-aec3-9e0818070cd5"), new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), new DateTime(2022, 10, 29, 8, 55, 57, 670, DateTimeKind.Local).AddTicks(3593), "Minus vel suscipit quo laboriosam.", "molestiae" },
                    { new Guid("c61e53c9-0f4a-4c03-bce1-b422c40f0ca8"), new Guid("d0f1c668-d17d-43f6-b06f-57b4462939c7"), new DateTime(2022, 10, 28, 2, 43, 38, 362, DateTimeKind.Local).AddTicks(2137), "Velit vel non consectetur aut sit excepturi. Quia excepturi odit distinctio aut est maxime. Ipsam nam quibusdam voluptatem voluptatem error. Officia dicta qui qui occaecati. Perferendis et rerum rerum laboriosam.", "deleniti" },
                    { new Guid("d0fe831a-2ac0-4964-b99f-618e448758a8"), new Guid("ba864a71-55a7-4ea8-868a-4a000b0422da"), new DateTime(2022, 7, 18, 13, 56, 54, 907, DateTimeKind.Local).AddTicks(4348), "Sunt nisi neque repellat et velit dolore ducimus.\nAut tempore maiores ut distinctio sit fugit.\nCulpa at magnam consectetur placeat blanditiis.\nOfficiis et aut laboriosam.\nExcepturi ea veritatis error ab numquam.", "blanditiis" },
                    { new Guid("d1bb8ef9-aab4-43ab-a89f-171d9fc3e5e3"), new Guid("d7725adf-ba7d-4d7a-9ff6-9ae41c7e4d76"), new DateTime(2022, 12, 24, 12, 51, 29, 740, DateTimeKind.Local).AddTicks(1719), "qui", "nulla" },
                    { new Guid("dc089c97-35a4-4ddc-aaac-68f57d4859d0"), new Guid("ba864a71-55a7-4ea8-868a-4a000b0422da"), new DateTime(2022, 11, 23, 10, 58, 50, 952, DateTimeKind.Local).AddTicks(7885), "Nesciunt necessitatibus fuga accusantium et.", "aut" },
                    { new Guid("e70060dc-d57b-4eb9-82c9-83aced0e28d9"), new Guid("d7725adf-ba7d-4d7a-9ff6-9ae41c7e4d76"), new DateTime(2023, 5, 9, 0, 29, 22, 546, DateTimeKind.Local).AddTicks(117), "Temporibus nihil ipsum corrupti voluptatem omnis officiis et velit. Nulla facilis aperiam inventore nihil sequi repellat debitis dolor nobis. Qui ullam placeat dolorem esse sit mollitia alias sunt voluptatibus. Adipisci molestiae vel rerum maiores. Vel facilis et officia saepe doloremque ipsa.", "consequatur" },
                    { new Guid("ea18d609-8114-44f5-aa94-41f6d6e47f6f"), new Guid("4669df4c-b2b0-4702-bc02-50e6f9ab9de6"), new DateTime(2022, 8, 17, 14, 24, 34, 0, DateTimeKind.Local).AddTicks(8928), "Et eaque explicabo ut nisi natus sapiente.\nEnim recusandae ut minima facere explicabo voluptatem.\nNumquam voluptatem quidem adipisci vero.\nAsperiores omnis voluptatem corporis ducimus eos sit sit fugit.\nEnim voluptates provident est error dolor repellat quia aliquam impedit.\nPerferendis perspiciatis eum consequuntur facilis et.", "fuga" },
                    { new Guid("f9047885-c25a-475d-b1e2-7899c22c5c6a"), new Guid("d7725adf-ba7d-4d7a-9ff6-9ae41c7e4d76"), new DateTime(2023, 4, 11, 23, 47, 2, 183, DateTimeKind.Local).AddTicks(7036), "Ut perspiciatis in quia iure.", "reprehenderit" }
                });

            migrationBuilder.InsertData(
                schema: "Comments",
                table: "Replies",
                columns: new[] { "ID", "CommentId", "PostDate", "Text" },
                values: new object[,]
                {
                    { new Guid("03d3cfe0-b42e-4033-9ca0-0f1e2cb18a65"), new Guid("1bd599a3-2731-4bbe-8524-623d8fb740a0"), new DateTime(2023, 3, 15, 20, 25, 0, 2, DateTimeKind.Local).AddTicks(1192), "Alias molestiae reprehenderit aspernatur.\nVelit est dolore doloribus aut iure molestias aut eum sint.\nOfficiis eius explicabo nesciunt quod esse quia architecto molestiae eveniet.\nDolor qui rerum recusandae fugit enim corrupti harum assumenda.\nEt et ut voluptatem aut ut totam sed.\nIpsam doloremque delectus sit ut et." },
                    { new Guid("142a4c7b-dafc-4cd0-9de7-79f4176cc8a3"), new Guid("576b3ca9-b530-477d-a765-25d76479cb5d"), new DateTime(2023, 3, 13, 22, 0, 46, 610, DateTimeKind.Local).AddTicks(8715), "omnis" },
                    { new Guid("1f1c34c4-331b-478c-b3b5-cd5c486faf27"), new Guid("4af6a591-030f-4623-88d5-8347a416485d"), new DateTime(2022, 12, 1, 16, 44, 8, 26, DateTimeKind.Local).AddTicks(4060), "Adipisci ipsam nihil magnam. Laudantium dolore eos iusto autem deserunt eius ad explicabo est. Enim officiis pariatur est voluptatem. Est asperiores recusandae ipsum. Inventore molestias aut dicta illo possimus eos." },
                    { new Guid("2736375f-2d15-4abf-89d6-bbaeb7575b94"), new Guid("2bd17bf5-d102-4d60-99da-c0978a2b53ba"), new DateTime(2022, 10, 9, 0, 36, 5, 876, DateTimeKind.Local).AddTicks(4712), "Debitis non omnis ea doloribus." },
                    { new Guid("346421bc-ca35-4abe-bee1-6b74f58be2a8"), new Guid("b7877d18-4103-493f-87aa-15ed6071387c"), new DateTime(2022, 7, 8, 10, 45, 18, 331, DateTimeKind.Local).AddTicks(7737), "Voluptatum autem dolor sit molestiae sapiente dolores omnis ut.\nLaborum ut distinctio accusamus ipsum pariatur mollitia modi corporis.\nSimilique neque quos repudiandae.\nUt omnis quia deleniti culpa ut.\nSoluta veritatis magnam.\nOdio et neque vero repellat quibusdam ex quis ut." },
                    { new Guid("3eb6b5e2-f602-4d49-a97b-35d931987e82"), new Guid("bf2eeaa4-2fdc-49eb-aa14-8ccf4a10dcc9"), new DateTime(2023, 5, 9, 10, 8, 44, 388, DateTimeKind.Local).AddTicks(5568), "Dolor exercitationem aspernatur quo repellat quia facere aut omnis. In consequatur voluptatum. Dolorem ut itaque id dicta ipsa. Quod a cupiditate ut earum temporibus magnam. Accusantium sit amet. Esse in dolore." },
                    { new Guid("40644db0-f8d4-4e87-943e-eed33256c825"), new Guid("bbeb8304-87e9-496e-9c45-986b04711b20"), new DateTime(2023, 3, 8, 5, 48, 34, 262, DateTimeKind.Local).AddTicks(6032), "Sit quibusdam architecto.\nReiciendis vel hic veniam ut corporis unde voluptatum.\nDignissimos autem id sed distinctio." },
                    { new Guid("4820206e-1cbf-4098-9b60-56cc99a8b753"), new Guid("f9047885-c25a-475d-b1e2-7899c22c5c6a"), new DateTime(2022, 10, 19, 0, 26, 28, 243, DateTimeKind.Local).AddTicks(5455), "nobis" },
                    { new Guid("4e5e765d-05b7-450d-9c78-0d5bd48776a4"), new Guid("a3efc9b3-5e17-47ec-8442-eaff025447d8"), new DateTime(2023, 2, 11, 23, 50, 58, 895, DateTimeKind.Local).AddTicks(4303), "voluptatum" },
                    { new Guid("4eab761b-860b-407d-a56e-6b66f1c57f5b"), new Guid("97bfdf74-5501-4ee1-9321-9888ea07a3bc"), new DateTime(2023, 3, 13, 3, 30, 5, 347, DateTimeKind.Local).AddTicks(7697), "qui" },
                    { new Guid("6e019b9b-683e-46ec-9951-32e648e5a090"), new Guid("489638af-43cf-43c5-b460-a8ed51a99f07"), new DateTime(2022, 10, 1, 17, 44, 21, 393, DateTimeKind.Local).AddTicks(8811), "Commodi eius a et quibusdam itaque ea quo possimus.\nDolorum rerum dolor quos.\nAut iusto est tenetur molestiae aut excepturi qui iure." },
                    { new Guid("74c64464-3eb3-4d85-b98a-bdfc24fb4437"), new Guid("d0fe831a-2ac0-4964-b99f-618e448758a8"), new DateTime(2022, 6, 22, 2, 55, 13, 360, DateTimeKind.Local).AddTicks(64), "Similique mollitia ut corporis est et aut. Deserunt rerum nobis nobis sed voluptatibus est officiis. Vel quae dolores. Nostrum incidunt possimus et et." },
                    { new Guid("80ca66a7-4a43-4dc5-b2e9-9d83aeac89e0"), new Guid("b2e61069-1a39-467e-a2eb-ebf97a653413"), new DateTime(2022, 5, 29, 12, 24, 36, 322, DateTimeKind.Local).AddTicks(7569), "est" },
                    { new Guid("923e9cc6-d68c-4244-880e-9a81326b4570"), new Guid("8d828728-356d-484f-9b35-bfd6c4af4e16"), new DateTime(2023, 5, 7, 10, 23, 9, 895, DateTimeKind.Local).AddTicks(5016), "Et illo quam perferendis enim quia voluptatem corporis nulla." },
                    { new Guid("98ccffb3-3bf9-4890-8e71-afa37badcfe7"), new Guid("1ed4c36d-328b-47e9-95b8-488bcffd1e1f"), new DateTime(2022, 11, 18, 20, 11, 19, 30, DateTimeKind.Local).AddTicks(5238), "voluptatibus" },
                    { new Guid("9e9160c0-ac53-4766-af24-4057be9be7e3"), new Guid("dc089c97-35a4-4ddc-aaac-68f57d4859d0"), new DateTime(2022, 11, 20, 0, 38, 49, 950, DateTimeKind.Local).AddTicks(4330), "doloremque" },
                    { new Guid("a091e439-1f3e-475f-8f88-ba61cf56cf65"), new Guid("c61e53c9-0f4a-4c03-bce1-b422c40f0ca8"), new DateTime(2023, 3, 10, 10, 8, 24, 904, DateTimeKind.Local).AddTicks(8436), "consequuntur" },
                    { new Guid("afa6f096-db70-436a-84f5-3da975786510"), new Guid("895b8b28-17d9-4a8b-952d-b7245e004e1d"), new DateTime(2022, 12, 25, 0, 25, 27, 103, DateTimeKind.Local).AddTicks(644), "Expedita quis qui alias impedit unde commodi totam." },
                    { new Guid("b52a4e60-d80d-497c-813a-fed1df055d91"), new Guid("b9a373bb-ef54-4784-9643-522deaf0c0ae"), new DateTime(2023, 4, 21, 20, 40, 10, 88, DateTimeKind.Local).AddTicks(2562), "Sapiente voluptate esse est ducimus velit dolor." },
                    { new Guid("b538f6b9-b19b-4053-b499-da794a88fdb1"), new Guid("bf172b85-cbea-498e-a0ba-7c35d6efeeb5"), new DateTime(2023, 4, 18, 23, 42, 4, 986, DateTimeKind.Local).AddTicks(8328), "odit" },
                    { new Guid("c240b9a1-8271-47b3-a581-9a0312ba70c2"), new Guid("d1bb8ef9-aab4-43ab-a89f-171d9fc3e5e3"), new DateTime(2022, 8, 26, 18, 5, 33, 54, DateTimeKind.Local).AddTicks(8193), "Quia et quia et quasi ad libero distinctio sint." },
                    { new Guid("c64f7c35-c404-4ac7-9f95-468f535bb74f"), new Guid("bbeaa05b-ef78-413e-9ea7-95cf760bbb6c"), new DateTime(2022, 8, 6, 19, 40, 18, 554, DateTimeKind.Local).AddTicks(3180), "commodi" },
                    { new Guid("d41c3c73-4920-448c-9707-82c3a5e3926b"), new Guid("15e48967-ed7b-4e5d-a321-77590de6537c"), new DateTime(2022, 11, 30, 8, 33, 16, 882, DateTimeKind.Local).AddTicks(5928), "Fugiat laborum consequuntur assumenda dolores harum necessitatibus non libero.\nExcepturi reprehenderit eum distinctio dolorem magnam dolorem tempora facere atque.\nFacere ipsam exercitationem tempora sunt sunt quae.\nMagnam maiores autem esse nesciunt dignissimos.\nOccaecati voluptatem et aspernatur ad reprehenderit consequatur eum dolores." },
                    { new Guid("d5daa88f-065d-459e-8d63-6d6ce71e1414"), new Guid("5e3fda18-9542-4d4a-8cc4-fdad379c0311"), new DateTime(2022, 7, 29, 18, 33, 53, 774, DateTimeKind.Local).AddTicks(9557), "accusantium" },
                    { new Guid("d728d6b1-89d3-4283-86a8-8eb617968a9b"), new Guid("5ba48dba-ddbe-4756-84fc-40721b90e925"), new DateTime(2023, 2, 11, 22, 49, 12, 67, DateTimeKind.Local).AddTicks(9434), "Odio voluptatem quibusdam.\nQuis et velit earum sint aperiam.\nAtque deserunt totam.\nConsequatur nesciunt incidunt aliquid voluptatem saepe ut quia aliquam.\nDoloribus qui dolor." },
                    { new Guid("e69c31bd-f613-4db0-ba82-914300bc36c5"), new Guid("ea18d609-8114-44f5-aa94-41f6d6e47f6f"), new DateTime(2023, 4, 8, 22, 11, 11, 841, DateTimeKind.Local).AddTicks(9365), "Incidunt veniam et sunt. Nemo error assumenda et et. Quas vel quasi rem est nesciunt quasi. Omnis repudiandae vel facilis debitis nam voluptate. Sit deserunt maxime qui dicta." },
                    { new Guid("eb2562d5-336d-4e24-bdf7-5360085bdf42"), new Guid("c1b8d33f-4517-4be9-aec3-9e0818070cd5"), new DateTime(2022, 11, 3, 19, 46, 2, 753, DateTimeKind.Local).AddTicks(5368), "Maiores ratione voluptas dicta similique sint vero." },
                    { new Guid("f04793d6-2899-4790-a0fa-84a9dabd6af3"), new Guid("e70060dc-d57b-4eb9-82c9-83aced0e28d9"), new DateTime(2023, 4, 3, 13, 29, 42, 140, DateTimeKind.Local).AddTicks(2830), "accusamus" },
                    { new Guid("f6102b09-1e2f-4306-bf16-ff0fa400146d"), new Guid("213d4df5-e3f3-4218-8823-a7dc05ea61a8"), new DateTime(2023, 4, 6, 21, 57, 14, 836, DateTimeKind.Local).AddTicks(7958), "Non qui unde officia voluptas maiores eos." },
                    { new Guid("f92ddac9-7efb-4ab0-ad44-aef3ef86c4c1"), new Guid("7b58fcff-054a-47b6-8b80-277efd517596"), new DateTime(2023, 3, 9, 14, 40, 15, 461, DateTimeKind.Local).AddTicks(6128), "Et dolorem consequatur commodi velit eaque voluptatem sit ea.\nBlanditiis magni excepturi in.\nQuia explicabo explicabo similique recusandae.\nDignissimos nihil laboriosam sed nihil consequuntur officia optio amet." }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Feedbacks_FeedbackId",
                schema: "Comments",
                table: "Comments",
                column: "FeedbackId",
                principalSchema: "Comments",
                principalTable: "Feedbacks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Comments_CommentId",
                schema: "Comments",
                table: "Replies",
                column: "CommentId",
                principalSchema: "Comments",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
