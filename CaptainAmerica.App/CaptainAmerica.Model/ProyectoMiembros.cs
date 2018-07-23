using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CaptainAmerica.Model
{
    public class ProyectoMiembro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProyectoMiembro { get; set; }
        [StringLength(1)]
        public string MiembroPermiso { get; set; }

        public Proyecto Proyecto { get; set; }
        public Usuario Usuario { get; set; }
    }
}