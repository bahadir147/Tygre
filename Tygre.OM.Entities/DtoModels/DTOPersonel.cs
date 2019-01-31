using System;
using System.Collections.Generic;
using System.Text;
using Tygre.Core.Enums;

namespace Tygre.OM.Entities.DtoModels
{
    public class DTOPersonel
    {
        public string SoyAdi { get; set; }
        public string Adi { get; set; }
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

    }
}
