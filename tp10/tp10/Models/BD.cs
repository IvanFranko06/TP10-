using System.Data.SqlClient;
using Dapper;

public static class BD
{
    private static string ConnectionString { get; set; } = @"Server=localhost;Database=BDSeries;Trusted_Connection=True;";

    public static List<Serie> SeleccionS()
    {
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Series";
            return db.Query<Serie>(sql).ToList();
        }
    }
 public static List<Actores> SeleccionA()
    {
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Actores";
            return db.Query<Actores>(sql).ToList();
        }
    }


    public static List<Temporada> SeleccionT(int idSerie)
    {
        List<Temporada> listaTemporadas = new List<Temporada>();
        string sql = "SELECT * FROM Temporada WHERE IdSerie = @pidSerie";
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            listaTemporadas = db.Query<Temporada>(sql, new {pidSerie = idSerie}).ToList();
            return listaTemporadas;
        }
    }

     public static Serie SeleccionS2(int id)
    {
        Serie c = new Serie();
        string sql = "SELECT * FROM Series where IdSerie=@pid";
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            
             c = db.QueryFirstOrDefault<Serie>(sql, new {pid=id});
            
        }
        return c;
    }
}
   
