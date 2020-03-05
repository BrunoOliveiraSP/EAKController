using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
         API.Business.AlunoBusiness business = new API.Business.AlunoBusiness();

         [HttpPost]
         public void Inserir(Models.TbAluno aluno)
         {
             business.Inserir(aluno);
         }

         [HttpGet]
         public List<Models.TbAluno> Consultar(string nome)
         {
             List<Models.TbAluno> alunos = null;
             
             if (nome == null)
                alunos = business.ListarTodos();
            else 
                alunos = business.Consulta(nome);
                
             return alunos;
         }


         [HttpPut]
         public void Alterar(Models.TbAluno aluno)
         {
             business.Alterar(aluno);
         }

         [HttpDelete("{id}")]
         public void Remover(int id)
         {
             business.Remover(id);
         }
    }
}
