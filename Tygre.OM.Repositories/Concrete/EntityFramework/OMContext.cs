using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tygre.Core.Helpers;
using Tygre.OM.Entities.Concrete;
using Tygre.OM.Entities.DtoModels;

namespace Tygre.OM.Repositories.Concrete.EntityFramework
{
    public class OMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var appSettingsJson = AppSettingsJson.GetAppSettings();
            var connectionString = appSettingsJson["ConnectionStrings:DefaultConnection"];
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>().Property(p => p.UrunResmi).HasColumnType("image");
        }

        public DbSet<Birim> Birimler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylari { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Yetki> Yetkiler { get; set; }
        public DbSet<PersonelYetki> PersonelYetkileri { get; set; }



        //Views

        public DbQuery<DTOPersonelYetkileri> ViewPersonelYetkileri { get; set; }
    }
}
