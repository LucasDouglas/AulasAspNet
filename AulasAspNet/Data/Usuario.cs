using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasAspNet.Data
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Nascimento { get; set; }

        public string Logradouro { get; set; }

        public string Localidade { get; set; }

        public string uf { get; set; }

        public string bairro { get; set; }

        public string numero { get; set; }

        public string complemento { get; set; }
        

    }
}
