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
                    FId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_froms", x => x.FId);
                });

            migrationBuilder.CreateTable(
                name: "passengerdetailes",
                columns: table => new
                {
                    PId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phoneno = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Berth = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    CardNumber = table.Column<long>(type: "bigint", nullable: false),
                    CardName = table.Column<string>(type: "text", nullable: false),
                    CMonth = table.Column<int>(type: "integer", nullable: false),
                    CYear = table.Column<int>(type: "integer", nullable: false),
                    Cvno = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passengerdetailes", x => x.PId);
                });

            migrationBuilder.CreateTable(
                name: "RegisterPages",
                columns: table => new
                {
                    RId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterPages", x => x.RId);
                });

            migrationBuilder.CreateTable(
                name: "tos",
                columns: table => new
                {
                    TId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TName = table.Column<string>(type: "text", nullable: false),
                    FromFId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tos", x => x.TId);
                    table.ForeignKey(
                        name: "FK_tos_froms_FromFId",
                        column: x => x.FromFId,
                        principalTable: "froms",
                        principalColumn: "FId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginPages",
                columns: table => new
                {
                    LId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    RegisterPageRId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginPages", x => x.LId);
                    table.ForeignKey(
                        name: "FK_LoginPages_RegisterPages_RegisterPageRId",
                        column: x => x.RegisterPageRId,
                        principalTable: "RegisterPages",
                        principalColumn: "RId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trainnames",
                columns: table => new
                {
                    TNId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TNName = table.Column<string>(type: "text", nullable: false),
                    ToTId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainnames", x => x.TNId);
                    table.ForeignKey(
                        name: "FK_trainnames_tos_ToTId",
                        column: x => x.ToTId,
                        principalTable: "tos",
                        principalColumn: "TId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tclasses",
                columns: table => new
                {
                    CId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CName = table.Column<string>(type: "text", nullable: false),
                    TrainNameTNId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tclasses", x => x.CId);
                    table.ForeignKey(
                        name: "FK_tclasses_trainnames_TrainNameTNId",
                        column: x => x.TrainNameTNId,
                        principalTable: "trainnames",
                        principalColumn: "TNId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tprices",
                columns: table => new
                {
                    PId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<float>(type: "real", nullable: false),
                    TClassCId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tprices", x => x.PId);
                    table.ForeignKey(
                        name: "FK_tprices_tclasses_TClassCId",
                        column: x => x.TClassCId,
                        principalTable: "tclasses",
                        principalColumn: "CId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoginPages_RegisterPageRId",
                table: "LoginPages",
                column: "RegisterPageRId");

            migrationBuilder.CreateIndex(
                name: "IX_tclasses_TrainNameTNId",
                table: "tclasses",
                column: "TrainNameTNId");

            migrationBuilder.CreateIndex(
                name: "IX_tos_FromFId",
                table: "tos",
                column: "FromFId");

            migrationBuilder.CreateIndex(
                name: "IX_tprices_TClassCId",
                table: "tprices",
                column: "TClassCId");

            migrationBuilder.CreateIndex(
                name: "IX_trainnames_ToTId",
                table: "trainnames",
                column: "ToTId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginPages");

            migrationBuilder.DropTable(
                name: "passengerdetailes");

            migrationBuilder.DropTable(
                name: "tprices");

            migrationBuilder.DropTable(
                name: "RegisterPages");

            migrationBuilder.DropTable(
                name: "tclasses");

            migrationBuilder.DropTable(
                name: "trainnames");

            migrationBuilder.DropTable(
                name: "tos");

            migrationBuilder.DropTable(
                name: "froms");
        }
    }
}
