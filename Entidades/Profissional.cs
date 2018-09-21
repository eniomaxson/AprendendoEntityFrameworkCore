using System.Collections.Generic;

namespace ConsoleApp.Entidades
{
    public class Profissional
    {
        public int ProfissionalId { get; set; }
        public string Nome { get; set; }

        public ICollection<Laudo> Laudos { get; set; }
    }
}
