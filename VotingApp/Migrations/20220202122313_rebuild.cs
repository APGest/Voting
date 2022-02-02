using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingApp.Migrations
{
    public partial class rebuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VoterCandidates");

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Voters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "Voters",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voters_CandidateId",
                table: "Voters",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_Candidates_CandidateId",
                table: "Voters",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voters_Candidates_CandidateId",
                table: "Voters");

            migrationBuilder.DropIndex(
                name: "IX_Voters_CandidateId",
                table: "Voters");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Voters");

            migrationBuilder.CreateTable(
                name: "VoterCandidates",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    VoterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoterCandidates", x => new { x.CandidateId, x.VoterId });
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "PiotrusPan" },
                    { 2, "Pumba" }
                });

            migrationBuilder.InsertData(
                table: "VoterCandidates",
                columns: new[] { "CandidateId", "VoterId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Voters",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Andrzej" },
                    { 2, "Jurek" }
                });
        }
    }
}
