using Microsoft.AspNetCore.Mvc;

namespace ejercicio6.Controllers
{
    public class TemperaturaController1 : Controller
    {

 
 
        [HttpGet]
        public IActionResult Convertir()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Convertir(double fahrenheit)
        {
            // Fórmula de conversión
            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            // Redondeo opcional
            celsius = Math.Round(celsius, 2);

            // Pasar los valores a la vista
            ViewBag.Fahrenheit = fahrenheit;
            ViewBag.Celsius = celsius;

            return View();
        }
    }
}




