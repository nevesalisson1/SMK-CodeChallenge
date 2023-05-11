﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMK.Infrastructure.Context;

#nullable disable

namespace SMK.Infrastructure.Migrations
{
    [DbContext(typeof(CargueiroContext))]
    [Migration("20230511021956_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("SMK.Infrastructure.Entities.Cargueiro", b =>
                {
                    b.Property<int>("CargueiroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Espaco")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CargueiroId");

                    b.ToTable("Cargueiros");
                });

            modelBuilder.Entity("SMK.Infrastructure.Entities.Minerio", b =>
                {
                    b.Property<int>("MinerioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PrecoPorKg")
                        .HasColumnType("REAL");

                    b.HasKey("MinerioId");

                    b.ToTable("Minerios");
                });

            modelBuilder.Entity("SMK.Infrastructure.Entities.MinerioCargueiro", b =>
                {
                    b.Property<int>("MinerioId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CargueiroId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MinerioId", "CargueiroId");

                    b.HasIndex("CargueiroId");

                    b.ToTable("MinerioCargueiro");
                });

            modelBuilder.Entity("SMK.Infrastructure.Entities.MinerioCargueiro", b =>
                {
                    b.HasOne("SMK.Infrastructure.Entities.Cargueiro", "Cargueiro")
                        .WithMany("MinerioCargueiros")
                        .HasForeignKey("CargueiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMK.Infrastructure.Entities.Minerio", "Minerio")
                        .WithMany("MinerioCargueiros")
                        .HasForeignKey("MinerioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargueiro");

                    b.Navigation("Minerio");
                });

            modelBuilder.Entity("SMK.Infrastructure.Entities.Cargueiro", b =>
                {
                    b.Navigation("MinerioCargueiros");
                });

            modelBuilder.Entity("SMK.Infrastructure.Entities.Minerio", b =>
                {
                    b.Navigation("MinerioCargueiros");
                });
#pragma warning restore 612, 618
        }
    }
}
