using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AulasAspNet.Data
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required(ErrorMessage ="Nome é obrigatório")]
        [MaxLength(30, ErrorMessage ="No maximo 30 caracteres")]
        public string Nome { get; set; }
      
        public string Senha { get; set; }

        public string CPF { get; set; }
        
        [Required(ErrorMessage = "E-mail é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatório")]
        public string Nascimento { get; set; }

        [RegularExpression(@"\d\d\d\d\d-\d\d\d", ErrorMessage = "O Cep deve conter somente oito digitos válidos")]
        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Localidade { get; set; }

        public string uf { get; set; }

        public string bairro { get; set; }

        public string numero { get; set; }

        public string complemento { get; set; }
        

    }
}
