using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleRecomands.Infra.Migrations
{
    /// <inheritdoc />
    public partial class firstAlterMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Church_ChurchId1",
                table: "Recommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Church_MemberId",
                table: "Recommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Member_ChurchId",
                table: "Recommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Member_MemberId1",
                table: "Recommendation");

            migrationBuilder.DropIndex(
                name: "IX_Recommendation_ChurchId",
                table: "Recommendation");

            migrationBuilder.DropIndex(
                name: "IX_Recommendation_ChurchId1",
                table: "Recommendation");

            migrationBuilder.DropIndex(
                name: "IX_Recommendation_MemberId",
                table: "Recommendation");

            migrationBuilder.DropColumn(
                name: "ChurchId",
                table: "Recommendation");

            migrationBuilder.DropColumn(
                name: "ChurchId1",
                table: "Recommendation");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Recommendation");

            migrationBuilder.RenameColumn(
                name: "MemberId1",
                table: "Recommendation",
                newName: "RecomendationId");

            migrationBuilder.RenameIndex(
                name: "IX_Recommendation_MemberId1",
                table: "Recommendation",
                newName: "IX_Recommendation_RecomendationId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Church_RecomendationId",
                table: "Recommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendation_Member_RecomendationId",
                table: "Recommendation");

            migrationBuilder.RenameColumn(
                name: "RecomendationId",
                table: "Recommendation",
                newName: "MemberId1");

            migrationBuilder.RenameIndex(
                name: "IX_Recommendation_RecomendationId",
                table: "Recommendation",
                newName: "IX_Recommendation_MemberId1");

            migrationBuilder.AddColumn<Guid>(
                name: "ChurchId",
                table: "Recommendation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ChurchId1",
                table: "Recommendation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MemberId",
                table: "Recommendation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Church_ChurchId1",
                table: "Recommendation",
                column: "ChurchId1",
                principalTable: "Church",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Church_MemberId",
                table: "Recommendation",
                column: "MemberId",
                principalTable: "Church",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Member_ChurchId",
                table: "Recommendation",
                column: "ChurchId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendation_Member_MemberId1",
                table: "Recommendation",
                column: "MemberId1",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
