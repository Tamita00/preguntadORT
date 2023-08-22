using System.Data.SqlClient;
using Dapper;
namespace preguntadORT;

public class BD{
    private static string ConnectionString = @"Server=localhost;DataBase=PreguntadOrt;Trusted_Connection=True;";

    public static List<Categoria> ObtenerCategorias(){
        List <Categoria> categorias = new List <Categoria>();
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Categorias";
            categorias = db.Query<Categoria>(sql).ToList();
        }
        return categorias;
    }

    public static List<Dificultad> ObtenerDificultades(){
        List <Dificultad> dificultades = new List <Dificultad>();
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Dificultad";
            dificultades = db.Query<Dificultad>(sql).ToList();
        }
        return dificultades;
    }
    public static List<Pregunta> ObtenerPreguntas(int dificultad, int categoria)
{
    List<Pregunta> preguntas = new List<Pregunta>();
    
    using (SqlConnection db = new SqlConnection(ConnectionString))
    {
        if ((dificultad == -1 && categoria != -1) || (dificultad == -1 && categoria == -1))
        {
            string sql = "SELECT * FROM Preguntas";
            preguntas = db.Query<Pregunta>(sql).ToList();
        }
        else if (dificultad != -1 && categoria == -1)
        {
            string sql = "SELECT * FROM Preguntas WHERE IdDificultad = @pdificultad";
            preguntas = db.Query<Pregunta>(sql, new { pdificultad = dificultad }).ToList();
        }
        else
        {
            string sql = "SELECT * FROM Preguntas WHERE IdDificultad = @pdificultad AND IdCategoria = @pcategoria";
            preguntas = db.Query<Pregunta>(sql, new { pdificultad = dificultad, pcategoria = categoria }).ToList();
        }
    }
    
    return preguntas;
}

    public static List<Respuesta> ObtenerRespuestas(List<Pregunta> preguntas)
{
    List<Respuesta> respuestas = new List<Respuesta>();
    using (SqlConnection db = new SqlConnection(ConnectionString))
    {
        foreach (Pregunta preg in preguntas)
        {
            string sql = "SELECT * FROM Respuestas WHERE IdPregunta = @idPregunta";
            List<Respuesta> respuestasPregunta = db.Query<Respuesta>(sql, new { idPregunta = preg.IdPregunta }).ToList();
            respuestas.AddRange(respuestasPregunta);
        }
    }
    return respuestas;
}
}