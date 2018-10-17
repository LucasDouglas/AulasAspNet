using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulasAspNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AulasAspNet.Pages.Usuarios
{
    public class CadastrarModel : PageModel
    {
        static List<Usuario> usuarios = new List<Usuario>();

        [BindProperty (SupportsGet = true)]
        public Usuario usuario { get; set; }
        public void OnGet()
        {

            if (usuario == null)
            {
                usuario = new Usuario();
            }


        }
        [HttpPost]
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                usuarios.Add(usuario);
            }
            
        }

    }
}