public class Categoria{
    public string Nombre {get;set;}
    public string Foto {get;set;}
    public int IdCategoria{get;set;}

public Categoria(){

    }
public Categoria (string pNombre, int pIdCategoria, string pFoto)
    {
        Nombre = pNombre;
        IdCategoria = pIdCategoria;
        Foto = pFoto;
    }
}