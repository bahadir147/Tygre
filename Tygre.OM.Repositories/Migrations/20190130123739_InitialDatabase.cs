using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tygre.OM.Repositories.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birimler",
                columns: table => new
                {
                    BirimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirimAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birimler", x => x.BirimId);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KategoriAdi = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    MusteriId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SirketAdi = table.Column<string>(nullable: true),
                    MusteriAdi = table.Column<string>(nullable: true),
                    MusteriUnvani = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    Sehir = table.Column<string>(nullable: true),
                    Bolge = table.Column<string>(nullable: true),
                    PostaKodu = table.Column<string>(nullable: true),
                    UlkeKodu = table.Column<string>(nullable: true),
                    Ulke = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Faks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.MusteriId);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    PersonelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SoyAdi = table.Column<string>(nullable: true),
                    Adi = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true),
                    Unvan = table.Column<string>(nullable: true),
                    UnvanEki = table.Column<string>(nullable: true),
                    Cinsiyet = table.Column<int>(nullable: false),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    IseBaslamaTarihi = table.Column<DateTime>(nullable: false),
                    Adres = table.Column<string>(nullable: true),
                    Ulke = table.Column<string>(nullable: true),
                    Sehir = table.Column<string>(nullable: true),
                    TelefonNumarasi = table.Column<string>(nullable: true),
                    Bolge = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.PersonelId);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    TedarikciId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SirketAdi = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    Sehir = table.Column<string>(nullable: true),
                    Ulke = table.Column<string>(nullable: true),
                    TelNo = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.TedarikciId);
                });

            migrationBuilder.CreateTable(
                name: "Yetkiler",
                columns: table => new
                {
                    YetkiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adi = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    Controller = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    Yol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkiler", x => x.YetkiId);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    SiparisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiparisTarihi = table.Column<DateTime>(nullable: false),
                    OdemeTarihi = table.Column<DateTime>(nullable: false),
                    SevkTarihi = table.Column<DateTime>(nullable: false),
                    MusteriId = table.Column<int>(nullable: false),
                    PersonelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.SiparisId);
                    table.ForeignKey(
                        name: "FK_Siparisler_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "MusteriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siparisler_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UrunAdi = table.Column<string>(nullable: true),
                    BirimFiyati = table.Column<decimal>(nullable: false),
                    UrunResmi = table.Column<byte[]>(type: "image", nullable: true),
                    TedarikciId = table.Column<int>(nullable: false),
                    BirimId = table.Column<int>(nullable: false),
                    KategoriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunId);
                    table.ForeignKey(
                        name: "FK_Urunler_Birimler_BirimId",
                        column: x => x.BirimId,
                        principalTable: "Birimler",
                        principalColumn: "BirimId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Urunler_Tedarikciler_TedarikciId",
                        column: x => x.TedarikciId,
                        principalTable: "Tedarikciler",
                        principalColumn: "TedarikciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelYetkileri",
                columns: table => new
                {
                    PerosnelYetkiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonelId = table.Column<int>(nullable: false),
                    YetkiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelYetkileri", x => x.PerosnelYetkiId);
                    table.ForeignKey(
                        name: "FK_PersonelYetkileri_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelYetkileri_Yetkiler_YetkiId",
                        column: x => x.YetkiId,
                        principalTable: "Yetkiler",
                        principalColumn: "YetkiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiparisDetaylari",
                columns: table => new
                {
                    SiparisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiparisId1 = table.Column<int>(nullable: true),
                    UrunId = table.Column<int>(nullable: false),
                    BirimFiyati = table.Column<decimal>(nullable: false),
                    Miktar = table.Column<decimal>(nullable: false),
                    Indirim = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisDetaylari", x => x.SiparisId);
                    table.ForeignKey(
                        name: "FK_SiparisDetaylari_Siparisler_SiparisId1",
                        column: x => x.SiparisId1,
                        principalTable: "Siparisler",
                        principalColumn: "SiparisId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SiparisDetaylari_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonelYetkileri_PersonelId",
                table: "PersonelYetkileri",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelYetkileri_YetkiId",
                table: "PersonelYetkileri",
                column: "YetkiId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylari_SiparisId1",
                table: "SiparisDetaylari",
                column: "SiparisId1");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylari_UrunId",
                table: "SiparisDetaylari",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_MusteriId",
                table: "Siparisler",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_PersonelId",
                table: "Siparisler",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_BirimId",
                table: "Urunler",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_TedarikciId",
                table: "Urunler",
                column: "TedarikciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonelYetkileri");

            migrationBuilder.DropTable(
                name: "SiparisDetaylari");

            migrationBuilder.DropTable(
                name: "Yetkiler");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Birimler");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Tedarikciler");
        }
    }
}
