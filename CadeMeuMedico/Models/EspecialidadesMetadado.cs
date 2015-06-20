using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CadeMeuMedico.Models
{
    public partial class Especialidades
    {

    }
    public class EspecialidadesMetadado
    {
        [Required(ErrorMessage = "Obrigatorio informar o nome da especialidade!")]
        [StringLength(80, ErrorMessage = "O nome deve possuir no maximo 80 caracteres!")]
        public string Nome { get; set; }
    }
}
