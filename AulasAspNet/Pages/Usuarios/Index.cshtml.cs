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
    public class IndexModel : PageModel
    {
        private readonly AulasAspNet.Models.AulasAspNetContext _context;

        public IndexModel(AulasAspNet.Models.AulasAspNetContext context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; }

        public async Task OnGetAsync()
        {
            Usuario = await _context.Usuario.ToListAsync();
        }
    }
}
