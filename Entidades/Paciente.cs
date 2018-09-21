using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Entidades
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nome { get; set; }
    }
}
