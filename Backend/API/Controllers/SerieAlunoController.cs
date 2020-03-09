using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SerieAlunoController : ControllerBase
    {
        API.Business.SerieAlunoBusiness business = new Business.SerieAlunoBusiness();

        [HttpPost]
        public void Inserir(Models.TbSerieAluno serieAluno)
         {
             business.Inserir(serieAluno);
         }

         [HttpGet]
         public List<Models.TbSerieAluno> ListarTudo()
         {
             List<Models.TbSerieAluno> serieAlunos = business.ListarTudo();
             
             return serieAlunos;
         }


         [HttpPut]
          public void Alterar(Models.TbSerieAluno serieAluno)
         {
             business.Alterar(serieAluno);
         }


         [HttpDelete("{id}")]
         public void Remover(int id)
         {
             business.Remover(id);
         }

    }
}