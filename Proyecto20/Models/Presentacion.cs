using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto20.Models
{
    [Table("PRESENTACIONES")]
    public class Presentacion
    {
        [Key]
        [Column(Order = 0)]
        public int ID_Presentacion { get; set; }
        [Key]
        [Column(Order = 1)]
        [Required]
        [StringLength(100)]
        public string Npresentacion { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public bool Status { get; set; }
        public virtual ICollection<Almacen> Almacenes { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }

    }
}