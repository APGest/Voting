using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingApp.Migrations
{
    public partial class updateCandidateVote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VoterCandidates",
                columns: new[] { "CandidateId", "VoterId" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VoterCandidates",
                keyColumns: new[] { "CandidateId", "VoterId" },
                keyValues: new object[] { 2, 1 });
        }
    }
}
