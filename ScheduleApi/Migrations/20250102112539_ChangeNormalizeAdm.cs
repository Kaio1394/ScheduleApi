using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScheduleApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNormalizeAdm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85cfbc9b-a2ba-4836-a384-d56f98504729",
                column: "NormalizedName",
                value: "ADMIN");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2137b6e0-5575-4ce6-b9d6-4532672f844f", "AQAAAAIAAYagAAAAEBS8EorJ2kweQ614EHh4q7AA/D+fKMvw0yHyV1B5GRld9LOxL3WiaXTh7G139RyKgg==", "1a9ca3d3-5218-4994-884c-525522186df4" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85cfbc9b-a2ba-4836-a384-d56f98504729",
                column: "NormalizedName",
                value: "ADM");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9a10673-67f9-4cb5-8aaa-b7cb1c8ab40a", "AQAAAAIAAYagAAAAEKgYouh0LgQQGEXHd0VB1vNnZAdEzNx+7ikHY38EprLFWEO2PG3x8LwT71+MN3xy1w==", "fc151d3d-320c-4aaf-9ade-9abd9bfd9b50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "631ac7af-a965-4c1f-9b05-f40d426c8ad4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99b6506a-4289-4a13-94f5-edee573f69a4", "AQAAAAIAAYagAAAAEOgk2SWrHd+Zmw9uMcRM6ElTF6uoTXdticjRE96LN9oo88uLYnuMtbkBxH4I8tDSHw==", "c5fece0b-1ab5-4b77-bb03-5a15c98f0f04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c691830-2479-4fe6-8ddd-1c1636e0a1ea", "AQAAAAIAAYagAAAAEIN+rWCAroJgR4+8xrFsrWh6NWRtE39ELve2YsUi75QR67jWGNXwmDcs4KYdM3INzw==", "4372aa30-7f89-4165-b89a-5c073e8633dc" });
        }
    }
}
