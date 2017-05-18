using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bravo.Data.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Geraeteart",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bezeichnung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geraeteart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Geraetekomponente",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bezeichnung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geraetekomponente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hersteller",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bezeichnung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hersteller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rechtegruppe",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ausstattung_VorlageID = table.Column<long>(nullable: false),
                    Benutzerverwaltung_Vollzugriff = table.Column<bool>(nullable: false),
                    Bezeichnung = table.Column<string>(nullable: true),
                    Tickets_VorlageID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rechtegruppe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rechtevorlage",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bearbeiten = table.Column<bool>(nullable: false),
                    Bezeichnung = table.Column<string>(nullable: true),
                    Entfernen = table.Column<bool>(nullable: false),
                    Erstellen = table.Column<bool>(nullable: false),
                    Lesen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rechtevorlage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Notiz = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AbgeschlossenDatum = table.Column<DateTime>(nullable: false),
                    Bearbeiter = table.Column<string>(nullable: true),
                    Bezeichnung = table.Column<string>(nullable: true),
                    DatumEingang = table.Column<DateTime>(nullable: false),
                    Ersteller = table.Column<string>(nullable: true),
                    Notiz = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebBenutzer",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Anrede = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    Erstellungsdatum = table.Column<DateTime>(nullable: false),
                    Geburtsdatum = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Nutzername = table.Column<string>(nullable: true),
                    Passwort = table.Column<string>(nullable: true),
                    Rechtegruppe_ID = table.Column<long>(nullable: false),
                    Titel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebBenutzer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lieferant",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EMail = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Mobil = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ort = table.Column<string>(nullable: true),
                    Plz = table.Column<string>(nullable: true),
                    Strasse = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lieferant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Geraeteart_Komponenten_Vorgabe",
                columns: table => new
                {
                    GeraeteartID = table.Column<long>(nullable: false),
                    GeraeteartkomponenteID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geraeteart_Komponenten_Vorgabe", x => new { x.GeraeteartID, x.GeraeteartkomponenteID });
                    table.ForeignKey(
                        name: "FK_Geraeteart_Komponenten_Vorgabe_Geraeteart_GeraeteartID",
                        column: x => x.GeraeteartID,
                        principalTable: "Geraeteart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Geraeteart_Komponenten_Vorgabe_Geraetekomponente_GeraeteartkomponenteID",
                        column: x => x.GeraeteartkomponenteID,
                        principalTable: "Geraetekomponente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomToolRelation",
                columns: table => new
                {
                    RoomId = table.Column<long>(nullable: false),
                    ToolId = table.Column<long>(nullable: false),
                    HerstellerId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomToolRelation", x => new { x.RoomId, x.ToolId });
                    table.ForeignKey(
                        name: "FK_RoomToolRelation_Hersteller_HerstellerId",
                        column: x => x.HerstellerId,
                        principalTable: "Hersteller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomToolRelation_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomToolRelation_Tools_ToolId",
                        column: x => x.ToolId,
                        principalTable: "Tools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Geraet",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bezeichnung = table.Column<string>(nullable: true),
                    Einkaufsbeleg = table.Column<byte[]>(nullable: true),
                    Einkaufsdatum = table.Column<DateTime>(nullable: false),
                    GeraeteartId = table.Column<long>(nullable: true),
                    Gewaehrleistung_Monate = table.Column<int>(nullable: false),
                    HerstellerId = table.Column<long>(nullable: true),
                    LieferantId = table.Column<long>(nullable: true),
                    Notiz = table.Column<string>(nullable: true),
                    RoomId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geraet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Geraet_Geraeteart_GeraeteartId",
                        column: x => x.GeraeteartId,
                        principalTable: "Geraeteart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Geraet_Hersteller_HerstellerId",
                        column: x => x.HerstellerId,
                        principalTable: "Hersteller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Geraet_Lieferant_LieferantId",
                        column: x => x.LieferantId,
                        principalTable: "Lieferant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Geraet_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bezeichnung = table.Column<string>(nullable: true),
                    Einkaufsbeleg = table.Column<byte[]>(nullable: true),
                    Einkaufsdatum = table.Column<DateTime>(nullable: false),
                    HerstellerId = table.Column<long>(nullable: true),
                    LieferantId = table.Column<long>(nullable: true),
                    Lizenz_Benutzerumfang = table.Column<int>(nullable: false),
                    Notiz = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    lizenz_Schlüssel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Software_Hersteller_HerstellerId",
                        column: x => x.HerstellerId,
                        principalTable: "Hersteller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Software_Lieferant_LieferantId",
                        column: x => x.LieferantId,
                        principalTable: "Lieferant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Geraetekomponente_Information",
                columns: table => new
                {
                    GeraetID = table.Column<long>(nullable: false),
                    AttributID = table.Column<long>(nullable: false),
                    Bezeichnung = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geraetekomponente_Information", x => new { x.GeraetID, x.AttributID });
                    table.ForeignKey(
                        name: "FK_Geraetekomponente_Information_Geraetekomponente_AttributID",
                        column: x => x.AttributID,
                        principalTable: "Geraetekomponente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Geraetekomponente_Information_Geraet_GeraetID",
                        column: x => x.GeraetID,
                        principalTable: "Geraet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Software_in_Raum",
                columns: table => new
                {
                    RaumID = table.Column<long>(nullable: false),
                    SoftwareID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software_in_Raum", x => new { x.RaumID, x.SoftwareID });
                    table.ForeignKey(
                        name: "FK_Software_in_Raum_Rooms_RaumID",
                        column: x => x.RaumID,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Software_in_Raum_Software_SoftwareID",
                        column: x => x.SoftwareID,
                        principalTable: "Software",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Geraet_GeraeteartId",
                table: "Geraet",
                column: "GeraeteartId");

            migrationBuilder.CreateIndex(
                name: "IX_Geraet_HerstellerId",
                table: "Geraet",
                column: "HerstellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Geraet_LieferantId",
                table: "Geraet",
                column: "LieferantId");

            migrationBuilder.CreateIndex(
                name: "IX_Geraet_RoomId",
                table: "Geraet",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Geraeteart_Komponenten_Vorgabe_GeraeteartkomponenteID",
                table: "Geraeteart_Komponenten_Vorgabe",
                column: "GeraeteartkomponenteID");

            migrationBuilder.CreateIndex(
                name: "IX_Geraetekomponente_Information_AttributID",
                table: "Geraetekomponente_Information",
                column: "AttributID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomToolRelation_HerstellerId",
                table: "RoomToolRelation",
                column: "HerstellerId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomToolRelation_ToolId",
                table: "RoomToolRelation",
                column: "ToolId");

            migrationBuilder.CreateIndex(
                name: "IX_Software_in_Raum_SoftwareID",
                table: "Software_in_Raum",
                column: "SoftwareID");

            migrationBuilder.CreateIndex(
                name: "IX_Software_HerstellerId",
                table: "Software",
                column: "HerstellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Software_LieferantId",
                table: "Software",
                column: "LieferantId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rechtegruppe");

            migrationBuilder.DropTable(
                name: "Rechtevorlage");

            migrationBuilder.DropTable(
                name: "Geraeteart_Komponenten_Vorgabe");

            migrationBuilder.DropTable(
                name: "Geraetekomponente_Information");

            migrationBuilder.DropTable(
                name: "RoomToolRelation");

            migrationBuilder.DropTable(
                name: "Software_in_Raum");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "WebBenutzer");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Geraetekomponente");

            migrationBuilder.DropTable(
                name: "Geraet");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "Software");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Geraeteart");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hersteller");

            migrationBuilder.DropTable(
                name: "Lieferant");
        }
    }
}
