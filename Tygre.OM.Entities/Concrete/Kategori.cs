using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Tygre.Core.Entities;
using Tygre.Core.Enums;

namespace Tygre.OM.Entities.Concrete
{
    public class Kategori : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public StatusEnum Status { get; set; }

        public List<Urun> Urunler { get; set; }
    }
}
