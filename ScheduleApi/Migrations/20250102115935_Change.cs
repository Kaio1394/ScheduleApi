using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScheduleApi.Migrations
{
    /// <inheritdoc />
    public partial class Change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "USER_JOB_CREATOR-f153e55c-2405-40d7-94b0-82cebebe96e4",
                column: "Name",
                value: "UserJobCreator");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "043a5e86-e917-4d1c-b4d5-6b40973363a2", "AQAAAAIAAYagAAAAEPWJGh1e07Ayrk+81zKE3UjiqS0Bm8VZysqQIES2Mz1l4BGqUto8ePIspM+7JNCBMA==", "595d9518-2e9e-4731-a3f9-ec0409141f03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "631ac7af-a965-4c1f-9b05-f40d426c8ad4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "892d2982-5bb3-4473-8609-96ef1d3e5180", "AQAAAAIAAYagAAAAEBGVUTwrbhO4SVkgCwHMS1gHFc2zKRkPhI7DZyQ4bS7Nbve6Eu2wXCb1COEerLb4FQ==", "a3aa3123-801b-4428-8f0e-e54c625bfb31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5755e31-8f9a-409e-9cd5-6e04a625c6b4", "AQAAAAIAAYagAAAAEAZO0ghD/bceAZBaqvljbR+Hm6Apea9go6F6ogLTRlDCMoRjbkXjT64k8KJZWGpwgQ==", "ef0076e1-2ce9-4eeb-812a-97ea426bdb34" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "USER_JOB_CREATOR-f153e55c-2405-40d7-94b0-82cebebe96e4",
                column: "Name",
                value: " UserJobCreator");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39891640-dd85-46eb-a330-7feff3b9a190", "AQAAAAIAAYagAAAAEN7YtYZUyxv+ohxtwFXL0dXy5Q1v6w5/AwguRAGjaxQE6v9ALHXnheLcqLXfRx93dw==", "2e266762-f688-4472-abef-14d4d9bd47ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "631ac7af-a965-4c1f-9b05-f40d426c8ad4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "281933e1-3d2a-45c1-9a33-2cc8e2f9c480", "AQAAAAIAAYagAAAAEHjGe2k7Iezkh+lDJrd9jRPy+Oiy24HM2Xr328ChFo7NhlzQ5ZKqhtEtnla3KgrQjg==", "6f2ea3ab-d043-46b1-8aaa-dc5b6e0f80db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9af71047-b4a9-4b93-9bef-115b108dd3a6", "AQAAAAIAAYagAAAAENd9Q5TQd7mMLQHOIt6viiUvWXKbd+tiw+XbuWujwenmba03CbttO8a+FLOLKzttyA==", "84dab18f-855c-4ba1-9f61-c69972db9d91" });
        }
    }
}
