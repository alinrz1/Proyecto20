using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto20.Models
{
    [Table("PROC_ENTRADAS")]
    public class PEntrada
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        public int ID_Entrada { get; set; }
        [Required]
        public int ID_Sucursal { get; set; }
        public virtual ICollection<Sucursal> Sucursales { get; set; }
        [Required]
        public int ID_Proveedor { get; set; }
        public virtual ICollection<Proveedor> Proveedores { get; set; }
        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        [Required]
        public string Usuario { get; set; }
        [Required]
        [StringLength(100)]
        public string Referencia { get; set; }
        [Required]
        public DateTime Fecha_Captura { get; set; }
        [Key]
        [Column(Order = 7)]
        [StringLength(15)]
        [Required]
        public string Usuario_Cancelacion { get; set; }
        [Required]
        public DateTime Fecha_Cancelacion { get; set; }
        [Required]
        public string Motivo_Cancelacion { get; set; }
        [Required]
        public string Comentarios { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}