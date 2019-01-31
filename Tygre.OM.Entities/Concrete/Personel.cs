using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Tygre.Core.Entities;
using Tygre.Core.Enums;

namespace Tygre.OM.Entities.Concrete
{
    public class Personel : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonelId { get; set; }
        public string SoyAdi { get; set; }
        public string Adi { get; set; }
        public string Sifre { get; set; }
        public string Unvan { get; set; }
        public string UnvanEki { get; set; }
        public CinsiyetEnum Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public string Adres { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Bolge { get; set; }
        public StatusEnum Status { get; set; }

        public List<PersonelYetki> PersonelYetkileri { get; set; }
    }
}
