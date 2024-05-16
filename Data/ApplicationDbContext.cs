using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Projeto_de_Desenvolvimeto_TOTVS.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<CadastrosModel> Cadastros { get; set; }
}
