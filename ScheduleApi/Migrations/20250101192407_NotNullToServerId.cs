using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScheduleApi.Migrations
{
    /// <inheritdoc />
    public partial class NotNullToServerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51c3aa5c-cc8b-4db0-b0d4-0a8161408463",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2fc5be4-6560-445e-8721-3bf8130f9c2e", "AQAAAAIAAYagAAAAECXMkgB8iY6XZycwrQBTvLnfRfiozruJ8MOKMriEhWAMmb9iVyuyjO5/X/Ri6A5zYw==", "f4a8bed7-056a-44ab-8d9f-d69a854c7e18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "631ac7af-a965-4c1f-9b05-f40d426c8ad4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d91bd1a-ba40-4b1b-a212-4aa9a6dd3570", "AQAAAAIAAYagAAAAEA7SHI8IX7MJ3gaGCfU6b2TSj87qo1rZYb6FWZzFszN+3bpvrgmjhewBJUZnB90s4g==", "69b08f6e-684a-4654-a855-f519f08795bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9da896d-4530-412d-8372-01ae7d77c6ac", "AQAAAAIAAYagAAAAECz4/NOuIs/P8PA9LGj6Udz0G9trHwcpqPOQ7gtd4CylgVoNLWYf48LuSGKOdh62EQ==", "774aa22b-9065-4d5c-8402-abdcb4b3b634" });
        }
    }
}
