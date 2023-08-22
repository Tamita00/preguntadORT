public class Pregunta {
    public int IdPregunta {get;set;}
    public int IdCategoria {get;set;}
    public int IdDificultad {get;set;}
    public string Enunciado {get;set;}
    public string foto {get;set;}

public Pregunta(){

    }

public Pregunta (int pIdPregunta, int pIdCategoria, int pIdDificultad, string penunciado, string pfoto)
    {
        IdPregunta = pIdPregunta;
        IdCategoria = pIdCategoria;
        IdDificultad = pIdDificultad;
        Enunciado = penunciado;
        foto = pfoto;
    }
}