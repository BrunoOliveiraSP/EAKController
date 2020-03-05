using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace API.Database
{
    public class ProfessorDatabase
    {
        Models.eakdbContext db = new Models.eakdbContext();
        
        public void Inserir(Models.TbProfessor professor)
        {
            db.TbProfessor.Add(professor);
            db.SaveChanges();
        }
        public List<Models.TbProfessor> ListarTodos()
        {
            List<Models.TbProfessor> list =db.TbProfessor.ToList();

            return list;
        }
        public List<Models.TbProfessor> Consultar(string nome)
        {
            List<Models.TbProfessor> list = db.TbProfessor                
                                              .Where(a => a.NmProfessor == nome)
                                              .ToList();

            return list;
        }
        public void Delete (int id)
        { 
           Models.TbProfessor del= db.TbProfessor
                                     .FirstOrDefault(a => a.IdProfessor == id);
           
           db.Remove(del);
           
           db.SaveChanges();
        }   
        public void Alterar (Models.TbProfessor professor)
        {
            Models.TbProfessor alterar= null;

            alterar = db.TbProfessor
                        .FirstOrDefault(a => a.IdProfessor == professor.IdProfessor );

            alterar.NmProfessor = professor.NmProfessor;
            alterar.DsEmail = professor.DsEmail;
            alterar.DsSenha = professor.DsSenha;

            db.SaveChanges();
        }
    }
}