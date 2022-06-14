using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EvTecnicaGyS.Domain.Models
{
    public class Client
    {
        [Key]
        [Column(TypeName = "varchar(10)")]
        public string CodCliente { get; set; }

        [Required]
        [Column(TypeName="varchar(200)")]
        public string NombreCompleto { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string NombreCorto { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string Abreviatura { get; set; }

        [Required]
        [Column(TypeName = "varchar(11)")]
        public string Ruc { get; set; }

        [Required]
        [Column(TypeName = "char(1)")]
        public string Estado { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string GrupoFacturacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime InactivoDesde { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CodigoSAP { get; set; }
    }
}
