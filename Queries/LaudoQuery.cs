using ConsoleApp.Entidades;
using ConsoleApp.Enuns;
using System;

namespace ConsoleApp.Queries
{
    public class LaudoQuery
    {

        public DateTime De { get; set; }
        public DateTime Ate { get; set; }
        public int ProfissionalId { get; set; }
        public SituacaoLaudo SituacaoLaudo { get; set; }

        public LaudoQuery(DateTime de, DateTime ate, int profissionalId, SituacaoLaudo situacaoLaudo)
        {
            De = de;
            Ate = ate;
            ProfissionalId = profissionalId;
            SituacaoLaudo = situacaoLaudo;
        }


        public Func<Laudo, bool> LaudosPorDataProfissionalSituação =>
                        l => l.DataAbertura >= De &&
                        l.DataAbertura <= Ate &&
                        l.ProfissionalId == ProfissionalId &&
                        l.Situacao == SituacaoLaudo;
        

    }
}
