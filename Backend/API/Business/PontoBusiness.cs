using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
namespace API.Business
{
    public class PontoBusiness
    {
        Database.PontoDatabase db = new Database.PontoDatabase();
        public void Inserir(Models.TbPonto ponto)
        {
            if(ponto.DsObservacao.Trim() == "")
                throw new ArgumentException("A observação é obrigatória");
            if(ponto.IdSerieAluno <=0)
                throw new ArgumentException("Esse Serie Aluno não existe");
            if(ponto.IdProfessor<=0)
                throw new ArgumentException("Esse Professor não existe");

            db.Inserir(ponto);
        }
        public void Deletar(int id)
        {
            if(id == 0)
            throw new ArgumentException("Ponto não encontrado");

            db.Deletar(id);
        }
        public void Alterar(Models.TbPonto ponto)
        {
            if(ponto.DsObservacao.Trim() == "")
                throw new ArgumentException("A observação é obrigatória");
            if(ponto.IdSerieAluno <=0)
                throw new ArgumentException("Esse Serie Aluno não existw");
            if(ponto.IdProfessor<=0)
                throw new ArgumentException("Esse Professor não existe");
            db.Alterar(ponto);
        }
        public List<Models.TbPonto> ListarTodos()
        {
            List<Models.TbPonto> lista = null;

            lista = db.ListarTodos();
            return lista;
        }
        public List<Models.TbPonto> Consultar(int idserie)
        {
            if(idserie == 0)
            throw new ArgumentException("Registro não encontrado");

            List<Models.TbPonto> lista = null;

            lista = db.Consultar(idserie);
            return lista;
        }
    }
}