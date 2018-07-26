using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptainAmerica.Model
{
    public class Cliente : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }
        [StringLength(75)]
        public string NombreCliente { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
