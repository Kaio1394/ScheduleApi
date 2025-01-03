using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScheduleApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f153e55c-2405-40d7-94b0-82cebebe96e4",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { " UserJobCreator", "USER_JOB_CREATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8f583b67-9975-4da0-9723-5734bb558d67", "user_job_creator@schedule.com", "UserjobCreator", "USER_JOB_CREATOR@SCHEDULE.COM", "USER_JOB_CREATO@SCHEDULE.COM", "AQAAAAIAAYagAAAAEObqpymvvaPCprcazsO0k9Iw7PooxjV3wdz5Zc9k02cLaP0LmT2Fc4uzHXfCKJju+Q==", "769050bd-d28a-4e2a-8ee9-bd01e16e23c6", "user_job_creator@schedule.com" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f153e55c-2405-40d7-94b0-82cebebe96e4",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "UserRunner", "USER_RUNNER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                columns: new[] { "ConcurrencyStamp", "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2137b6e0-5575-4ce6-b9d6-4532672f844f", "user_runner@schedule.com", "UserRunner", "USER_RUNNER@SCHEDULE.COM", "USER_RUNNER@SCHEDULE.COM", "AQAAAAIAAYagAAAAEBS8EorJ2kweQ614EHh4q7AA/D+fKMvw0yHyV1B5GRld9LOxL3WiaXTh7G139RyKgg==", "1a9ca3d3-5218-4994-884c-525522186df4", "user_runner@schedule.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "631ac7af-a965-4c1f-9b05-f40d426c8ad4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b01d7c7-52a4-4587-9fc6-7e252b7d0f94", "AQAAAAIAAYagAAAAEHRBYLX84NkZy2K/VDh0rxbHJsZl1XOvI2b0137i4PiRRxMDzIinObt4MjweFZTFfA==", "0c250d57-426f-4653-bbc3-a4811e7f8492" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e20d79d-ebae-4c3c-bc2d-b40cbff7e759", "AQAAAAIAAYagAAAAEEwODdZtHxmFwpiiAMg6xoHiqsyEedPA/tkAQtkQs5EzaFRl+9a84bXSWrgplIXRLA==", "274c98d4-5b9d-4086-b33b-efaa2df91aad" });
        }
    }
}
