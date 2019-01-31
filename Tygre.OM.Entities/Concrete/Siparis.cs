using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Tygre.Core.Entities;

namespace Tygre.OM.Entities.Concrete
{
    public class Siparis : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiparisId { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public DateTime SevkTarihi { get; set; }


        
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        public int PersonelId { get; set; }
        public Personel Personel { get; set; }

    }
}
