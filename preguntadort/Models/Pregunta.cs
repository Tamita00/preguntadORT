public class Pregunta {
    public static int IdPregunta {get;set;}
    public static int IdCategoria {get;set;}
    public static int IdDificultad {get;set;}
    public static string enunciado {get;set;}
    public static string foto {get;set;}
}

public Pregunta (int pIdPregunta, int pIdCategoria, int pIdDificultad, string penunciado, string pfoto)
    {
        IdPregunta = pIdPregunta;
        IdCategoria = pIdCategoria;
        IdDificultad = pIdDificultad;
        enunciado = penunciado;
        foto = pfoto;
    }