using System.Data.SqlClient;
using Dapper;

namespace TP10MiSitioDeSeries.Models;

public class BD{
private static string _connectionString = @"Server=.;DataBase=BDSeries;Trusted_Connection=True;";
    
    public static List<Series> CargarSeries(){
        List<Series> listaSeries = new List<Series>();
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            listaSeries = db.Query<Series>(sql).ToList(); 
        }
        return listaSeries; 
    }

    public static List<Actores> VerActores(int IdSerie){  
        List<Actores> listaActores = new List<Actores>();
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Actores WHERE IdSerie = @pIdSerie";
            listaActores = db.Query<Actores>(sql, new { pIdSerie = IdSerie }).ToList();
        }
        return listaActores; 
    }

    public static List<Temporadas> VerTemporadas(int IdSerie){
        List<Temporadas> listaTemporadas = new List<Temporadas>();
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @pIdSerie";
            listaTemporadas = db.Query<Candidato>(sql, new { pIdSerie = IdSerie }).ToList();
        }
        return listaTemporadas; 
    }





}