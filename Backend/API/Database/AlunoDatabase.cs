using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace API.Database
{
    public class AlunoDatabase
    {
        Models.eakdbContext db = new Models.eakdbContext();

        public void Inserir(Models.TbAluno aluno)
        {
            db.TbAluno.Add(aluno);
            db.SaveChanges();

        }

        public List <Models.TbAluno> ListarTodos()
        {
            List<Models.TbAluno> alunos = db.TbAluno.ToList();
            return alunos;
        }

        public List <Models.TbAluno> Consulta(string nome)
        {
            List<Models.TbAluno> alunos = db.TbAluno.Where (x => x.NmAluno.Contains(nome)).ToList();
            return alunos; 
        }

        public void Alterar(Models.TbAluno aluno)
        {
            Models.TbAluno alterado = db.TbAluno.FirstOrDefault(x => x.IdAluno == aluno.IdAluno);
            alterado.NmAluno = aluno.NmAluno;
            alterado.DsEmail = aluno.DsEmail;
            alterado.DsSenha = aluno.DsSenha;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Models.TbAluno remover = db.TbAluno.FirstOrDefault(x => x.IdAluno == id);

            db.TbAluno.Remove(remover);
            db.SaveChanges();
        } 
        
    }
}