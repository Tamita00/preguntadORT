public class Respuesta{
    public int IdRespuesta {get;set;}
    public int IdPregunta {get;set;}
    public int opcion {get;set;}
    public string contenido {get;set;}
    public bool correcta {get;set;}
    public string foto {get;set;}

    public Respuesta(){

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
}