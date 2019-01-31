using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tygre.Core.Entities;

namespace Tygre.OM.Entities.Concrete
{
    public class PersonelYetki : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PerosnelYetkiId { get; set; }

        public int PersonelId { get; set; }
        public int YetkiId { get; set; }


        public Personel Personel { get; set; }
        public Yetki Yetki { get; set; }
    }
}
