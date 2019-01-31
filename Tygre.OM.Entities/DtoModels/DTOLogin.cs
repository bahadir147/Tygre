using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tygre.OM.Entities.DtoModels
{
    public class DTOLogin
    {
        [Required, MaxLength(256)]
        public string PersonelAdi { get; set; }

        [Required, DataType(DataType.Password)]
        public string PersonelSifre { get; set; }
    }
}
