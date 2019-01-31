using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tygre.Core.Entities;

namespace Tygre.OM.Entities.Concrete
{
    public class Birim : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BirimId { get; set; }
        public string BirimAdi { get; set; }

        public List<Urun> Urunler { get; set; }
    }
}