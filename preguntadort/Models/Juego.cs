namespace preguntadORT;
public static class Juego{

    public static string _username;
    public static int _puntajeActual;
    public static int _cantidadPreguntasCorrectas;
    private static List<Pregunta> _preguntas;
    private static List<Respuesta> _respuestas;

    
    public static void InicializarJuego(){
        _username = null;
        _puntajeActual = 0;
        _cantidadPreguntasCorrectas = 0;
    }

    public static List<Categoria> ObtenerCategorias()
    {
        return BD.ObtenerCategorias();
    }

    public static List<Dificultad> ObtenerDificultades()
    {
        return BD.ObtenerDificultades();
    }

    public static void CargarPartida(string username, int dificultad, int categoria){

        _preguntas = BD.ObtenerPreguntas(dificultad, categoria);
        _respuestas = BD.ObtenerRespuestas(_preguntas);
        _username = username;
    }

    public static Pregunta ObtenerProximaPregunta(){
        int numRandom = funciones.Rndm(0, _preguntas.Count);
        return _preguntas[numRandom];
    }

    public static List<Respuesta> ObtenerProximasRespuestas(int idPregunta){

        List<Respuesta> _respuestasProximas = new List <Respuesta>();
        foreach (Respuesta respuesta in _respuestas)
        {
            if(respuesta.IdPregunta == idPregunta){
                _respuestasProximas.Add(respuesta);
            }
        }
        return _respuestasProximas;
    }

    public static bool VerificarRespuesta(int idPregunta, int idRespuesta){
        bool correcta = false;
        foreach (Respuesta respuesta in _respuestas)
        {
        if(respuesta.IdRespuesta == idRespuesta){
            correcta = true;
            _puntajeActual += 5;
            _cantidadPreguntasCorrectas += 1;
            while (_preguntas.Count()>0)
            {
            _preguntas.RemoveAt(0);                
            }
        }
        }
        return correcta;
    }

}