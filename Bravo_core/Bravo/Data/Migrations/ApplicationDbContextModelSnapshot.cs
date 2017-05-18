using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Bravo.Data;

namespace Bravo.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Geraet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bezeichnung");

                    b.Property<byte[]>("Einkaufsbeleg");

                    b.Property<DateTime>("Einkaufsdatum");

                    b.Property<long?>("GeraeteartId");

                    b.Property<int>("Gewaehrleistung_Monate");

                    b.Property<long?>("HerstellerId");

                    b.Property<long?>("LieferantId");

                    b.Property<string>("Notiz");

                    b.Property<long?>("RoomId");

                    b.HasKey("Id");

                    b.HasIndex("GeraeteartId");

                    b.HasIndex("HerstellerId");

                    b.HasIndex("LieferantId");

                    b.HasIndex("RoomId");

                    b.ToTable("Geraet");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Geraeteart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bezeichnung");

                    b.HasKey("Id");

                    b.ToTable("Geraeteart");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Geraetekomponente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bezeichnung");

                    b.HasKey("Id");

                    b.ToTable("Geraetekomponente");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Hersteller", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bezeichnung");

                    b.HasKey("Id");

                    b.ToTable("Hersteller");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Rechtegruppe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Ausstattung_VorlageID");

                    b.Property<bool>("Benutzerverwaltung_Vollzugriff");

                    b.Property<string>("Bezeichnung");

                    b.Property<long>("Tickets_VorlageID");

                    b.HasKey("Id");

                    b.ToTable("Rechtegruppe");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Rechtevorlage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bearbeiten");

                    b.Property<string>("Bezeichnung");

                    b.Property<bool>("Entfernen");

                    b.Property<bool>("Erstellen");

                    b.Property<bool>("Lesen");

                    b.HasKey("Id");

                    b.ToTable("Rechtevorlage");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Relation.Geraeteart_Komponenten_Vorgabe", b =>
                {
                    b.Property<long>("GeraeteartID");

                    b.Property<long>("GeraeteartkomponenteID");

                    b.HasKey("GeraeteartID", "GeraeteartkomponenteID");

                    b.HasIndex("GeraeteartkomponenteID");

                    b.ToTable("Geraeteart_Komponenten_Vorgabe");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Relation.Geraetekomponente_Information", b =>
                {
                    b.Property<long>("GeraetID");

                    b.Property<long>("AttributID");

                    b.Property<string>("Bezeichnung");

                    b.HasKey("GeraetID", "AttributID");

                    b.HasIndex("AttributID");

                    b.ToTable("Geraetekomponente_Information");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Relation.RoomToolRelation", b =>
                {
                    b.Property<long>("RoomId");

                    b.Property<long>("ToolId");

                    b.Property<long?>("HerstellerId");

                    b.HasKey("RoomId", "ToolId");

                    b.HasIndex("HerstellerId");

                    b.HasIndex("ToolId");

                    b.ToTable("RoomToolRelation");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Relation.Software_in_Raum", b =>
                {
                    b.Property<long>("RaumID");

                    b.Property<long>("SoftwareID");

                    b.HasKey("RaumID", "SoftwareID");

                    b.HasIndex("SoftwareID");

                    b.ToTable("Software_in_Raum");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Notiz");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Software", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bezeichnung");

                    b.Property<byte[]>("Einkaufsbeleg");

                    b.Property<DateTime>("Einkaufsdatum");

                    b.Property<long?>("HerstellerId");

                    b.Property<long?>("LieferantId");

                    b.Property<int>("Lizenz_Benutzerumfang");

                    b.Property<string>("Notiz");

                    b.Property<string>("Version");

                    b.Property<string>("lizenz_Schlüssel");

                    b.HasKey("Id");

                    b.HasIndex("HerstellerId");

                    b.HasIndex("LieferantId");

                    b.ToTable("Software");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Ticket", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AbgeschlossenDatum");

                    b.Property<string>("Bearbeiter");

                    b.Property<string>("Bezeichnung");

                    b.Property<DateTime>("DatumEingang");

                    b.Property<string>("Ersteller");

                    b.Property<string>("Notiz");

                    b.HasKey("Id");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Tool", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.WebBenutzer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Anrede");

                    b.Property<string>("EMail");

                    b.Property<DateTime>("Erstellungsdatum");

                    b.Property<DateTime>("Geburtsdatum");

                    b.Property<string>("Name");

                    b.Property<string>("Nutzername");

                    b.Property<string>("Passwort");

                    b.Property<long>("Rechtegruppe_ID");

                    b.Property<string>("Titel");

                    b.HasKey("Id");

                    b.ToTable("WebBenutzer");
                });

            modelBuilder.Entity("Bravo.Models.Lieferant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EMail");

                    b.Property<string>("Fax");

                    b.Property<string>("Mobil");

                    b.Property<string>("Name");

                    b.Property<string>("Ort");

                    b.Property<string>("Plz");

                    b.Property<string>("Strasse");

                    b.Property<string>("Telefon");

                    b.HasKey("Id");

                    b.ToTable("Lieferant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Geraet", b =>
                {
                    b.HasOne("Bravo.Models.DatabaseEntities.Geraeteart")
                        .WithMany("Geraete")
                        .HasForeignKey("GeraeteartId");

                    b.HasOne("Bravo.Models.DatabaseEntities.Hersteller")
                        .WithMany("Geraete")
                        .HasForeignKey("HerstellerId");

                    b.HasOne("Bravo.Models.Lieferant")
                        .WithMany("Geraete")
                        .HasForeignKey("LieferantId");

                    b.HasOne("Bravo.Models.DatabaseEntities.Room")
                        .WithMany("Geraete")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Relation.Geraeteart_Komponenten_Vorgabe", b =>
                {
                    b.HasOne("Bravo.Models.DatabaseEntities.Geraeteart", "Geraeteart")
                        .WithMany("Geraeteart_Komponenten_Vorgabe")
                        .HasForeignKey("GeraeteartID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bravo.Models.DatabaseEntities.Geraetekomponente", "Geraetekomponente")
                        .WithMany("Geraeteart_Komponenten_Vorgabe")
                        .HasForeignKey("GeraeteartkomponenteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Relation.Geraetekomponente_Information", b =>
                {
                    b.HasOne("Bravo.Models.DatabaseEntities.Geraetekomponente", "Geraetekomponente")
                        .WithMany("Geraetekomponente_Information")
                        .HasForeignKey("AttributID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bravo.Models.DatabaseEntities.Geraet", "Geraet")
                        .WithMany("Geraetekomponente_Information")
                        .HasForeignKey("GeraetID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Relation.RoomToolRelation", b =>
                {
                    b.HasOne("Bravo.Models.DatabaseEntities.Hersteller")
                        .WithMany("RoomToolRelations")
                        .HasForeignKey("HerstellerId");

                    b.HasOne("Bravo.Models.DatabaseEntities.Room", "Room")
                        .WithMany("RoomToolRelations")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bravo.Models.DatabaseEntities.Tool", "Tool")
                        .WithMany("RoomToolRelations")
                        .HasForeignKey("ToolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Relation.Software_in_Raum", b =>
                {
                    b.HasOne("Bravo.Models.DatabaseEntities.Room", "Room")
                        .WithMany("Software_in_Raum")
                        .HasForeignKey("RaumID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bravo.Models.DatabaseEntities.Software", "Software")
                        .WithMany("Software_in_Raum")
                        .HasForeignKey("SoftwareID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bravo.Models.DatabaseEntities.Software", b =>
                {
                    b.HasOne("Bravo.Models.DatabaseEntities.Hersteller")
                        .WithMany("Softwares")
                        .HasForeignKey("HerstellerId");

                    b.HasOne("Bravo.Models.Lieferant")
                        .WithMany("Softwares")
                        .HasForeignKey("LieferantId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Bravo.Models.DatabaseEntities.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Bravo.Models.DatabaseEntities.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bravo.Models.DatabaseEntities.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
