using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PontoController : ControllerBase
    {
        Business.PontoBusiness business = new Business.PontoBusiness();

        [HttpPost]
        public void Inserir(Models.TbPonto ponto)
        {
            business.Inserir(ponto);
        }

        [HttpGet]
        public List<Models.TbPonto> Consultar(int idSerie)
        {
            List<Models.TbPonto> lista = null;

            if(idSerie<= 0)
                lista =business.ListarTodos();
            else if(idSerie >0)
                lista =business.Consultar(idSerie);

                return lista;
        }

        [HttpPut]
        public void Alterar(Models.TbPonto ponto)
        {
            business.Alterar(ponto);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            business.Deletar(id);
        }
    }
}