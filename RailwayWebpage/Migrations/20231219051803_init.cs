using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RailwayWebpage.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "froms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_froms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "passengerdetailes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phoneno = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Berth = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    CardNumber = table.Column<long>(type: "bigint", nullable: false),
                    CardName = table.Column<string>(type: "text", nullable: true),
                    CMonth = table.Column<int>(type: "integer", nullable: false),
                    CYear = table.Column<int>(type: "integer", nullable: false),
                    Cvno = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passengerdetailes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "registerPages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registerPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FromId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tos_froms_FromId",
                        column: x => x.FromId,
                        principalTable: "froms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "loginPages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    RegisterPageId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loginPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_loginPages_registerPages_RegisterPageId",
                        column: x => x.RegisterPageId,
                        principalTable: "registerPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trainnames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ToId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainnames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainnames_tos_ToId",
                        column: x => x.ToId,
                        principalTable: "tos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tprices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<float>(type: "real", nullable: false),
                    TrainNameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tprices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tprices_trainnames_TrainNameId",
                        column: x => x.TrainNameId,
                        principalTable: "trainnames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_loginPages_RegisterPageId",
                table: "loginPages",
                column: "RegisterPageId");

            migrationBuilder.CreateIndex(
                name: "IX_tos_FromId",
                table: "tos",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_tprices_TrainNameId",
                table: "tprices",
                column: "TrainNameId");

            migrationBuilder.CreateIndex(
                name: "IX_trainnames_ToId",
                table: "trainnames",
                column: "ToId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "loginPages");

            migrationBuilder.DropTable(
                name: "passengerdetailes");

            migrationBuilder.DropTable(
                name: "tprices");

            migrationBuilder.DropTable(
                name: "registerPages");

            migrationBuilder.DropTable(
                name: "trainnames");

            migrationBuilder.DropTable(
                name: "tos");

            migrationBuilder.DropTable(
                name: "froms");
        }
    }
}
