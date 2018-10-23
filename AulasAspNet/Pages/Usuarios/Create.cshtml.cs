using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AulasAspNet.Data;
using AulasAspNet.Models;

namespace AulasAspNet.Pages.Usuarios
{
    public class CreateModel : PageModel
    {
        private readonly AulasAspNet.Models.AulasAspNetContext _context;

        public CreateModel(AulasAspNet.Models.AulasAspNetContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Usuario Usuario { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Usuario.Add(Usuario);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}