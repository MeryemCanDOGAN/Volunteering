using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace volunteer.Migrations
{
    public partial class vol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsBlocked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsVisibility = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Branch = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OpenAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberofClass = table.Column<int>(type: "int", nullable: false),
                    NumberofStudent = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Schools_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SchoolId = table.Column<int>(type: "int", nullable: true),
                    ADetails = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CoatSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SixandEightYears = table.Column<int>(type: "int", nullable: false),
                    EightandTenYears = table.Column<int>(type: "int", nullable: false),
                    TenandTwelveYears = table.Column<int>(type: "int", nullable: false),
                    TwelveandFourteen = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: true),
                    Counts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoatSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoatSizes_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HatScarfGloveSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SixandEightYears = table.Column<int>(type: "int", nullable: false),
                    EightandTenYears = table.Column<int>(type: "int", nullable: false),
                    TenandTwelveYears = table.Column<int>(type: "int", nullable: false),
                    TwelveandFourteen = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: true),
                    Counts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HatScarfGloveSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HatScarfGloveSizes_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShoesSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ThirtyTwo = table.Column<int>(type: "int", nullable: false),
                    ThirtyThree = table.Column<int>(type: "int", nullable: false),
                    ThirtyFour = table.Column<int>(type: "int", nullable: false),
                    ThirtyFive = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: true),
                    Counts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoesSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoesSizes_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StationeryEquipmentLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Book = table.Column<int>(type: "int", nullable: false),
                    Notebook = table.Column<int>(type: "int", nullable: false),
                    Pencil = table.Column<int>(type: "int", nullable: false),
                    Eraser = table.Column<int>(type: "int", nullable: false),
                    Backpack = table.Column<int>(type: "int", nullable: false),
                    Lunchbox = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: true),
                    Counts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationeryEquipmentLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StationeryEquipmentLists_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ListOfRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CoatSizeId = table.Column<int>(type: "int", nullable: false),
                    HatScarfGloveSizeId = table.Column<int>(type: "int", nullable: false),
                    ShoesSizeId = table.Column<int>(type: "int", nullable: false),
                    StationeryEquipmentListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfRequirements_CoatSizes_CoatSizeId",
                        column: x => x.CoatSizeId,
                        principalTable: "CoatSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListOfRequirements_HatScarfGloveSizes_HatScarfGloveSizeId",
                        column: x => x.HatScarfGloveSizeId,
                        principalTable: "HatScarfGloveSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListOfRequirements_ShoesSizes_ShoesSizeId",
                        column: x => x.ShoesSizeId,
                        principalTable: "ShoesSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListOfRequirements_StationeryEquipmentLists_StationeryEquipm~",
                        column: x => x.StationeryEquipmentListId,
                        principalTable: "StationeryEquipmentLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "IsBlocked", "IsVisibility", "Password" },
                values: new object[,]
                {
                    { 1, "meryem.dogan@sahabt.com", true, true, "123123" },
                    { 2, "fsm@gmail.com", true, true, "555555" },
                    { 3, "gokhan@gmail.com", true, true, "1111111" },
                    { 4, "bkagan@gmail.com", true, true, "1111111" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "İstanbul" },
                    { 2, "İzmir" },
                    { 3, "Ankara" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Woman" },
                    { 2, "Man" },
                    { 3, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Volunteer" },
                    { 3, "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Branch", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 1, "Sınıf Ogretmeni", "Ayşe", 5555222, "Demir" },
                    { 2, "Sınıf Ogretmeni", "Mehmet", 5555222, "Demir" },
                    { 3, "Sınıf Ogretmeni", "Fatma", 5555222, "Demir" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[] { 1, 1, "Beylikdüzü" });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[] { 2, 2, "Avcılar" });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[] { 3, 3, "Büyükçekmece" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CityId", "DistrictId", "OpenAddress" },
                values: new object[] { 1, 1, 1, "Beylikdüzü/İstanbul" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CityId", "DistrictId", "OpenAddress" },
                values: new object[] { 2, 2, 2, "İzmir/Avcılar" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CityId", "DistrictId", "OpenAddress" },
                values: new object[] { 3, 3, 3, "Ankara/Büyükçekmece" });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "AddressId", "Name", "NumberofClass", "NumberofStudent", "TeacherId" },
                values: new object[,]
                {
                    { 1, 2, "Büyükşehir İlkÖğretim Okulu", 6, 50, 1 },
                    { 2, 3, "Bizimkent İlkÖğretim Okulu", 5, 32, 2 },
                    { 3, 2, "Koç İlkÖğretim Okulu", 6, 50, 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountId", "AddressId", "BirthDate", "FirstName", "GenderId", "LastName", "PhoneNumber", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Meryem Can", 1, "Dogan", 1231231, 1, "mcan" },
                    { 2, 2, 2, new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Fatih Sultan Mehmet", 2, "Dogan", 12312312, 2, "fsm" },
                    { 3, 3, 3, new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Gökhan", 2, "Dogan", 123123123, 3, "gkhn" },
                    { 4, 4, 2, new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Bilge Kagan", 2, "Dogan", 123123123, 2, "bkgn" }
                });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "ADetails", "ReleaseDate", "SchoolId" },
                values: new object[,]
                {
                    { 1, "Köy okullarına yardım için kırtasiye ürünleri topluyoruz.", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 2 },
                    { 2, "Köy okullarındaki öğrenci kardeşlerimizin Mont, Bot, Çanta eksiklerini birlikte tamamlayalım.", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 3 },
                    { 3, "Az çok demeyelim , Köy okullarındaki öğrenci kardeşlerimizin Mont, Bot, Çanta eksiklerini birlikte tamamlayalım.", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 1 }
                });

            migrationBuilder.InsertData(
                table: "CoatSizes",
                columns: new[] { "Id", "Counts", "EightandTenYears", "SchoolId", "SixandEightYears", "TenandTwelveYears", "TwelveandFourteen" },
                values: new object[,]
                {
                    { 1, null, 14, 2, 10, 22, 32 },
                    { 2, null, 15, 1, 14, 11, 12 },
                    { 3, null, 18, 3, 15, 12, 25 }
                });

            migrationBuilder.InsertData(
                table: "HatScarfGloveSizes",
                columns: new[] { "Id", "Counts", "EightandTenYears", "SchoolId", "SixandEightYears", "TenandTwelveYears", "TwelveandFourteen" },
                values: new object[,]
                {
                    { 1, null, 12, 1, 10, 23, 18 },
                    { 2, null, 33, 2, 11, 28, 55 },
                    { 3, null, 26, 3, 32, 45, 29 }
                });

            migrationBuilder.InsertData(
                table: "ShoesSizes",
                columns: new[] { "Id", "Counts", "SchoolId", "ThirtyFive", "ThirtyFour", "ThirtyThree", "ThirtyTwo" },
                values: new object[,]
                {
                    { 1, null, 1, 14, 11, 16, 12 },
                    { 2, null, 2, 14, 11, 13, 12 },
                    { 3, null, 3, 9, 11, 6, 12 }
                });

            migrationBuilder.InsertData(
                table: "StationeryEquipmentLists",
                columns: new[] { "Id", "Backpack", "Book", "Counts", "Eraser", "Lunchbox", "Notebook", "Pencil", "SchoolId" },
                values: new object[,]
                {
                    { 1, 120, 25, null, 190, 120, 100, 180, 1 },
                    { 2, 155, 90, null, 300, 155, 200, 250, 2 },
                    { 3, 80, 25, null, 165, 80, 100, 180, 3 }
                });

            migrationBuilder.InsertData(
                table: "ListOfRequirements",
                columns: new[] { "Id", "CoatSizeId", "HatScarfGloveSizeId", "ShoesSizeId", "StationeryEquipmentListId" },
                values: new object[] { 1, 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "ListOfRequirements",
                columns: new[] { "Id", "CoatSizeId", "HatScarfGloveSizeId", "ShoesSizeId", "StationeryEquipmentListId" },
                values: new object[] { 2, 3, 1, 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistrictId",
                table: "Addresses",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_SchoolId",
                table: "Announcements",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_CoatSizes_SchoolId",
                table: "CoatSizes",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_HatScarfGloveSizes_SchoolId",
                table: "HatScarfGloveSizes",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfRequirements_CoatSizeId",
                table: "ListOfRequirements",
                column: "CoatSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfRequirements_HatScarfGloveSizeId",
                table: "ListOfRequirements",
                column: "HatScarfGloveSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfRequirements_ShoesSizeId",
                table: "ListOfRequirements",
                column: "ShoesSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfRequirements_StationeryEquipmentListId",
                table: "ListOfRequirements",
                column: "StationeryEquipmentListId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_AddressId",
                table: "Schools",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_TeacherId",
                table: "Schools",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesSizes_SchoolId",
                table: "ShoesSizes",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryEquipmentLists_SchoolId",
                table: "StationeryEquipmentLists",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AccountId",
                table: "User",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AddressId",
                table: "User",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_User_GenderId",
                table: "User",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "ListOfRequirements");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "CoatSizes");

            migrationBuilder.DropTable(
                name: "HatScarfGloveSizes");

            migrationBuilder.DropTable(
                name: "ShoesSizes");

            migrationBuilder.DropTable(
                name: "StationeryEquipmentLists");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
