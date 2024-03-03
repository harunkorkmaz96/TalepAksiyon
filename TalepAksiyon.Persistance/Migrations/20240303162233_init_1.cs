using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalepAksiyon.Persistance.Migrations
{
    public partial class init_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailHost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnableSsl = table.Column<bool>(type: "bit", nullable: false),
                    EmailPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApiKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerDescriptionID = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizationStatus = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Modules_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectNotes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoteType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddUserNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectNotes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProjectNotes_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProjectNotes_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatabaseChangeStatus = table.Column<int>(type: "int", nullable: true),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Versions_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    NotificationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationTypeID = table.Column<int>(type: "int", nullable: true),
                    PageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlanedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestStatus = table.Column<int>(type: "int", nullable: false),
                    NotificationID = table.Column<int>(type: "int", nullable: false),
                    VersionID = table.Column<int>(type: "int", nullable: true),
                    ModuleID = table.Column<int>(type: "int", nullable: true),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Requests_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Requests_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Requests_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Versions_VersionID",
                        column: x => x.VersionID,
                        principalTable: "Versions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponsibleID = table.Column<int>(type: "int", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionStatus = table.Column<int>(type: "int", nullable: false),
                    RequestStatus = table.Column<int>(type: "int", nullable: false),
                    ActionPriorityStatus = table.Column<int>(type: "int", nullable: false),
                    RequestID = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Actions_Requests_RequestID",
                        column: x => x.RequestID,
                        principalTable: "Requests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actions_Users_ResponsibleID",
                        column: x => x.ResponsibleID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanedStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlanedEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponsibleID = table.Column<int>(type: "int", nullable: false),
                    TaskStatus = table.Column<int>(type: "int", nullable: false),
                    PriorityStatus = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    RequestID = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tasks_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Requests_RequestID",
                        column: x => x.RequestID,
                        principalTable: "Requests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actions_RequestID",
                table: "Actions",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_ResponsibleID",
                table: "Actions",
                column: "ResponsibleID");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ProjectID",
                table: "Modules",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectNotes_CustomerID",
                table: "ProjectNotes",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectNotes_ProjectID",
                table: "ProjectNotes",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CustomerID",
                table: "Requests",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ModuleID",
                table: "Requests",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ProjectID",
                table: "Requests",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_VersionID",
                table: "Requests",
                column: "VersionID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CustomerID",
                table: "Tasks",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_RequestID",
                table: "Tasks",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CustomerID",
                table: "Users",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Versions_ProjectID",
                table: "Versions",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "ProjectNotes");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Versions");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
