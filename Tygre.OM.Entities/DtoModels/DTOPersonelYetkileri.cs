using System;
using System.Collections.Generic;
using System.Text;

namespace Tygre.OM.Entities.DtoModels
{
    public class DTOPersonelYetkileri
    {
        public int YetkiId { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Yol { get; set; }
        public string Icon { get; set; }
    }
}
