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

        public  ConsultarModel(AulasAspNetContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }
        [HttpPost]
        public void OnPost(string CPF)
        {
        Usuario u = _context.Usuario.Where(u1 => u1.CPF == CPF).FirstOrDefault();

        if (u != null)
        {
            ViewData["usuario"] = u;
        }

    }

        }
    }
