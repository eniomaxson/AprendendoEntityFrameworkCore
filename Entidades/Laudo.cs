using ConsoleApp.Enuns;
using System;

namespace ConsoleApp.Entidades
{
    public class Laudo
    {
        public int LaudoId { get; set; }

        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public int ProfissionalId { get; set; }
        public Profissional Profissional { get; set; }

        public DateTime DataAbertura { get; set; }
        public string Texto { get; set; }
        public SituacaoLaudo Situacao { get; set; }
    }
}
