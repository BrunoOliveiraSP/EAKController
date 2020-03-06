using System;
using System.Collections.Generic;

namespace API.Business
{
    public class SerieBusiness
    {
        Database.SerieDatabase db = new Database.SerieDatabase();

        public void Inserir(Models.TbSerie serie)
        {
            if(serie.NmSerie == string.Empty)
                throw new Exception("Nome é obrigatório!!");
                
            if(serie.TpPeriodo == string.Empty)
                throw new Exception("Período é obrigatório!!");

            db.Inserir(serie);

        }

        public List<Models.TbSerie> ListarTodas()
        {
            return db.ListarTodas();
        }

        public void Alterar(Models.TbSerie serie)
        {
            if(serie.NmSerie == string.Empty)
                throw new Exception("Nome é obrigatório");
                
            if(serie.TpPeriodo == string.Empty)
                throw new Exception("Período é obrigatório");

            db.Alterar(serie);
        }

        public void Remover(int id)
        {
            if(id == 0)
                throw new Exception("Id inválido");

            db.Remover(id);
        }
    }
}