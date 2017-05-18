using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bravo.Models.DatabaseEntities;
using Bravo.Models.DatabaseEntities.Relation;
using Bravo.Models;

namespace Bravo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Hersteller> Hersteller { get; set; }
        public DbSet<Lieferant> Lieferant { get; set; }
        public DbSet<Software> Software { get; set; }
        public DbSet<Geraetekomponente> Geraetekomponente { get; set; }
        public DbSet<Geraeteart> Geraeteart { get; set; }
        public DbSet<Geraet> Geraet { get; set; }
        public DbSet<Rechtevorlage> Rechtevorlage { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Rechtegruppe> Rechtegruppe { get; set; }
        public DbSet<WebBenutzer> WebBenutzer { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //RoomToolRelation Beziehung
            builder.Entity<RoomToolRelation>().HasKey(x => new { x.RoomId, x.ToolId });

            builder.Entity<RoomToolRelation>()
                .HasOne(bc => bc.Room)
                .WithMany(b => b.RoomToolRelations)
                .HasForeignKey(bc => bc.RoomId);

            builder.Entity<RoomToolRelation>()
                .HasOne(bc => bc.Tool)
                .WithMany(c => c.RoomToolRelations)
                .HasForeignKey(bc => bc.ToolId);

            //Software_in_Raum Beziehung
            builder.Entity<Software_in_Raum>().HasKey(x => new { x.RaumID, x.SoftwareID });

            builder.Entity<Software_in_Raum>()
                .HasOne(bc => bc.Software)
                .WithMany(b => b.Software_in_Raum)
                .HasForeignKey(bc => bc.SoftwareID);

            builder.Entity<Software_in_Raum>()
                .HasOne(bc => bc.Room)
                .WithMany(c => c.Software_in_Raum)
                .HasForeignKey(bc => bc.RaumID);

            //Geraeteart_Komponenten_Vorgabe Beziehung
            builder.Entity<Geraeteart_Komponenten_Vorgabe>().HasKey(x => new { x.GeraeteartID, x.GeraeteartkomponenteID });

            builder.Entity<Geraeteart_Komponenten_Vorgabe>()
                .HasOne(bc => bc.Geraeteart)
                .WithMany(b => b.Geraeteart_Komponenten_Vorgabe)
                .HasForeignKey(bc => bc.GeraeteartID);

            builder.Entity<Geraeteart_Komponenten_Vorgabe>()
                .HasOne(bc => bc.Geraetekomponente)
                .WithMany(c => c.Geraeteart_Komponenten_Vorgabe)
                .HasForeignKey(bc => bc.GeraeteartkomponenteID);

            //Geraetekomponente_Information Beziehung
            builder.Entity<Geraetekomponente_Information>().HasKey(x => new { x.GeraetID, x.AttributID });

            builder.Entity<Geraetekomponente_Information>()
                .HasOne(bc => bc.Geraetekomponente)
                .WithMany(b => b.Geraetekomponente_Information)
                .HasForeignKey(bc => bc.AttributID);

            builder.Entity<Geraetekomponente_Information>()
                .HasOne(bc => bc.Geraet)
                .WithMany(c => c.Geraetekomponente_Information)
                .HasForeignKey(bc => bc.GeraetID);
        }
    }
}
