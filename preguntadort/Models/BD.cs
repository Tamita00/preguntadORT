using System.Data.SqlClient;
using Dapper;
namespace TP6;

public class BD{
    private static string ConnectionString = @"Server=localhost;DataBase=preguntadORT;Trusted_Connection=True;";

    public static List<Categoria> ObtenerCategorias(){
        
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            List <Categoria> categorias = new List <Categoria>();
            string sql = "SELECT * FROM Categorias";
            categorias = db.Query<Categoria>(sql).ToList();
        }
        return categorias;
    }

    public static List<Dificultad> ObtenerDificultades(){
        
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            List <Dificultad> dificultades = new List <Dificultad>();
            string sql = "SELECT * FROM Dificultades";
            dificultades = db.Query<Dificultad>(sql).ToList();
        }
        return dificultades;
    }

    public static List<Pregunta> ObtenerPreguntas(int dificultad, int categoria){
        List <Pregunta> preguntas = new List <Pregunta>();
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            if((dificultad == -1 && categoria != -1)|| (dificultad==-1 && categoria == -1))
            {
            string sql = "SELECT * FROM Preguntas ";
            preguntas = db.Query<Pregunta>(sql).ToList();
            }
            else if (dificultad != -1 && categoria == -1){
            string sql = "SELECT * FROM Preguntas WHERE IdDificultad = @pdificultad";
            preguntas = db.QueryFirstOrDefault<Pregunta>(sql, new {pdificultad = dificultad AND pcategoria = categoria});
            }
            else{
            string sql = "SELECT * FROM Preguntas WHERE IdDificultad = @pdificultad AND IdCategoria = @pcategoria";
            preguntas = db.QueryFirstOrDefault<Pregunta>(sql, new {pdificultad = dificultad AND pcategoria = categoria});
            }
        }
        return preguntas;
    }

    public static List<Respuesta> ObtenerRespuestas(List<Pregunta> preguntas){
        List <Respuesta> respuestas = new List <Respuesta>();
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            foreach (Pregunta pregunta in preguntas)
        {
            string sql = "SELECT * FROM Respuestas WHERE IdPregunta = " + pregunta.IdPregunta;
            respuestas = db.Query<Respuesta>(sql).ToList();
        }
        }
        return respuestas;
    }
}