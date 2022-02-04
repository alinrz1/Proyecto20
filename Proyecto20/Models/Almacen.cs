using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto20.Models
{
    [Table("ALMACEN")]
    public class Almacen
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        public string ID_Almacen { get; set; }
        [Required]
        public int ID_Proveedor { get; set; }
        public virtual ICollection<Proveedor> Proveedores { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        [StringLength(100)]
        public string Nproducto { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }

        [Required]
        [StringLength(100)]
        public string Npresentacion { get; set; }
        public virtual ICollection<Presentacion> Presentaciones { get; set; }
        [Required]
        public int Cantidad { get; set; }
    }
}