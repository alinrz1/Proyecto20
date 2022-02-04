using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto20.Models
{
    [Table("TURNO")]
    public class Turno
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        public int ID_Turno { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}