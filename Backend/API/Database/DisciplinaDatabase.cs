using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
namespace API.Database
{
    public class DisciplinaDatabase
    {
        Models.eakdbContext db = new Models.eakdbContext();

        public void Inserir(Models.TbDisciplina disciplina)
        {
            db.TbDisciplina.Add(disciplina);
            db.SaveChanges();
        }
        public List<Models.TbDisciplina> Consultar(string nome)
        {
            List<Models.TbDisciplina> lista = null;

            lista = db.TbDisciplina
                      .Where(a => a.NmDisciplina == nome)
                      .ToList();

            return lista;
        }
        public List<Models.TbDisciplina> ListarTodos()
        {
            List<Models.TbDisciplina> lista = null;
            
            lista = db.TbDisciplina
                      .ToList();

            return lista;
        }
        public void Alterar(Models.TbDisciplina disciplina)
        {
            Models.TbDisciplina novo= null;

            novo= db.TbDisciplina
                    .FirstOrDefault(a => a.IdDisciplina == disciplina.IdDisciplina);

            novo.NmDisciplina = disciplina.NmDisciplina;

            db.SaveChanges();

        }
        public void Deletar (int id)
        {
            Models.TbDisciplina del = null;

            del = db.TbDisciplina
                    .FirstOrDefault(a => a.IdDisciplina == id);

            db.TbDisciplina.Remove(del);

            db.SaveChanges();
        }

    }
}