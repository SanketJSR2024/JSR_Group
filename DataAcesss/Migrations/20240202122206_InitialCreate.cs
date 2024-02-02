using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcesss.Migrations
{
    public partial class InitialCreate : Migration
    {
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
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CriteriaBasket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriteriaBasket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelAmenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timming = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelAmenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    RegularRate = table.Column<double>(type: "float", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SqFt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareVersion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareVersion", x => x.Id);
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
                name: "CompanySoftware",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanySectionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySoftware", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanySoftware_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelRoomImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    RoomImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRoomImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelRoomImages_HotelRooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "HotelRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StripeSessionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualCheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualCheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<double>(type: "float", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    IsPaymentSuccessful = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomOrderDetails_HotelRooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "HotelRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareVersionFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionId = table.Column<int>(type: "int", nullable: true),
                    FeatureId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareVersionFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoftwareVersionFeatures_Feature_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Feature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SoftwareVersionFeatures_SoftwareVersion_VersionId",
                        column: x => x.VersionId,
                        principalTable: "SoftwareVersion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAdmin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyAdmin_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyAdmin_CompanySoftware_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "CompanySoftware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCustomer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCustomer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyCustomer_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyCustomer_CompanySoftware_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "CompanySoftware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyEmployee_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyEmployee_CompanySoftware_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "CompanySoftware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DefectType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DefectType_CompanySoftware_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "CompanySoftware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftwareId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Site_CompanySoftware_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "CompanySoftware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    WP_Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Shift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturingBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CriteriaBasket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleMatrix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElementWith = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellSize = table.Column<int>(type: "int", nullable: false),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDetails_CompanyEmployee_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CompanyEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectDetails_CompanySoftware_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "CompanySoftware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcceptanceCriteria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefectTypeId = table.Column<int>(type: "int", nullable: true),
                    PDId = table.Column<int>(type: "int", nullable: true),
                    UnitOfMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcceptableMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityAcceptable = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptanceCriteria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcceptanceCriteria_DefectType_DefectTypeId",
                        column: x => x.DefectTypeId,
                        principalTable: "DefectType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcceptanceCriteria_ProjectDetails_PDId",
                        column: x => x.PDId,
                        principalTable: "ProjectDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageProcessData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PDId = table.Column<int>(type: "int", nullable: true),
                    ModuleSerialNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeverityScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleCountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefectData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crack = table.Column<int>(type: "int", nullable: true),
                    TreeCrack = table.Column<int>(type: "int", nullable: true),
                    DeadCell = table.Column<int>(type: "int", nullable: true),
                    DarkArea = table.Column<int>(type: "int", nullable: true),
                    OpenSoldering = table.Column<int>(type: "int", nullable: true),
                    FingerInteruption = table.Column<int>(type: "int", nullable: true),
                    BackSheetCut = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    SoftwareId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageProcessData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageProcessData_CompanyEmployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "CompanyEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ImageProcessData_CompanySoftware_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "CompanySoftware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ImageProcessData_ProjectDetails_PDId",
                        column: x => x.PDId,
                        principalTable: "ProjectDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageProcessReq",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoftwareId = table.Column<int>(type: "int", nullable: true),
                    IsExposureSet = table.Column<bool>(type: "bit", nullable: true),
                    ExposureSetValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefectMarking = table.Column<bool>(type: "bit", nullable: true),
                    IsPerspectiveCorrection = table.Column<bool>(type: "bit", nullable: true),
                    IsRename = table.Column<bool>(type: "bit", nullable: true),
                    RenameWith = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTextInImage = table.Column<bool>(type: "bit", nullable: true),
                    TextInImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsImageFullScreen = table.Column<bool>(type: "bit", nullable: true),
                    IsSeverityScore = table.Column<bool>(type: "bit", nullable: true),
                    AcceptanceCriteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageProcessReq", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageProcessReq_CompanySoftware_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "CompanySoftware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ImageProcessReq_ProjectDetails_PDId",
                        column: x => x.PDId,
                        principalTable: "ProjectDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TextInImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsImageName = table.Column<bool>(type: "bit", nullable: true),
                    WPOfProduct = table.Column<bool>(type: "bit", nullable: true),
                    DateAndShift = table.Column<bool>(type: "bit", nullable: true),
                    IsManufacturer = table.Column<bool>(type: "bit", nullable: true),
                    ManufacturingPlantAndLine = table.Column<bool>(type: "bit", nullable: true),
                    SiteName = table.Column<bool>(type: "bit", nullable: true),
                    CustomerName = table.Column<bool>(type: "bit", nullable: true),
                    CriteriaName = table.Column<bool>(type: "bit", nullable: true),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    PDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextInImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextInImage_CompanySoftware_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "CompanySoftware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TextInImage_ProjectDetails_PDId",
                        column: x => x.PDId,
                        principalTable: "ProjectDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FactoryDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefectTypeId = table.Column<int>(type: "int", nullable: false),
                    UnitOfMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptableMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityAcceptablePerModule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    AccCriteriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactoryDetails_AcceptanceCriteria_AccCriteriaId",
                        column: x => x.AccCriteriaId,
                        principalTable: "AcceptanceCriteria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactoryDetails_CompanySoftware_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "CompanySoftware",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcceptanceCriteria_DefectTypeId",
                table: "AcceptanceCriteria",
                column: "DefectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AcceptanceCriteria_PDId",
                table: "AcceptanceCriteria",
                column: "PDId");

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
                name: "IX_CompanyAdmin_SoftwareId",
                table: "CompanyAdmin",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAdmin_UserId",
                table: "CompanyAdmin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomer_SoftwareId",
                table: "CompanyCustomer",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomer_UserId",
                table: "CompanyCustomer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyEmployee_SoftwareId",
                table: "CompanyEmployee",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyEmployee_UserId",
                table: "CompanyEmployee",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySoftware_CompanyId",
                table: "CompanySoftware",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DefectType_SoftwareId",
                table: "DefectType",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryDetails_AccCriteriaId",
                table: "FactoryDetails",
                column: "AccCriteriaId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryDetails_SoftwareId",
                table: "FactoryDetails",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoomImages_RoomId",
                table: "HotelRoomImages",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageProcessData_EmployeeId",
                table: "ImageProcessData",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageProcessData_PDId",
                table: "ImageProcessData",
                column: "PDId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageProcessData_SoftwareId",
                table: "ImageProcessData",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageProcessReq_PDId",
                table: "ImageProcessReq",
                column: "PDId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageProcessReq_SoftwareId",
                table: "ImageProcessReq",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDetails_CustomerId",
                table: "ProjectDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDetails_SoftwareId",
                table: "ProjectDetails",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomOrderDetails_RoomId",
                table: "RoomOrderDetails",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Site_SoftwareId",
                table: "Site",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareVersionFeatures_FeatureId",
                table: "SoftwareVersionFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareVersionFeatures_VersionId",
                table: "SoftwareVersionFeatures",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_TextInImage_PDId",
                table: "TextInImage",
                column: "PDId");

            migrationBuilder.CreateIndex(
                name: "IX_TextInImage_SoftwareId",
                table: "TextInImage",
                column: "SoftwareId");
        }

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
                name: "CompanyAdmin");

            migrationBuilder.DropTable(
                name: "CompanyCustomer");

            migrationBuilder.DropTable(
                name: "CriteriaBasket");

            migrationBuilder.DropTable(
                name: "FactoryDetails");

            migrationBuilder.DropTable(
                name: "HotelAmenities");

            migrationBuilder.DropTable(
                name: "HotelRoomImages");

            migrationBuilder.DropTable(
                name: "ImageProcessData");

            migrationBuilder.DropTable(
                name: "ImageProcessReq");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "RoomOrderDetails");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "SoftwareVersionFeatures");

            migrationBuilder.DropTable(
                name: "TextInImage");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AcceptanceCriteria");

            migrationBuilder.DropTable(
                name: "HotelRooms");

            migrationBuilder.DropTable(
                name: "Feature");

            migrationBuilder.DropTable(
                name: "SoftwareVersion");

            migrationBuilder.DropTable(
                name: "DefectType");

            migrationBuilder.DropTable(
                name: "ProjectDetails");

            migrationBuilder.DropTable(
                name: "CompanyEmployee");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CompanySoftware");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
