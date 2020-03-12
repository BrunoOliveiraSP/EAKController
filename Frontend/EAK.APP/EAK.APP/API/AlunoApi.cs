using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EAK.APP.API
{
    class AlunoApi
    {
        public List<Models.AlunoModel> Consultar(string nome)
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Aluno" + nome)
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;
            List<Models.AlunoModel> lista = JsonConvert.DeserializeObject<List<Models.AlunoModel>>(json);

            return lista;
        }

        
    }
}
