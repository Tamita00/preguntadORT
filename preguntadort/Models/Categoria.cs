public class Categorias{
    public static string Nombre {get;set;}
    public static string Foto {get;set;}
    public static int IdCategoria{get;set;}
}

public Categorias (int pNombre, int pIdCategoria, string pFoto)
    {
        Nombre = pNombre;
        IdCategoria = pIdCategoria;
        Foto = pFoto;
    }