using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace API.Business
{
    public class DisciplinaBusiness
    {
        Database.DisciplinaDatabase database = new Database.DisciplinaDatabase();

        public void Inserir(Models.TbDisciplina disciplina)
        {
            if(disciplina.NmDisciplina.Trim()=="")
                throw new ArgumentException("O Nome é obrigatório");
            
            database.Inserir(disciplina);
        }
        public List<Models.TbDisciplina> Consultar(string nome)
        {
            List<Models.TbDisciplina> lista = null;

            if(nome.Trim() == "")
               throw new ArgumentException("O Nome é obrigatório");
            
            lista = database.Consultar(nome);
            
            return lista;
        } 
        public List<Models.TbDisciplina> ListarTodos()
        {
            List<Models.TbDisciplina> lista = null;
            
            lista = database.ListarTodos();

            return lista;
        } 
        public void Alterar(Models.TbDisciplina disciplina)
        {
             if(disciplina.NmDisciplina.Trim()=="")
                throw new ArgumentException("O Nome é obrigatório");
            
            database.Alterar(disciplina);
        }
        public void Deletar (int id)
        {
            if(id<=0)
               throw new ArgumentException("Essa Disciplina não existe");

            database.Deletar(id);
        }

    }
}