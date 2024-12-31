using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScheduleApi.Migrations
{
    /// <inheritdoc />
    public partial class extendDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobHistoryExecution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameJob = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GuidJob = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastExecution = table.Column<DateTime>(type: "datetime", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StatusEnd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JobHisto__3214EC074A015E44", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobHistoryModified",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameJob = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GuidJob = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JobHisto__3214EC07201CB68A", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GuidJob = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JobStatu__3214EC07DEDD8195", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Server",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GuidServer = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IPAddress = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Server__3214EC076AA2AB77", x => x.Id);
                    table.UniqueConstraint("AK_Server_GuidServer", x => x.GuidServer);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobExecution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GuidJob = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    GuidServer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataExec = table.Column<DateOnly>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Script = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Timeout = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__3214EC07A879D89C", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobExecution_ToServer",
                        column: x => x.GuidServer,
                        principalTable: "Server",
                        principalColumn: "GuidServer");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "85cfbc9b-a2ba-4836-a384-d56f98504729", null, "Admin", "ADM" },
                    { "85fc8893-00c4-4459-a917-52fcd2370cc1", null, "UserExecutor", "USER_EXECUTOR" },
                    { "f153e55c-2405-40d7-94b0-82cebebe96e4", null, "UserRunner", "USER_RUNNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "51c3aa5c-cc8b-4db0-b0d4-0a8161408463", 0, "c406e1fc-11ec-41af-880c-6de7870cfe3f", "user_runner@schedule.com", false, "System", "UserRunner", false, null, "USER_RUNNER@SCHEDULE.COM", "USER_RUNNER@SCHEDULE.COM", "AQAAAAIAAYagAAAAEDMIcl/wGQ1hRev6efofP5CkgePcqsypir1EIiwSdfMlrUIMQMfwFA4BUUhE52+lsA==", null, false, "a2192397-2b34-436f-acc2-498e7e399f20", false, "user_runner@schedule.com" },
                    { "631ac7af-a965-4c1f-9b05-f40d426c8ad4", 0, "91530e8c-61b1-43bc-b1bd-1c75e45ae1d8", "admin@schedule.com", false, "System", "Admin", false, null, "ADMIN@SCHEDULE.COM", "ADMIN@SCHEDULE.COM", "AQAAAAIAAYagAAAAEKnr5fL7982cnXZH0j45PnAf4z4kcUH3h1p6n3Gh3BeqV2W8KkKY3exX2Rh2CmfF5A==", null, false, "0bf262f2-1efb-4a00-aed9-17a39d849675", false, "admin@schedule.com" },
                    { "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127", 0, "7e8c48cf-8e45-410e-9ece-0ba3ef46b6e7", "user_executor@schedule.com", false, "System", "UserExecutor", false, null, "USER_EXECUTOR@SCHEDULE.COM", "USER_EXECUTOR@SCHEDULE.COM", "AQAAAAIAAYagAAAAEFeQyydpNAL9lQHLTp/hKUWUnNVjllF+Uu8oDftQddriMj3waSzTvHB94in8qjirJg==", null, false, "8724ce3c-e2f5-4124-91d2-6ee8abd37d9d", false, "user_executor@schedule.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f153e55c-2405-40d7-94b0-82cebebe96e4", "51c3aa5c-cc8b-4db0-b0d4-0a8161408463" },
                    { "85cfbc9b-a2ba-4836-a384-d56f98504729", "631ac7af-a965-4c1f-9b05-f40d426c8ad4" },
                    { "85fc8893-00c4-4459-a917-52fcd2370cc1", "de79ccd4-4bc4-4bd0-94bc-ec1dcf4ec127" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_JobExecution_GuidServer",
                table: "JobExecution",
                column: "GuidServer");

            migrationBuilder.CreateIndex(
                name: "UQ__JobExecu__737584F683F6B7AC",
                table: "JobExecution",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__JobExecu__E80EE384BB3B7228",
                table: "JobExecution",
                column: "GuidJob",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Server__BDE0FD1D1A7B2240",
                table: "Server",
                column: "TagName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Server__DCCC6CDC76E84F4B",
                table: "Server",
                column: "GuidServer",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "JobExecution");

            migrationBuilder.DropTable(
                name: "JobHistoryExecution");

            migrationBuilder.DropTable(
                name: "JobHistoryModified");

            migrationBuilder.DropTable(
                name: "JobStatus");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Server");
        }
    }
}
