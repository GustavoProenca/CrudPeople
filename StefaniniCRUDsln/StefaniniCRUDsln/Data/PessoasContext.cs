using Microsoft.EntityFrameworkCore;
using StefaniniCRUDsln.Models;

namespace StefaniniCRUDsln.Data
{
    public class Contexto :DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
       
    }


}
