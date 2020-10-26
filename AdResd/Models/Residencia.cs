using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace AdResd.Models
{
    public class Residencia
    {
        [Key]
        public int IdResidencia { get; set; }        
        [Required]
        [DisplayName("Tipo de Residencia")]
        public int TipoResidenciaId { get; set; }
        public TipoResidencia TipoResidencia { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Numero de la Residencia")]
        public string NumeroDeResidencia { get; set; }
        [Required]
        [StringLength(10)]
        [DisplayName("Cedula del Dueño")]
        public string CedulaDuenio { get; set; }
        [Required]
        [StringLength(70)]
        [DisplayName("Nombres del Dueño")]
        public string NombresDuenio { get; set; }
        [Required]
        [StringLength(70)]
        [DisplayName("Apellidos del Dueño")]
        public string ApellidoDuenio { get; set; }
        [Required]
        [StringLength(10)]
        [DisplayName("Teléfono del Dueño")]
        public string TelefonoDuenio { get; set; }
        [AllowNull]
        [DisplayName("Email del Dueño")]
        [EmailAddress]
        public string CorreoDuenio { get; set; }
        public bool Arrendado { get; set; }
        [StringLength(10)]
        [DisplayName("Cedula del Arrendatario")]
        public string CedulaArrendatario { get; set; }
        [StringLength(70)]
        [DisplayName("Nombres Arrendatario")]
        public string NombreArrendatario { get; set; }
        [StringLength(70)]
        [DisplayName("Apellidos Arrendatario")]
        public string ApellidoArrendatario { get; set; }
        [StringLength(10)]
        [DisplayName("Telefono Arrendatario")]
        public string TelefonoArrendatario { get; set; }
        [DisplayName("Encargado del Pago ")]
        public int EncargadoPagoId { get; set; }
        public EncargadoPago EncargadoPago { get; set; }


    }
}
