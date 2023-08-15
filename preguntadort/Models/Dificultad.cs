public class Dificultad{
    public string Nombre {get;set;}
    public int IdDificultad {get;set;}

public Dificultad(){

    }
public Dificultad (string pNombre, int pIdDificultad)
    {
        Nombre = pNombre;
        IdDificultad = pIdDificultad;
    }
}