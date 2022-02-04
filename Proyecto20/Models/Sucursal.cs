using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto20.Models
{
    [Table("SUCURSAL")]
    public class Sucursal
    {

        [Key]
        [Column(Order = 0)]
        [Required]
        public int ID_Sucursal { get; set; }
        [Required]
        [StringLength(100)]
        public string Nsucursal { get; set; }
        [Required]
        public bool Status { get; set; }

        public virtual ICollection<PEntrada> PEntradas { get; set; }
    }
}