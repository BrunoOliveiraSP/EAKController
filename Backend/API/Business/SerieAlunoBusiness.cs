using System;
using System.Collections.Generic;
namespace API.Business
{
    public class SerieAlunoBusiness
    {
        Database.SerieAlunoDatabase dbSerieAluno = new Database.SerieAlunoDatabase();
        Database.AlunoDatabase dbAluno = new Database.AlunoDatabase();
        Database.SerieDatabase dbSerie = new Database.SerieDatabase();

        public void Inserir(API.Models.TbSerieAluno serieAluno)
        {   
            var aluno = dbAluno.Consulta(serieAluno.IdAluno.Value);
            if(aluno == null)
                throw new ArgumentException("Id Inválido!!");

            var serie = dbSerie.Consulta(serieAluno.IdAluno.Value);
            if(serie == null)
                throw new ArgumentException("Id Inválido!!");

            dbSerieAluno.Inserir(serieAluno);
        }

        public List<Models.TbSerieAluno> ListarTudo()
        {
            return dbSerieAluno.ListarTudo();
        }

        public void Remover(int id)
        {
            if(id == 0)
                throw new Exception("Id inválido");

            dbSerieAluno.Remover(id);
        }

        public void Alterar(Models.TbSerieAluno serieAluno)
        {
            dbSerieAluno.Alterar(serieAluno);

        }

        

    }
}