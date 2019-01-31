using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tygre.OM.Entities.Concrete
{
    public class Yetki
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YetkiId { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Yol { get; set; }
        public string Icon { get; set; }

        public List<PersonelYetki> PersonelYetkiler { get; set; }
    }
}
