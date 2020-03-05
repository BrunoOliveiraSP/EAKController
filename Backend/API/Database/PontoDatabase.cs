namespace API.Database
{
    public class PontoDatabase
    {
        Models.eakdbContext db = new Models.eakdbContext();

        public void Inserir (Models.TbPonto ponto)
        {
            db.TbPonto.Add(ponto);
            db.SaveChanges();
        }
    }
}