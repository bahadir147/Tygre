﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tygre.OM.Repositories.Concrete.EntityFramework;

namespace Tygre.OM.Repositories.Migrations
{
    [DbContext(typeof(OMContext))]
    partial class OMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.Birim", b =>
                {
                    b.Property<int>("BirimId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirimAdi");

                    b.HasKey("BirimId");

                    b.ToTable("Birimler");
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAdi");

                    b.Property<int>("Status");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.Musteri", b =>
                {
                    b.Property<int>("MusteriId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres");

                    b.Property<string>("Bolge");

                    b.Property<string>("Faks");

                    b.Property<string>("MusteriAdi");

                    b.Property<string>("MusteriUnvani");

                    b.Property<string>("PostaKodu");

                    b.Property<string>("Sehir");

                    b.Property<string>("SirketAdi");

                    b.Property<string>("Telefon");

                    b.Property<string>("Ulke");

                    b.Property<string>("UlkeKodu");

                    b.HasKey("MusteriId");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi");

                    b.Property<string>("Adres");

                    b.Property<string>("Bolge");

                    b.Property<int>("Cinsiyet");

                    b.Property<DateTime>("DogumTarihi");

                    b.Property<DateTime>("IseBaslamaTarihi");

                    b.Property<string>("Sehir");

                    b.Property<string>("Sifre");

                    b.Property<string>("SoyAdi");

                    b.Property<int>("Status");

                    b.Property<string>("TelefonNumarasi");

                    b.Property<string>("Ulke");

                    b.Property<string>("Unvan");

                    b.Property<string>("UnvanEki");

                    b.HasKey("PersonelId");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.PersonelYetki", b =>
                {
                    b.Property<int>("PerosnelYetkiId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonelId");

                    b.Property<int>("YetkiId");

                    b.HasKey("PerosnelYetkiId");

                    b.HasIndex("PersonelId");

                    b.HasIndex("YetkiId");

                    b.ToTable("PersonelYetkileri");
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.Siparis", b =>
                {
                    b.Property<int>("SiparisId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MusteriId");

                    b.Property<DateTime>("OdemeTarihi");

                    b.Property<int>("PersonelId");

                    b.Property<DateTime>("SevkTarihi");

                    b.Property<DateTime>("SiparisTarihi");

                    b.HasKey("SiparisId");

                    b.HasIndex("MusteriId");

                    b.HasIndex("PersonelId");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.SiparisDetay", b =>
                {
                    b.Property<int>("SiparisId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BirimFiyati");

                    b.Property<decimal>("Indirim");

                    b.Property<decimal>("Miktar");

                    b.Property<int?>("SiparisId1");

                    b.Property<int>("UrunId");

                    b.HasKey("SiparisId");

                    b.HasIndex("SiparisId1");

                    b.HasIndex("UrunId");

                    b.ToTable("SiparisDetaylari");
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.Tedarikci", b =>
                {
                    b.Property<int>("TedarikciId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres");

                    b.Property<string>("Region");

                    b.Property<string>("Sehir");

                    b.Property<string>("SirketAdi");

                    b.Property<string>("TelNo");

                    b.Property<string>("Ulke");

                    b.HasKey("TedarikciId");

                    b.ToTable("Tedarikciler");
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.Urun", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BirimFiyati");

                    b.Property<int>("BirimId");

                    b.Property<int>("KategoriId");

                    b.Property<int>("TedarikciId");

                    b.Property<string>("UrunAdi");

                    b.Property<byte[]>("UrunResmi")
                        .HasColumnType("image");

                    b.HasKey("UrunId");

                    b.HasIndex("BirimId");

                    b.HasIndex("KategoriId");

                    b.HasIndex("TedarikciId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.Yetki", b =>
                {
                    b.Property<int>("YetkiId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama");

                    b.Property<string>("Action");

                    b.Property<string>("Adi");

                    b.Property<string>("Controller");

                    b.Property<string>("Icon");

                    b.Property<string>("Yol");

                    b.HasKey("YetkiId");

                    b.ToTable("Yetkiler");
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.PersonelYetki", b =>
                {
                    b.HasOne("Tygre.OM.Entities.Concrete.Personel", "Personel")
                        .WithMany("PersonelYetkileri")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tygre.OM.Entities.Concrete.Yetki", "Yetki")
                        .WithMany("PersonelYetkiler")
                        .HasForeignKey("YetkiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.Siparis", b =>
                {
                    b.HasOne("Tygre.OM.Entities.Concrete.Musteri", "Musteri")
                        .WithMany("Siparisler")
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tygre.OM.Entities.Concrete.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.SiparisDetay", b =>
                {
                    b.HasOne("Tygre.OM.Entities.Concrete.Siparis", "Siparis")
                        .WithMany()
                        .HasForeignKey("SiparisId1");

                    b.HasOne("Tygre.OM.Entities.Concrete.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tygre.OM.Entities.Concrete.Urun", b =>
                {
                    b.HasOne("Tygre.OM.Entities.Concrete.Birim", "Birim")
                        .WithMany("Urunler")
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tygre.OM.Entities.Concrete.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tygre.OM.Entities.Concrete.Tedarikci", "Supplier")
                        .WithMany("Urunler")
                        .HasForeignKey("TedarikciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
