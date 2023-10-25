using System.Data.SqlClient;
using Dapper;

namespace TP10MiSitioDeSeries.Models;

public class BD{
private static string _connectionString = @"Server=.;DataBase=BDSeries;Trusted_Connection=True;";
    
    public static List<Series> CargarSeries(){
        List<Series> devolver = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            devolver = db.Query<Series>(sql).ToList();
        }
        return devolver;
    }

    // public static List<Actores> VerActores(int IdSerie){  
    //     List<Actores> listaActores = new List<Actores>();
    //     using (SqlConnection db = new SqlConnection(_connectionString))
    //     {
    //         string sql = "SELECT * FROM Actores WHERE IdSerie = @pIdSerie";
    //         listaActores = db.Query<Actores>(sql, new { pIdSerie = IdSerie }).ToList();
    //     }
    //     return listaActores; 
    // }

    public static List<Actores> VerActores(int idSerie){
        List<Actores> devolver = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Actores WHERE IdSerie = @IdSerie";
            devolver = db.Query<Actores>(sql, new{IdSerie = idSerie}).ToList();
        }
        return devolver;
    }


    public static List<Temporadas> VerTemporadas(int IdSerie){
        List<Temporadas> listaTemporadas = new List<Temporadas>();
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @pIdSerie";
            listaTemporadas = db.Query<Temporadas>(sql, new { pIdSerie = IdSerie }).ToList();
        }
        return listaTemporadas; 
    }

    public static Series VerSerie(int IdSerie)
        {
            Series sActual = null;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Series WHERE IdSerie = @pIdSerie";
                sActual = db.QueryFirstOrDefault<Series>(sql,new {pIdSerie = IdSerie});
            }
            return sActual;
        }





}