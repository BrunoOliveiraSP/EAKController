using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Business
{
    public class AlunoBusiness
    {
        Database.AlunoDatabase db = new Database.AlunoDatabase();

        public void Inserir(Models.TbAluno aluno)
        {
            if(aluno.NmAluno == string.Empty)
                throw new Exception("Nome é obrigatório!");
                
            if(aluno.DsEmail == string.Empty)
                throw new Exception("E-mail é obrigatório!");
                
            if(aluno.DsSenha == string.Empty)
                throw new Exception("Senha é obrigatório!");

                db.Inserir(aluno);
       
        }

        public List<Models.TbAluno> ListarTodos()
        {
            return db.ListarTodos();
        }

        public List<Models.TbAluno> Consulta(string nome)
        {
            return db.Consulta(nome);
        }

        public void Alterar(Models.TbAluno aluno)
        {
            if(aluno.NmAluno == string.Empty)
                throw new Exception("Nome é obrigatório!!");

            if(aluno.DsEmail == string.Empty)
                throw new Exception("E-mail é obrigatório!!");
                
            if(aluno.DsSenha == string.Empty)
                throw new Exception("Senha é obrigatório!!");

            db.Alterar(aluno);
        }

        public void Remover(int id)
        {
            if(id == 0)
                throw new Exception("Id inválido");

            db.Remover(id);
        }
        
    }
}