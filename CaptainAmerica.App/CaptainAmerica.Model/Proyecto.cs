using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CaptainAmerica.Model
{
    public class Proyecto : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProyecto { get; set; }
        [StringLength(75)]
        public string NombreProyecto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdCliente { get; set; }
        public int IdCategoriaProyecto { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
        [ForeignKey("IdCategoriaProyecto")]
        public ProyectoCategoria ProyectoCategoria { get; set; }
    }
}