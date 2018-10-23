using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AulasAspNet.Data;

namespace AulasAspNet.Models
{
    public class AulasAspNetContext : DbContext
    {
        public AulasAspNetContext (DbContextOptions<AulasAspNetContext> options)
            : base(options)
        {
        }

        public DbSet<AulasAspNet.Data.Usuario> Usuario { get; set; }
    }
}
