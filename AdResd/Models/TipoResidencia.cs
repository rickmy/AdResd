using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdResd.Models
{
    public class TipoResidencia
    {
        [Key]
        public int IdTipoResidencia { get; set; }
        [StringLength(50)]
        public string NombreTipoResidencia { get; set; }
        public bool Estado { get; set; } = true;

    }
}
