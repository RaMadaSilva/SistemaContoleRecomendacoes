using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleRecomands.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Church",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    City = table.Column<string>(type: "NVARCHAR(200)", maxLength: 200, nullable: false),
                    Reference = table.Column<string>(type: "NVARCHAR(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Church", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameComplete = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<int>(type: "INT", nullable: false),
                    City = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    Reference = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recommendation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChurchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateRecommendation = table.Column<int>(type: "int", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecommendationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DevolutionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChurchId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MemberId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recommendation_Church_ChurchId1",
                        column: x => x.ChurchId1,
                        principalTable: "Church",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recommendation_Church_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Church",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recommendation_Member_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recommendation_Member_MemberId1",
                        column: x => x.MemberId1,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IssuedRecommendation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecommendationGenerateUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuedRecommendation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssuedRecommendation_Recommendation_Id",
                        column: x => x.Id,
                        principalTable: "Recommendation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceivedRecommendation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttachmentRecommendationUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivedRecommendation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceivedRecommendation_Recommendation_Id",
                        column: x => x.Id,
                        principalTable: "Recommendation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recommendation_ChurchId",
                table: "Recommendation",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendation_ChurchId1",
                table: "Recommendation",
                column: "ChurchId1");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendation_MemberId",
                table: "Recommendation",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendation_MemberId1",
                table: "Recommendation",
                column: "MemberId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssuedRecommendation");

            migrationBuilder.DropTable(
                name: "ReceivedRecommendation");

            migrationBuilder.DropTable(
                name: "Recommendation");

            migrationBuilder.DropTable(
                name: "Church");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
