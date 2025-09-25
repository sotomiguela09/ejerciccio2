using Microsoft.AspNetCore.Mvc;

namespace ejercicio9.Controllers
{
    public class FechaController : Controller
    {
 
            public IActionResult DiaSemana(DateTime fecha)
            {
                string dia = fecha.ToString("dddd");
                ViewBag.Mensaje = $"La fecha {fecha.ToShortDateString()} corresponde a {dia}.";
                return View();
            }
        }
    }


