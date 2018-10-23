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
    public class DeleteModel : PageModel
    {
        private readonly AulasAspNet.Models.AulasAspNetContext _context;

        public DeleteModel(AulasAspNet.Models.AulasAspNetContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Usuario = await _context.Usuario.FindAsync(id);

            if (Usuario != null)
            {
                _context.Usuario.Remove(Usuario);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
