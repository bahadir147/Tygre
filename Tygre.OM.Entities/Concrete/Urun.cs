using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Tygre.Core.Entities;

namespace Tygre.OM.Entities.Concrete
{
    public class Urun : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyati { get; set; }
        public byte[] UrunResmi { get; set; }

        public int TedarikciId { get; set; }
        public Tedarikci Supplier { get; set; }

        public int BirimId { get; set; }
        public Birim Birim { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
