using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScheduleApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRoleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f153e55c-2405-40d7-94b0-82cebebe96e4", "51c3aa5c-cc8b-4db0-b0d4-0a8161408463" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "85cfbc9b-a2ba-4836-a384-d56f98504729", "631ac7af-a965-4c1f-9b05-f40d426c8ad4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "85fc8893-00c4-4459-a917-52fcd2370cc1", "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85cfbc9b-a2ba-4836-a384-d56f98504729");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85fc8893-00c4-4459-a917-52fcd2370cc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f153e55c-2405-40d7-94b0-82cebebe96e4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ADMIN-85cfbc9b-a2ba-4836-a384-d56f98504729", null, "Admin", "ADMIN" },
                    { "USER_EXECUTOR-85fc8893-00c4-4459-a917-52fcd2370cc1", null, "UserExecutor", "USER_EXECUTOR" },
                    { "USER_JOB_CREATOR-f153e55c-2405-40d7-94b0-82cebebe96e4", null, " UserJobCreator", "USER_JOB_CREATOR" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "USER_JOB_CREATOR-f153e55c-2405-40d7-94b0-82cebebe96e4", "51c3aa5c-cc8b-4db0-b0d4-0a8161408463" },
                    { "ADMIN-85cfbc9b-a2ba-4836-a384-d56f98504729", "631ac7af-a965-4c1f-9b05-f40d426c8ad4" },
                    { "USER_EXECUTOR-85fc8893-00c4-4459-a917-52fcd2370cc1", "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "USER_JOB_CREATOR-f153e55c-2405-40d7-94b0-82cebebe96e4", "51c3aa5c-cc8b-4db0-b0d4-0a8161408463" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ADMIN-85cfbc9b-a2ba-4836-a384-d56f98504729", "631ac7af-a965-4c1f-9b05-f40d426c8ad4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "USER_EXECUTOR-85fc8893-00c4-4459-a917-52fcd2370cc1", "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN-85cfbc9b-a2ba-4836-a384-d56f98504729");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "USER_EXECUTOR-85fc8893-00c4-4459-a917-52fcd2370cc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "USER_JOB_CREATOR-f153e55c-2405-40d7-94b0-82cebebe96e4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "85cfbc9b-a2ba-4836-a384-d56f98504729", null, "Admin", "ADMIN" },
                    { "85fc8893-00c4-4459-a917-52fcd2370cc1", null, "UserExecutor", "USER_EXECUTOR" },
                    { "f153e55c-2405-40d7-94b0-82cebebe96e4", null, " UserJobCreator", "USER_JOB_CREATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f583b67-9975-4da0-9723-5734bb558d67", "AQAAAAIAAYagAAAAEObqpymvvaPCprcazsO0k9Iw7PooxjV3wdz5Zc9k02cLaP0LmT2Fc4uzHXfCKJju+Q==", "769050bd-d28a-4e2a-8ee9-bd01e16e23c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "631ac7af-a965-4c1f-9b05-f40d426c8ad4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ed8738e-12b2-473a-853f-302cf6f9fa48", "AQAAAAIAAYagAAAAEMw+xi4RMteTqMy1doC2Jw7ZqQeBnFOAlEyBypHc+ZC1P4o/vlICXEEooE7/iSA4rQ==", "127fea5e-3b61-4203-841b-a99bf53c6931" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ad466e0-92cb-4b53-a34c-d37b1e14d276", "AQAAAAIAAYagAAAAEPY20cdibVYqFll9X+zeBcRytHdsT7ZdoSznnRxvIQlFag8I3NW1wJuYPCiD9AwZQA==", "ad683407-1b4c-47c4-9ac2-ef73405859a0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f153e55c-2405-40d7-94b0-82cebebe96e4", "51c3aa5c-cc8b-4db0-b0d4-0a8161408463" },
                    { "85cfbc9b-a2ba-4836-a384-d56f98504729", "631ac7af-a965-4c1f-9b05-f40d426c8ad4" },
                    { "85fc8893-00c4-4459-a917-52fcd2370cc1", "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127" }
                });
        }
    }
}
