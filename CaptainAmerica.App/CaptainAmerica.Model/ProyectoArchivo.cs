using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CaptainAmerica.Model
{
    public class ProyectoArchivo : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProyectoArchivo { get; set; }
        [StringLength(75)]
        public string NombreArchivo { get; set; }
        [StringLength(255)]
        public string URLGuardado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Proyecto Proyecto { get; set; }
    }
}