using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto20.Models
{
    [Table("PROVEEDORES")]
    public class Proveedor
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        public int ID_Proveedor { get; set; }
        [Required]
        [StringLength(100)]
        public string Nproveedor { get; set; }
        [Required]
        [StringLength(100)]
        public string RazonSocial { get; set; }
        [Required]
        [StringLength(18)]
        public string RFC { get; set; }
        [Required]
        [StringLength(100)]
        public string Calle { get; set; }
        [Required]
        [StringLength(100)]
        public string Colonia { get; set; }
        [Required]
        [StringLength(100)]
        public string Ciudad { get; set; }
        [Required]
        [StringLength(5)]
        public string CP { get; set; }
        [Required]
        [StringLength(100)]
        public string Contacto { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        public int Celular { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        public bool Status { get; set; }

        public virtual ICollection<PEntrada> PEntrada { get; set; }
        public virtual ICollection<Almacen> Almacenes { get; set; }
    }
}