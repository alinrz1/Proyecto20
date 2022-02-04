using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto20.Models
{
    [Table("PROC_ENTRADASDETALLE")]
    public class PEDetalle
    {

        [Key]
        [Column(Order = 0)]
        [Required]
        public int ID_Detalle { get; set; }
        [Required]
        public int Nproducto { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        [Required]
        public float Cantidad { get; set; }
        [Required]
        public float Precio { get; set; }
        [Required]
        public float Descuento { get; set; }
        [Required]
        public int IVA { get; set; }
        [Required]
        public bool IEPS { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}