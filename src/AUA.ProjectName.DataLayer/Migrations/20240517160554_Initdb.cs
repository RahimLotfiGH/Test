using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AUA.ProjectName.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "acc");

            migrationBuilder.EnsureSchema(
                name: "Ordering");

            migrationBuilder.EnsureSchema(
                name: "Commodity");

            migrationBuilder.EnsureSchema(
                name: "Transport");

            migrationBuilder.CreateTable(
                name: "ActiveAccessToken",
                schema: "acc",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<long>(type: "bigint", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    TokenInfo_ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TokenInfo_RefreshToken = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TokenInfo_AccessToken = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false, defaultValueSql: "GetDate()"),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveAccessToken", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                schema: "acc",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserContact_Phone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UserContact_Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false, defaultValueSql: "GetDate()"),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                schema: "acc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientIdentity = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppType = table.Column<int>(type: "int", nullable: false),
                    ClientTokenExpiration_AccessTokenExpirationMinutes = table.Column<int>(type: "int", nullable: false),
                    ClientTokenExpiration_RefreshTokenExpirationMinutes = table.Column<int>(type: "int", nullable: false),
                    ClientTokenExpiration_NotBeforeMinutes = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commodity",
                schema: "Commodity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtraPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BreakableStatus = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false, defaultValueSql: "GetDate()"),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "Ordering",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false, defaultValueSql: "GetDate()"),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "acc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAccess",
                schema: "acc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    AccessCode = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsIndirect = table.Column<bool>(type: "bit", nullable: false),
                    PageInf_Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PageInf_Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                schema: "acc",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AppUserId = table.Column<long>(type: "bigint", nullable: false),
                    PasswordCredential_Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PasswordCredential_Salt = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PasswordCredential_PasswordSecurityRate = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false, defaultValueSql: "GetDate()"),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalSchema: "acc",
                        principalTable: "AppUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChangeStatusHistory",
                schema: "Ordering",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StatusDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false, defaultValueSql: "GetDate()"),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeStatusHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChangeStatusHistory_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "Ordering",
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderCommodity",
                schema: "Ordering",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommodityTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommodityPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtraPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    BreakableStatus = table.Column<int>(type: "int", nullable: false),
                    CommodityId = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false, defaultValueSql: "GetDate()"),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderCommodity_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalSchema: "Commodity",
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderCommodity_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "Ordering",
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                schema: "Transport",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    TransportType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false, defaultValueSql: "GetDate()"),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transport_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "Ordering",
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUserAccess",
                schema: "acc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserAccessId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUserAccess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleUserAccess_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "acc",
                        principalTable: "Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoleUserAccess_UserAccess_UserAccessId",
                        column: x => x.UserAccessId,
                        principalSchema: "acc",
                        principalTable: "UserAccess",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AccountRole",
                schema: "acc",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAccountId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false, defaultValueSql: "GetDate()"),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountRole_Account_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "acc",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "acc",
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "acc",
                table: "AppUser",
                columns: new[] { "Id", "CreatorUserId", "FirstName", "IsActive", "LastName", "UserContact_Email", "UserContact_Phone" },
                values: new object[] { 1L, 1L, "Rahim", true, "Lotfi", "Mr_lotfi@ymail.com", "+989199906342" });

            migrationBuilder.InsertData(
                schema: "acc",
                table: "Client",
                columns: new[] { "Id", "AppType", "ClientIdentity", "CreatorUserId", "Description", "IsActive", "IsDefault", "RegistrationDate", "Title", "ClientTokenExpiration_AccessTokenExpirationMinutes", "ClientTokenExpiration_NotBeforeMinutes", "ClientTokenExpiration_RefreshTokenExpirationMinutes" },
                values: new object[] { 1, 1, new Guid("9245fe4a-d402-451c-b9ed-9c1a04247482"), 1L, "AUA default", true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Default App", 60, 0, 120 });

            migrationBuilder.InsertData(
                schema: "acc",
                table: "Role",
                columns: new[] { "Id", "CreatorUserId", "Description", "IsActive", "RegistrationDate", "Title" },
                values: new object[,]
                {
                    { 1, 1L, "AUA default role", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin" },
                    { 2, 1L, "AUA default role", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User" }
                });

            migrationBuilder.InsertData(
                schema: "acc",
                table: "UserAccess",
                columns: new[] { "Id", "PageInf_Description", "PageInf_Title", "AccessCode", "CreatorUserId", "IsActive", "IsIndirect", "ParentId", "RegistrationDate", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "User Management", "User Management", 1, 1L, true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User Management", "../Accounting/AppUser" },
                    { 2, "Access level management", "Access level management", 3, 1L, true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Access level management", "../Accounting/UserAccess" },
                    { 3, "Role Management", "Role Management", 2, 1L, true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Role Management", "../Accounting/Role" },
                    { 4, "Report access to to users", "Report access to users", 4, 1L, true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Report access to users", "../reports/UserAccessReport" },
                    { 5, "Reset Password", "Reset User Password", 5, 1L, true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reset Password", "" },
                    { 6, "Assign access to roles", "Assign access to roles", 6, 1L, true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User Access Report", "" },
                    { 7, "", "Account ", 7, 1L, true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Account Management", "" }
                });

            migrationBuilder.InsertData(
                schema: "acc",
                table: "Account",
                columns: new[] { "Id", "AppUserId", "CreatorUserId", "IsActive", "UserName", "PasswordCredential_Password", "PasswordCredential_PasswordSecurityRate", "PasswordCredential_Salt" },
                values: new object[] { 1L, 1L, 1L, true, "admin", "07479BB27E983DD65312BB13F34FE1DDD6E7D597AA7C91C8156B246FA12E0DCF1598CD29D3760225B6C81287F88E1F1F912D1325D4CDE7E77584CEAE6A40E2C8", 1, "OJfR9nZCD2W4hUaWJxxqGt4Bo/F4Bpcy7cdXAaTcHsI=" });

            migrationBuilder.InsertData(
                schema: "acc",
                table: "RoleUserAccess",
                columns: new[] { "Id", "CreatorUserId", "IsActive", "RegistrationDate", "RoleId", "UserAccessId" },
                values: new object[,]
                {
                    { 1, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 3, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 4, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 5, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 6, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 7, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 7 },
                    { 8, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 9, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 10, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 11, 1L, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6 }
                });

            migrationBuilder.InsertData(
                schema: "acc",
                table: "AccountRole",
                columns: new[] { "Id", "CreatorUserId", "IsActive", "RoleId", "UserAccountId" },
                values: new object[] { 1L, 1L, true, 1, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_Account_AppUserId",
                schema: "acc",
                table: "Account",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRole_RoleId",
                schema: "acc",
                table: "AccountRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRole_UserAccountId",
                schema: "acc",
                table: "AccountRole",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeStatusHistory_OrderId",
                schema: "Ordering",
                table: "ChangeStatusHistory",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCommodity_CommodityId",
                schema: "Ordering",
                table: "OrderCommodity",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCommodity_OrderId",
                schema: "Ordering",
                table: "OrderCommodity",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUserAccess_RoleId",
                schema: "acc",
                table: "RoleUserAccess",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUserAccess_UserAccessId",
                schema: "acc",
                table: "RoleUserAccess",
                column: "UserAccessId");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_OrderId",
                schema: "Transport",
                table: "Transport",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountRole",
                schema: "acc");

            migrationBuilder.DropTable(
                name: "ActiveAccessToken",
                schema: "acc");

            migrationBuilder.DropTable(
                name: "ChangeStatusHistory",
                schema: "Ordering");

            migrationBuilder.DropTable(
                name: "Client",
                schema: "acc");

            migrationBuilder.DropTable(
                name: "OrderCommodity",
                schema: "Ordering");

            migrationBuilder.DropTable(
                name: "RoleUserAccess",
                schema: "acc");

            migrationBuilder.DropTable(
                name: "Transport",
                schema: "Transport");

            migrationBuilder.DropTable(
                name: "Account",
                schema: "acc");

            migrationBuilder.DropTable(
                name: "Commodity",
                schema: "Commodity");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "acc");

            migrationBuilder.DropTable(
                name: "UserAccess",
                schema: "acc");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "Ordering");

            migrationBuilder.DropTable(
                name: "AppUser",
                schema: "acc");
        }
    }
}
