using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisSystem.Infrastructure.Persistence.Migrations
{
    public partial class InitialDomainTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Characteristics_Age = table.Column<int>(type: "int", nullable: false),
                    Characteristics_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Characteristics_Weight = table.Column<double>(type: "float", nullable: false),
                    Characteristics_Height = table.Column<double>(type: "float", nullable: false),
                    Characteristics_Play_Forehand_Value = table.Column<int>(type: "int", nullable: false),
                    Characteristics_Play_Backhand_Value = table.Column<int>(type: "int", nullable: false),
                    Stats_Win = table.Column<int>(type: "int", nullable: false),
                    Stats_Loss = table.Column<int>(type: "int", nullable: false),
                    Stats_Rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Prize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Location_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TournamentType_TournamentPoints_Value = table.Column<int>(type: "int", nullable: false),
                    TournamentType_Surface_Value = table.Column<int>(type: "int", nullable: false),
                    TournamentType_Event_Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: false),
                    Characteristics_Age = table.Column<int>(type: "int", nullable: false),
                    Characteristics_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Characteristics_Weight = table.Column<double>(type: "float", nullable: false),
                    Characteristics_Height = table.Column<double>(type: "float", nullable: false),
                    Characteristics_Play_Forehand_Value = table.Column<int>(type: "int", nullable: false),
                    Characteristics_Play_Backhand_Value = table.Column<int>(type: "int", nullable: false),
                    Stats_Win = table.Column<int>(type: "int", nullable: false),
                    Stats_Loss = table.Column<int>(type: "int", nullable: false),
                    Stats_Rank = table.Column<int>(type: "int", nullable: false),
                    Stats_Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Participators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Aces = table.Column<int>(type: "int", nullable: false),
                    DoubleFaults = table.Column<int>(type: "int", nullable: false),
                    BreakPoints = table.Column<int>(type: "int", nullable: false),
                    StatisticId = table.Column<int>(type: "int", nullable: true),
                    StatisticId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participators_Statistics_StatisticId",
                        column: x => x.StatisticId,
                        principalTable: "Statistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participators_Statistics_StatisticId1",
                        column: x => x.StatisticId1,
                        principalTable: "Statistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstPlayerId = table.Column<int>(type: "int", nullable: true),
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    TournamentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Participants_FirstPlayerId",
                        column: x => x.FirstPlayerId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Prize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompetitionType_CompetitionPoints_Value = table.Column<int>(type: "int", nullable: false),
                    CompetitionType_Surface_Value = table.Column<int>(type: "int", nullable: false),
                    CompetitionType_Event_Value = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competitions_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    StatsPlayerId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => new { x.StatsPlayerId, x.Id });
                    table.ForeignKey(
                        name: "FK_Title_Players_StatsPlayerId",
                        column: x => x.StatsPlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstParticipantPoints = table.Column<int>(type: "int", nullable: false),
                    SecondParticipantPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => new { x.MatchId, x.Id });
                    table.ForeignKey(
                        name: "FK_Set_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_PlayerId",
                table: "Competitions",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_FirstPlayerId",
                table: "Matches",
                column: "FirstPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_ParticipantId",
                table: "Matches",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Participators_StatisticId",
                table: "Participators",
                column: "StatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_Participators_StatisticId1",
                table: "Participators",
                column: "StatisticId1");

            migrationBuilder.CreateIndex(
                name: "IX_Players_CoachId",
                table: "Players",
                column: "CoachId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Participators");

            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "Coaches");
        }
    }
}
