using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(CidadesMetadado))]
    public partial class Cidades
    {

    }
    public class CidadesMetadado
    {
        [Required(ErrorMessage = "Obrigatorio informar cidade!")]
        [StringLength(100, ErrorMessage = "Cidade deve possuir no maximo 100 caracteres!")]
        public string Nome { get; set; }
    }

  
}