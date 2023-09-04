using Microsoft.EntityFrameworkCore;
using PrimeiroCRUD.Models;

namespace PrimeiroCRUD.Data
{
    public class Contexto: DbContext
    {
    public Contexto(DbContextOptions<Contexto> options):base(options) { }

        public DbSet<ProdutoModel> Produto {get; set;}
    }






}
