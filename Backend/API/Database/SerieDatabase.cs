using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace API.Database
{
    public class SerieDatabase
    {
        Models.eakdbContext db = new Models.eakdbContext();

        public void Inserir(Models.TbSerie serie)
        {
            db.TbSerie.Add(serie);
            db.SaveChanges();
        }

        public List<Models.TbSerie> ListarTodas()
        {
            List<Models.TbSerie> series = db.TbSerie
                                            .ToList();
            return series;
        }

         public Models.TbSerie Consulta(int id)
        {
            Models.TbSerie serie = db.TbSerie
                                     .FirstOrDefault (x => x.IdSerie == id);
            return serie; 
        }

        public void Alterar(Models.TbSerie serie)
        {
            Models.TbSerie alterado = db.TbSerie
                                        .FirstOrDefault(x => x.IdSerie == serie
                                                              .IdSerie);
            alterado.NmSerie = serie.NmSerie;
            alterado.TpPeriodo = serie.TpPeriodo;
            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Models.TbSerie remover = db.TbSerie
                                       .FirstOrDefault(x => x.IdSerie == id);

            db.TbSerie.Remove(remover);
            db.SaveChanges();
        }
    }
}