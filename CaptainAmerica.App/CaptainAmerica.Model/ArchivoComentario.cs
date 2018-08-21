using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CaptainAmerica.Model
{
    public class ArchivoComentario : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArchivoComentario { get; set; }
        public string ArchivoComentarioDescr { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdProyectoArchivo { get; set; }
        public int IdUsuario { get; set; }

        [ForeignKey("IdProyectoArchivo")]
        public ProyectoArchivo ProyectoArchivo { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
    }
}