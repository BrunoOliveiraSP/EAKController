using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    
    public class ProfessorController : ControllerBase
    {
        Business.ProfessorBusiness business= new Business.ProfessorBusiness();

        [HttpPost] 
        public void Inserir(Models.TbProfessor professor)
        {
            business.Inserir(professor);
        }

        [HttpGet]
        public List<Models.TbProfessor> Consultar(string nome)
        {
            List<Models.TbProfessor> lista = null;
            
            if(nome == null)
                lista =business.ListarTodos();
            else 
                lista =business.Consultar(nome);

            return lista;
        }
        [HttpPut]
        public void Alterar(Models.TbProfessor professor)
        {
            business.Alterar(professor);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            business.Delete(id);
        }


    }
}