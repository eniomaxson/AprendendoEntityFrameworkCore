using System;
using System.Linq;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region usandoContextBuilder
            //var optionsBuilder = new DbContextOptionsBuilder<Contexto>();
            //optionsBuilder.UseSqlite("Data Source=blog.db");
            #endregion

            using (var contexto = new Contexto())
            {
                #region  AlterandoRegistrosDeLaudosNulos

                //var laudosSituacaoNula = contexto.Laudos.Where(l => l.Situacao == 0).ToList();
                //laudosSituacaoNula.ForEach(l => l.Situacao = SituacaoLaudo.Assinado);

                //foreach (var item in laudosSituacaoNula)
                //{
                //    item.Situacao = SituacaoLaudo.Assinado;
                //}
                #endregion

                #region Mostrando como alterar dados do paciente

                // objeto tracked
                //var paciente = contexto.Pacientes.Where(p => p.PacienteId == 2).FirstOrDefault();
                //paciente.Nome = "GIOVANE MENDES";
                //contexto.SaveChanges();


                //objeto não tracked
                //var paciente = contexto.Pacientes.Where(p => p.PacienteId == 2).AsNoTracking().FirstOrDefault();
                //paciente.Nome = "GIOVANE MENDES";
                ////contexto.Entry(paciente).State = EntityState.Modified;
                //contexto.Pacientes.Update(paciente);
                //contexto.SaveChanges();

                #endregion

                #region Buscando laudos por data, profissional e situação

                ////var query = contexto.Laudos.Where(l => l.Profissional.ProfissionalId == 1);

                ////query = query.Where(l => l.DataAbertura >= DateTime.Now.AddDays(-1) &&
                ////                         l.DataAbertura <= DateTime.Now);

                ////query = query.Where(l => l.Situacao == SituacaoLaudo.Assinado);

                //var filtro = new LaudoQuery(DateTime.Now.AddDays(-1), DateTime.Now, 1, SituacaoLaudo.Assinado);

                //var query = contexto.Laudos
                //                    .Where(filtro.LaudosPorDataProfissionalSituação);

                //foreach (var laudo in query.ToList())
                //{
                //    contexto.Entry(laudo).Navigation("Profissional").Load();
                //    Console.WriteLine(laudo.Profissional.Nome);
                //}

                #endregion

                #region Removendo Dados

                //var laudo = contexto.Laudos.Find(1);
                //contexto.Laudos.Remove(laudo);
                //contexto.SaveChanges();

                #endregion

                var profissional = contexto.Profissionais.Where(p => p.ProfissionalId == 1).FirstOrDefault();
                contexto.Entry(profissional).Collection("Laudos").Load();

                foreach (var laudo in profissional.Laudos)
                {
                    Console.WriteLine(laudo.Situacao);
                }

            }
        }
    }
}
