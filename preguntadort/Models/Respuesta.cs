public class Respuesta{
    public static int IdRespuesta {get;set;}
    public static int IdPregunta {get;set;}
    public static int opcion {get;set;}
    public static string contenido {get;set;}
    public static bool correcta {get;set;}
    public static string foto {get;set;}
}

public Respuesta (int pIdRespuesta, int pIdPregunta, int popcion, string pcontenido, bool pcorrecta, string pfoto)
    {
        IdRespuesta = pIdRespuesta;
        IdPregunta = pIdPregunta;
        opcion = popcion;
        contenido = pcontenido;
        correcta = pcorrecta;
        foto = pfoto;
    }