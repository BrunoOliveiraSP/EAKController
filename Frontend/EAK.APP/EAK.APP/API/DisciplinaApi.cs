using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EAK.APP.API
{
    class DisciplinaApi
    {
        public void Inserir(Models.DisciplinaModel disciplina)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(disciplina);

            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Disciplina/", body).Result;
        }
        public List<Models.DisciplinaModel> Consultar(string nome)
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Disciplina/" + nome)
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;
            List<Models.DisciplinaModel> lista = JsonConvert.DeserializeObject<List<Models.DisciplinaModel>>(json);

            return lista;
        }
        public void Alterar(Models.DisciplinaModel disciplina)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(disciplina);

            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PutAsync("http://localhost:5000/Disciplina/", body).Result;
        }
        public void Delete (int id)
        {
            HttpClient client = new HttpClient();

            var resp = client.DeleteAsync("http://localhost:5000/Disciplina/" + id).Result;
        }
    }
}
