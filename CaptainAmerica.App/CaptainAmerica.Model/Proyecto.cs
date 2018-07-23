using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CaptainAmerica.Model
{
    public class Proyecto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProyecto { get; set; }
        [StringLength(75)]
        public string NombreProyecto { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Cliente Cliente { get; set; }
        public ProyectoCategoria ProyectoCategoria { get; set; }
    }
}