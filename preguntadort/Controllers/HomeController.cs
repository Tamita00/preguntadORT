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
        ViewBag.username = Juego._username;
        ViewBag.puntajeActual = Juego._puntajeActual;
        ViewBag.pregunta = Juego.ObtenerProximaPregunta();
        if(Juego.ObtenerProximaPregunta() == null) return View("Fin");
        ViewBag.respuestas = Juego.ObtenerProximasRespuestas(ViewBag.pregunta.IdPregunta);
        return View("Jugar");
    }

    [HttpPost]
    public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta){
        ViewBag.correcta = Juego.VerificarRespuesta(idPregunta, idRespuesta);
        ViewBag.respuestaCorrecta = "";
        return View("Respuesta");
    }
}
