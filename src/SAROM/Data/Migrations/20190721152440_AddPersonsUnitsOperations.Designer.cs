﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Olo42.SAROM.WebApp.Models;

namespace Olo42.SAROM.WebApp.Data.Migrations
{
    [DbContext(typeof(OperationContext))]
    [Migration("20190721152440_AddPersonsUnitsOperations")]
    partial class AddPersonsUnitsOperations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SAROM.Models.Operation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClosingReport");

                    b.Property<bool>("IsClosed");

                    b.HasKey("Id");

                    b.ToTable("Operation");
                });

            modelBuilder.Entity("SAROM.Models.OperationAction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<string>("OperationId");

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.ToTable("OperationAction");
                });

            modelBuilder.Entity("SAROM.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Dog");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.Property<string>("UnitId");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("SAROM.Models.Unit", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GroupLeader");

                    b.Property<string>("Name");

                    b.Property<string>("OperationId");

                    b.Property<string>("PagerNumber");

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("SAROM.Models.OperationAction", b =>
                {
                    b.HasOne("SAROM.Models.Operation")
                        .WithMany("OperationActions")
                        .HasForeignKey("OperationId");
                });

            modelBuilder.Entity("SAROM.Models.Person", b =>
                {
                    b.HasOne("SAROM.Models.Unit")
                        .WithMany("People")
                        .HasForeignKey("UnitId");
                });

            modelBuilder.Entity("SAROM.Models.Unit", b =>
                {
                    b.HasOne("SAROM.Models.Operation")
                        .WithMany("Units")
                        .HasForeignKey("OperationId");
                });
#pragma warning restore 612, 618
        }
    }
}
