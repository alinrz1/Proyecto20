using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto20.Models
{
    [Table("PRODUCTO")]
    public class Producto
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        public int ID_Producto { get; set; }
        [Required]
        public int ID_Presentacion { get; set; }
        public virtual ICollection<Presentacion> Presentaciones { get; set; }
        [Key]
        [Column(Order = 2)]
        [Required]
        public int ID_PresentacionSalida { get; set; }
        [Key]
        [Column(Order = 3)]
        [Required]
        [StringLength(100)]
        public string Nproducto { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        public int Codigo_Barras { get; set; }
        [Required]
        public float StockMin { get; set; }
        [Required]
        public float StockMax { get; set; }
        [Required]
        public float Precio { get; set; }
        [Required]
        public float Precio_Promedio { get; set; }
        [Required]
        public float Factor { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public int IVA { get; set; }
        [Required]
        public bool IEPS { get; set; }
        public virtual ICollection<PEDetalle> PEDetalles { get; set; }
        public virtual ICollection<Almacen> Almacenes { get; set; }
    }
}