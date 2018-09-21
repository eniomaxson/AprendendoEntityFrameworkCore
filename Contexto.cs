using ConsoleApp.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    public class Contexto : DbContext
    {
        private DbContextOptionsBuilder<Contexto> optionsBuilder;

        public Contexto() { }

        public Contexto(DbContextOptions<Contexto> optionsBuilder) : base(optionsBuilder)
        { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Laudo> Laudos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=blog.db");
            optionsBuilder.UseSqlServer(@"
                Data Source=(localdb)\MSSQLLocalDB;
                Initial Catalog=ConsoleAppDB;
                Integrated Security=True;
                Connect Timeout=30;
                Encrypt=False;
                TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False
                ");
        }

    }
}
