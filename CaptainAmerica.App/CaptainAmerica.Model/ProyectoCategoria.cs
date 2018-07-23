using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CaptainAmerica.Model
{
    public class ProyectoCategoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCategoriaProyecto { get; set; }
        [StringLength(50)]
        public string NombreCategoriaProyecto { get; set; }
        [StringLength(255)]
        public string DescrCategoriaProyecto { get; set; }
    }
}