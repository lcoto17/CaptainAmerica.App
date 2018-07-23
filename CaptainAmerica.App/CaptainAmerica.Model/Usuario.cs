using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CaptainAmerica.Model
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        [StringLength(50)]
        public string CodigoUsuario { get; set; }
        [StringLength(75)]
        public string NombreUsuario{ get; set; }
        public DateTime FechaCreacion { get; set; }

        public Rol Rol { get; set; }

    }
}