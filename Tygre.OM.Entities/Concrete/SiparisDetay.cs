using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Tygre.Core.Entities;

namespace Tygre.OM.Entities.Concrete
{
    public class SiparisDetay : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiparisId { get; set; }
        public Siparis Siparis { get; set; }

        public int UrunId { get; set; }
        public Urun Urun { get; set; }

        public decimal BirimFiyati { get; set; }
        public decimal Miktar { get; set; }
        public decimal Indirim { get; set; }
    }
}
