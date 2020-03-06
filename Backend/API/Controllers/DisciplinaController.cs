using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplinaController : ControllerBase
    {
        Business.DisciplinaBusiness business = new Business.DisciplinaBusiness();

        [HttpPost]
        public void Inserir(Models.TbDisciplina disciplina)
        {
            business.Inserir(disciplina);
        }

        [HttpGet]
        public List<Models.TbDisciplina> Consultar(string nome)
        {
            List<Models.TbDisciplina> lista = null;

            if(nome == null)
               lista =business.ListarTodos();
            else
                lista =business.Consultar(nome);

            return lista;
        }

        [HttpPut]
        public void Alterar(Models.TbDisciplina disciplina)
        {
            business.Alterar(disciplina);
        }

        [HttpDelete]
        public void Deletar(int id)
        {
            business.Deletar(id);
        }
    }
}