using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class cadastroContext : DbContext
    { public cadastroContext(DbContextOptions<cadastroContext> options) : base(options) { }
        public DbSet<Cadastro> Cadastros_Farmacia { get; set; }
    }
}
