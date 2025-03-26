using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "Equipment_Condition",
                columns: table => new
                {
                    Equipment_Condition_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment_Condition", x => x.Equipment_Condition_ID);
                });

            migrationBuilder.CreateTable(
                name: "Equipment_Status",
                columns: table => new
                {
                    Equipment_Status_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment_Status", x => x.Equipment_Status_ID);
                });

            migrationBuilder.CreateTable(
                name: "Request_Status",
                columns: table => new
                {
                    Request_Status_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request_Status", x => x.Request_Status_ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Equipment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RentalRate = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Category_ID = table.Column<int>(type: "int", nullable: false),
                    Equipment_Condition_ID = table.Column<int>(type: "int", nullable: false),
                    Equipment_Status_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Equipment_ID);
                    table.ForeignKey(
                        name: "FK_Equipment_Category",
                        column: x => x.Category_ID,
                        principalTable: "Category",
                        principalColumn: "Category_ID");
                    table.ForeignKey(
                        name: "FK_Equipment_Equipment_Condition",
                        column: x => x.Equipment_Condition_ID,
                        principalTable: "Equipment_Condition",
                        principalColumn: "Equipment_Condition_ID");
                    table.ForeignKey(
                        name: "FK_Equipment_Equipment_Status",
                        column: x => x.Equipment_Status_ID,
                        principalTable: "Equipment_Status",
                        principalColumn: "Equipment_Status_ID");
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Log_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    CurrentValue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    OriginalValue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EntityChanged = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Log_ID);
                    table.ForeignKey(
                        name: "FK_Log_User",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Notification_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Massege = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Notification_ID);
                    table.ForeignKey(
                        name: "FK_Notification_User",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Rental_Request",
                columns: table => new
                {
                    Rental_Request_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(type: "date", nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    Equipment_ID = table.Column<int>(type: "int", nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Request_Status_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental_Request", x => x.Rental_Request_ID);
                    table.ForeignKey(
                        name: "FK_Rental_Request_Equipment",
                        column: x => x.Equipment_ID,
                        principalTable: "Equipment",
                        principalColumn: "Equipment_ID");
                    table.ForeignKey(
                        name: "FK_Rental_Request_Request_Status",
                        column: x => x.Request_Status_ID,
                        principalTable: "Request_Status",
                        principalColumn: "Request_Status_ID");
                    table.ForeignKey(
                        name: "FK_Rental_Request_User",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Rental_Transaction",
                columns: table => new
                {
                    Rental_transaction_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentalStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    TotalCost = table.Column<decimal>(type: "money", nullable: false),
                    RentalEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    PaymentStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Rental_Request_ID = table.Column<int>(type: "int", nullable: false),
                    Equipment_ID = table.Column<int>(type: "int", nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental_Transaction", x => x.Rental_transaction_ID);
                    table.ForeignKey(
                        name: "FK_Rental_Transaction_Equipment",
                        column: x => x.Equipment_ID,
                        principalTable: "Equipment",
                        principalColumn: "Equipment_ID");
                    table.ForeignKey(
                        name: "FK_Rental_Transaction_Rental_Request",
                        column: x => x.Rental_Request_ID,
                        principalTable: "Rental_Request",
                        principalColumn: "Rental_Request_ID");
                    table.ForeignKey(
                        name: "FK_Rental_Transaction_User",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Document_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rental_transaction_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Document_ID);
                    table.ForeignKey(
                        name: "FK_Document_Rental_Transaction",
                        column: x => x.Rental_transaction_ID,
                        principalTable: "Rental_Transaction",
                        principalColumn: "Rental_transaction_ID");
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Feedback_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    comment = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Rental_Transaction_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Feedback_ID);
                    table.ForeignKey(
                        name: "FK_Feedback_Rental_Transaction",
                        column: x => x.Rental_Transaction_ID,
                        principalTable: "Rental_Transaction",
                        principalColumn: "Rental_transaction_ID");
                    table.ForeignKey(
                        name: "FK_Feedback_User",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Return_Record",
                columns: table => new
                {
                    Return_Record_ID = table.Column<int>(type: "int", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "date", nullable: false),
                    Rental_transaction_ID = table.Column<int>(type: "int", nullable: false),
                    Equipment_ID = table.Column<int>(type: "int", nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Equipment_Condition_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return_Record", x => x.Return_Record_ID);
                    table.ForeignKey(
                        name: "FK_Return_Record_Equipment",
                        column: x => x.Equipment_ID,
                        principalTable: "Equipment",
                        principalColumn: "Equipment_ID");
                    table.ForeignKey(
                        name: "FK_Return_Record_Equipment_Condition",
                        column: x => x.Equipment_Condition_ID,
                        principalTable: "Equipment_Condition",
                        principalColumn: "Equipment_Condition_ID");
                    table.ForeignKey(
                        name: "FK_Return_Record_Rental_Transaction",
                        column: x => x.Rental_transaction_ID,
                        principalTable: "Rental_Transaction",
                        principalColumn: "Rental_transaction_ID");
                    table.ForeignKey(
                        name: "FK_Return_Record_User",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_Rental_transaction_ID",
                table: "Document",
                column: "Rental_transaction_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_Category_ID",
                table: "Equipment",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_Equipment_Condition_ID",
                table: "Equipment",
                column: "Equipment_Condition_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_Equipment_Status_ID",
                table: "Equipment",
                column: "Equipment_Status_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_Rental_Transaction_ID",
                table: "Feedback",
                column: "Rental_Transaction_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_User_ID",
                table: "Feedback",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Log_User_ID",
                table: "Log",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_User_ID",
                table: "Notification",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Request_Equipment_ID",
                table: "Rental_Request",
                column: "Equipment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Request_Request_Status_ID",
                table: "Rental_Request",
                column: "Request_Status_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Request_User_ID",
                table: "Rental_Request",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Transaction_Equipment_ID",
                table: "Rental_Transaction",
                column: "Equipment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Transaction_Rental_Request_ID",
                table: "Rental_Transaction",
                column: "Rental_Request_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Transaction_User_ID",
                table: "Rental_Transaction",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Return_Record_Equipment_Condition_ID",
                table: "Return_Record",
                column: "Equipment_Condition_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Return_Record_Equipment_ID",
                table: "Return_Record",
                column: "Equipment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Return_Record_Rental_transaction_ID",
                table: "Return_Record",
                column: "Rental_transaction_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Return_Record_User_ID",
                table: "Return_Record",
                column: "User_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Return_Record");

            migrationBuilder.DropTable(
                name: "Rental_Transaction");

            migrationBuilder.DropTable(
                name: "Rental_Request");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Request_Status");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Equipment_Condition");

            migrationBuilder.DropTable(
                name: "Equipment_Status");
        }
    }
}
