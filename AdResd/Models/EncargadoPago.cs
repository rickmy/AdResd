using System.ComponentModel.DataAnnotations;

namespace AdResd.Models
{
    public class EncargadoPago
    {
        [Key]
        public int IdEncargadoPago { get; set; }
        [StringLength(65)]
        public string  NombreEncargado { get; set; }
        public bool Estado { get; set; }
    }
}