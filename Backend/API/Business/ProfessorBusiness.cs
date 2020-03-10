using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
namespace API.Business
{
    public class ProfessorBusiness
    {
        Database.ProfessorDatabase database = new Database.ProfessorDatabase();

        public void Inserir(Models.TbProfessor professor)
        {
            if(professor.NmProfessor.Trim() == "")
                throw new ArgumentException ("Nome é obrigatório");
            if(professor.DsEmail.Contains("@")== false) 
                throw new ArgumentException("Email invalido");
            if(professor.DsEmail.Trim() == "")
                throw new ArgumentException("Email é obrigatório");
            if(professor.DsSenha.Trim() == "")
                throw new ArgumentException("A Senha é obrigatória");
            else 
                database.Inserir(professor);
        }
        public List<Models.TbProfessor> ListarTodos()
        {
            List<Models.TbProfessor> lista =database.ListarTodos();
            return lista;
        }
        public List<Models.TbProfessor> Consultar(string nome)
        {
            if(nome.Trim()== null)
                throw new ArgumentException("Nome é obrigatório");
            
            List<Models.TbProfessor> lista = database.Consultar(nome);

            return lista;
        }
        public void Delete (int id)
        {
            if(id <=0)
                throw new ArgumentException("Professor desconhecido");
            else
                database.Delete(id);
        }
        public void Alterar (Models.TbProfessor professor)
        {
            if(professor.NmProfessor.Trim() == "")
                throw new ArgumentException ("Nome é obrigatório");
            if(professor.DsEmail.Contains("@")== false) 
                throw new ArgumentException("Email invalido");
            if(professor.DsEmail.Trim() == "")
                throw new ArgumentException("Email é obrigatório");
            if(professor.DsSenha.Trim() == "")
                throw new ArgumentException("A Senha é obrigatória");
            else 
                database.Alterar(professor);
        }

    }
}