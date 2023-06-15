using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleRecomands.Infra.Migrations
{
    /// <inheritdoc />
    public partial class secondAlterMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Church_RecomendationId",
                table: "Recommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Member_RecomendationId",
                table: "Recommendation");

            migrationBuilder.DropIndex(
                name: "IX_Recommendation_RecomendationId",
                table: "Recommendation");

            migrationBuilder.DropColumn(
                name: "RecomendationId",
                table: "Recommendation");

            migrationBuilder.AddColumn<Guid>(
                name: "ChurchId",
                table: "ReceivedRecommendation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MemberId",
                table: "ReceivedRecommendation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ChurcId",
                table: "IssuedRecommendation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MemberId",
                table: "IssuedRecommendation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ReceivedRecommendation_ChurchId",
                table: "ReceivedRecommendation",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivedRecommendation_MemberId",
                table: "ReceivedRecommendation",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuedRecommendation_ChurcId",
                table: "IssuedRecommendation",
                column: "ChurcId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuedRecommendation_MemberId",
                table: "IssuedRecommendation",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_IssuedRecommendation_Church_ChurcId",
                table: "IssuedRecommendation",
                column: "ChurcId",
                principalTable: "Church",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IssuedRecommendation_Member_MemberId",
                table: "IssuedRecommendation",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceivedRecommendation_Church_ChurchId",
                table: "ReceivedRecommendation",
                column: "ChurchId",
                principalTable: "Church",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceivedRecommendation_Member_MemberId",
                table: "ReceivedRecommendation",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IssuedRecommendation_Church_ChurcId",
                table: "IssuedRecommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_IssuedRecommendation_Member_MemberId",
                table: "IssuedRecommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceivedRecommendation_Church_ChurchId",
                table: "ReceivedRecommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceivedRecommendation_Member_MemberId",
                table: "ReceivedRecommendation");

            migrationBuilder.DropIndex(
                name: "IX_ReceivedRecommendation_ChurchId",
                table: "ReceivedRecommendation");

            migrationBuilder.DropIndex(
                name: "IX_ReceivedRecommendation_MemberId",
                table: "ReceivedRecommendation");

            migrationBuilder.DropIndex(
                name: "IX_IssuedRecommendation_ChurcId",
                table: "IssuedRecommendation");

            migrationBuilder.DropIndex(
                name: "IX_IssuedRecommendation_MemberId",
                table: "IssuedRecommendation");

            migrationBuilder.DropColumn(
                name: "ChurchId",
                table: "ReceivedRecommendation");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "ReceivedRecommendation");

            migrationBuilder.DropColumn(
                name: "ChurcId",
                table: "IssuedRecommendation");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "IssuedRecommendation");

            migrationBuilder.AddColumn<Guid>(
                name: "RecomendationId",
                table: "Recommendation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Recommendation_RecomendationId",
                table: "Recommendation",
                column: "RecomendationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Church_RecomendationId",
                table: "Recommendation",
                column: "RecomendationId",
                principalTable: "Church",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Member_RecomendationId",
                table: "Recommendation",
                column: "RecomendationId",
                principalTable: "Member",
                principalColumn: "Id");
        }
    }
}
