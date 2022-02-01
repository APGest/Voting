using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingApp.Migrations
{
    public partial class createVoterCandidatetable11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VoterCandidates",
                columns: table => new
                {
                    VoterId = table.Column<int>(nullable: false),
                    CandidateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoterCandidates", x => new { x.CandidateId, x.VoterId });
                });

            migrationBuilder.CreateTable(
                name: "Voters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "VoterCandidates",
                columns: new[] { "CandidateId", "VoterId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Voters",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Jurek" });

            migrationBuilder.InsertData(
                table: "Voters",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Andrzej" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VoterCandidates");

            migrationBuilder.DropTable(
                name: "Voters");
        }
    }
}
