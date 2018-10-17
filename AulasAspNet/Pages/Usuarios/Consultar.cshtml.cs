using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulasAspNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AulasAspNet.Pages.Usuarios
{
    public class ConsultarModel : PageModel
    {
        public void OnGet()
        {

        }
        [HttpPost]
        public void OnPost(string CPF)
        {
            List<Usuario> usuarios = CadastrarModel.usuarios;

            foreach(Usuario u in usuarios)
            {
                if (CPF.Equals(u.CPF))
                {
                    ViewData["usuario"] = u;
                }
                
                
            }

        }
    }
}