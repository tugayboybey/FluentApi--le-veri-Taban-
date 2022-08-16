﻿// <auto-generated />
using CodeFirstileCoreVeriTabanıOlusturma.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstileCoreVeriTabanıOlusturma.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220816095754_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeFirstileCoreVeriTabanıOlusturma.Model.Kitap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BasımYılı")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("YazarID");

                    b.ToTable("Kitaplar", (string)null);
                });

            modelBuilder.Entity("CodeFirstileCoreVeriTabanıOlusturma.Model.Tur", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Türü")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Tür", (string)null);
                });

            modelBuilder.Entity("CodeFirstileCoreVeriTabanıOlusturma.Model.Yazar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("DetayID")
                        .HasColumnType("int");

                    b.Property<string>("DogumTarihi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("DetayID")
                        .IsUnique();

                    b.ToTable("Yazarlar", (string)null);
                });

            modelBuilder.Entity("CodeFirstileCoreVeriTabanıOlusturma.Model.YazarDetay", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.Property<string>("Yazarİli")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("YazarDetays");
                });

            modelBuilder.Entity("KitapTur", b =>
                {
                    b.Property<int>("KitapTurleriID")
                        .HasColumnType("int");

                    b.Property<int>("TurID")
                        .HasColumnType("int");

                    b.HasKey("KitapTurleriID", "TurID");

                    b.HasIndex("TurID");

                    b.ToTable("KitapTur");
                });

            modelBuilder.Entity("CodeFirstileCoreVeriTabanıOlusturma.Model.Kitap", b =>
                {
                    b.HasOne("CodeFirstileCoreVeriTabanıOlusturma.Model.Yazar", "Yazar")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("CodeFirstileCoreVeriTabanıOlusturma.Model.Yazar", b =>
                {
                    b.HasOne("CodeFirstileCoreVeriTabanıOlusturma.Model.YazarDetay", "YazarDetay")
                        .WithOne("Yazar")
                        .HasForeignKey("CodeFirstileCoreVeriTabanıOlusturma.Model.Yazar", "DetayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YazarDetay");
                });

            modelBuilder.Entity("KitapTur", b =>
                {
                    b.HasOne("CodeFirstileCoreVeriTabanıOlusturma.Model.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitapTurleriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstileCoreVeriTabanıOlusturma.Model.Tur", null)
                        .WithMany()
                        .HasForeignKey("TurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirstileCoreVeriTabanıOlusturma.Model.Yazar", b =>
                {
                    b.Navigation("Kitaplar");
                });

            modelBuilder.Entity("CodeFirstileCoreVeriTabanıOlusturma.Model.YazarDetay", b =>
                {
                    b.Navigation("Yazar")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
