using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
namespace API.Database
{
    public class SerieAlunoDatabase
    {
        Models.eakdbContext db = new Models.eakdbContext();
        public void Inserir(Models.TbSerieAluno serieAluno)
        {
            db.TbSerieAluno.Add(serieAluno);
            db.SaveChanges();     
        }

        public List<Models.TbSerieAluno> ListarTudo()
        {
            List<Models.TbSerieAluno> serieAlunos = db.TbSerieAluno
                                                      .ToList();
            return serieAlunos;
        }

        public void Remover(int id)
        {
            Models.TbSerieAluno remover = db.TbSerieAluno
                                            .FirstOrDefault(x => x.IdSerieAluno == id);
            db.TbSerieAluno
              .Remove(remover);
            db.SaveChanges();
        }

        public void Alterar(Models.TbSerieAluno serieAluno)
        {
            Models.TbSerieAluno alterado = db.TbSerieAluno
                                             .FirstOrDefault(x => x.IdSerieAluno == serieAluno
                                                                   .IdSerieAluno);
            alterado.NrAno = serieAluno.NrAno;
            alterado.NrChamada = serieAluno.NrChamada;
            alterado.IdAluno = serieAluno.IdAluno;
            alterado.IdSerie = serieAluno.IdSerie;
            db.SaveChanges();
                        
        }
    }
}