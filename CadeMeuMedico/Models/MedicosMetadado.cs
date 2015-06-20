using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(MedicosMetadado))]
    public partial class Medicos
    {
    }

    public class MedicosMetadado
    {
        [Required(ErrorMessage = "Obrigatorio informar CRM")]
        [StringLength(30, ErrorMessage = "O CRM deve possuir no maximo 30 caracteres!")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "É obrigatorio informar o nome!")]
        [StringLength(80, ErrorMessage = "O nome deve possuir no maximo 80 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Obrigatorio informar o Endereço")]
        [StringLength(100, ErrorMessage = "O endereço deve possuir no maximo 100 caracteres")]
        public string Endereco {get;set;}

        [Required(ErrorMessage = "Obrigatorio informar o Bairro")]
        [StringLength(60, ErrorMessage = "O barrio deve possuir no maximo 60 caracteres!")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar e-mail")]
        [StringLength(100, ErrorMessage = "O e-mail deve possuir no maximo 100 caracteres!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se tem convenio!")]
        public bool AtendePorConvenio { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se tem Clinica!")]
        public bool TemClinica { get; set; }


        [Required(ErrorMessage = "Obrigatorio informar Site!")]
        [StringLength(60, ErrorMessage = "O Site de possuir no maximo 60 caracteres!")]
        public string WebsiteBlog { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar cidade")]
        public int IDCidade { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar Especialidade")]
        public int IDEspecialidade { get; set; }

    }
}
