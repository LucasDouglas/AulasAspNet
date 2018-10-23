using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AulasAspNet.Data;
using AulasAspNet.Models;

namespace AulasAspNet.Pages.Usuarios
{
    public class DetailsModel : PageModel
    {
        private readonly AulasAspNet.Models.AulasAspNetContext _context;

        public DetailsModel(AulasAspNet.Models.AulasAspNetContext context)
        {
            _context = context;
        }

        public Usuario Usuario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.UsuarioId == id);

            if (Usuario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
