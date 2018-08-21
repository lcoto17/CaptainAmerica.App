using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CaptainAmerica.Model
{
    public class Parametro : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdParametro { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }

    }
}