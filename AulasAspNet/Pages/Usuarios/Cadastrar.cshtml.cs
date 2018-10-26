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
    public class CadastrarModel : PageModel
    {

        AulasAspNetContext _context;
        public CadastrarModel(AulasAspNetContext context)
        {
            _context = context;
        }

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
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
                RedirectToPage("./Index");
            }
            
        }

    }
}