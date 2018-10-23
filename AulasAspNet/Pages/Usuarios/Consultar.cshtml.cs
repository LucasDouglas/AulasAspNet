using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulasAspNet.Data;
using AulasAspNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AulasAspNet.Pages.Usuarios
{
    public class ConsultarModel : PageModel
    {
        AulasAspNetContext  _context;

        public class ConsultarModel(AulasAspNetContext context)
        {
            _context = context;
        }

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