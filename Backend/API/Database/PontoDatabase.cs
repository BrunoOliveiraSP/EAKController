using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
namespace API.Database
{
    public class PontoDatabase
    {
        Models.eakdbContext db = new Models.eakdbContext();
        
        public void Inserir(Models.TbPonto ponto)
        {
            db.TbPonto
              .Add(ponto);

            db.SaveChanges();
        }
        public List<Models.TbPonto> Consultar(int idserie)
        {
            List<Models.TbPonto> lista = null;

            lista = db.TbPonto
                      .Where(t=>t.IdSerieAluno == idserie)
                      .ToList();

            return lista;
        }
        public void Deletar(int id)
        {
            Models.TbPonto del = null;

            del = db.TbPonto
                    .FirstOrDefault(t=>t.IdPonto == id);

            db.Remove(del);

            db.SaveChanges();
        }
        public void Alterar(Models.TbPonto ponto)
        {
            Models.TbPonto novo = null;

            novo = db.TbPonto
                     .FirstOrDefault(t=>t.IdPonto == ponto.IdPonto);

            novo.QtPontos = ponto.QtPontos;
            novo.DsObservacao = ponto.DsObservacao;
            novo.DtAdicionado = ponto.DtAdicionado;

            db.SaveChanges();
        }
        public List<Models.TbPonto> ListarTodos()
        {
            List<Models.TbPonto> lista = null;

            lista = db.TbPonto
                      .ToList();
                      
            return lista;
        }


    }
}