using Microsoft.AspNetCore.Mvc;

namespace preguntadORT.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("Index");
    }

    public IActionResult ConfigurarJuego(){
        Juego.InicializarJuego();
        ViewBag.categorias = Juego.ObtenerCategorias();
        ViewBag.dificultades = Juego.ObtenerDificultades();
        return View("ConfigurarJuego");
    }

    public IActionResult Comenzar(string username, int dificultad, int categoria){
        Juego.CargarPartida(username, dificultad, categoria);
        return View("Jugar");
    }

    public IActionResult Jugar(){
        ViewBag.pregunta = Juego.ObtenerProximaPregunta()
        if(pregunta.length() == 0) return View("Fin");
        ViewBag.respuestas = Juego.ObtenerProximasRespuestas();
        return View("Jugar");
    }
}
