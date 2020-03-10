using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EAK.APP.API
{
    class ProfessorApi
    {
        public void Inserir(Models.ProfessorModel professor)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(professor);

            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Professor/", body).Result;
        }
        public List<Models.ProfessorModel> Consultar(string nome)
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Professor"+ nome)
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;
            List<Models.ProfessorModel> lista = JsonConvert.DeserializeObject<List<Models.ProfessorModel>>(json);

            return lista;
        }
        public void Alterar(Models.ProfessorModel professor)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(professor);

            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PutAsync("http://localhost:5000/Professor/", body).Result;
        }
        public void Deletar(int id)
        {
            HttpClient client = new HttpClient();
            var resp = client.DeleteAsync("http://localhost:5000/Professor/" + id).Result;
        }
    }
}
