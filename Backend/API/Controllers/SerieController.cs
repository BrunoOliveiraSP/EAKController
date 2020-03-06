using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    
        [ApiController]
        [Route("[controller]")]
    public class SerieController : ControllerBase
    {
        API.Business.SerieBusiness business = new Business.SerieBusiness();

        [HttpPost]

        public void Inserir(Models.TbSerie serie)
        {
            business.Inserir(serie);
        }   


        [HttpGet]

        public List<Models.TbSerie> ListarTodas()
        {
            List<Models.TbSerie> serie = business.ListarTodas();
            return serie;
        }

        [HttpPut]

        public void Alterar(Models.TbSerie serie)
        {
            business.Alterar(serie);
        }

        [HttpDelete("{id}")]
        public void Remover(int id)
        {
            business.Remover(id);
        }
    }
}