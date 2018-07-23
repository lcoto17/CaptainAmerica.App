using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CaptainAmerica.Model
{
    public class ArchivoComentario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArchivoComentario { get; set; }
        public string ArchivoComentarioDescr { get; set; }

        public ProyectoArchivo ProyectoArchivo { get; set; }
    }
}