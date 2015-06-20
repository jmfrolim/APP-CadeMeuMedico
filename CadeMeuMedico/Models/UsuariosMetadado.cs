using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CadeMeuMedico.Models
{
    public partial class Usuarios
    {

    }
    public class UsuariosMetadado
    {
        [Required(ErrorMessage = "Obrigatorio Informar Nome!")]
        [StringLength(80, ErrorMessage = "O nome deve possuir no  maximo 80 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome de Login!")]
        [StringLength(30, ErrorMessage = "O login deve possuir no maximo 30 caracteres!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar senha!")]
        [StringLength(100, ErrorMessage = "Senha deve possuir no maximo 100 caracteres!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar e-mail!")]
        [StringLength(100, ErrorMessage = "O e-mail deve possuir no maximo 100 caracteres!")]
        public string Email { get; set; }
    }
}