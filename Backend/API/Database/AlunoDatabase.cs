using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;


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
        public List<Models.TbAluno> Consultar(string nome)
        {
            List<Models.TbAluno> lista = db.TbAluno.Where(t=> t.NmAluno == nome).ToList();
            return lista;
        }
        // public void Delete(string nome)
        // {
        //     db.TbAluno.Remove(db.TbAluno.FirstOrDefault(t=> t.NmAluno == nome));
        //     db.SaveChanges();
        // }
        public void Delete(int id,string nome)
        {
            db.TbAluno.Remove(db.TbAluno.FirstOrDefault(t => t.IdAluno == id && t.NmAluno == nome));
            db.SaveChanges();
        }
        public void Alterar(Models.TbAluno aluno)
        {
            Models.TbAluno novo =db.TbAluno.FirstOrDefault(t => t.IdAluno == aluno.IdAluno && t.NmAluno == aluno.NmAluno);
            
            novo.NmAluno= aluno.NmAluno;
            novo.DsEmail = aluno.DsEmail;
            novo.DsSenha = aluno.DsSenha;

            db.SaveChanges();

        }
    }
}