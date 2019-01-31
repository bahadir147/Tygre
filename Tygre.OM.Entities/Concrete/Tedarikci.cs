using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Tygre.Core.Entities;

namespace Tygre.OM.Entities.Concrete
{
    public class Tedarikci : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TedarikciId { get; set; }
        public string SirketAdi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
        public string TelNo { get; set; }
        public string Region { get; set; }


        public List<Urun> Urunler { get; set; }

    }
}
