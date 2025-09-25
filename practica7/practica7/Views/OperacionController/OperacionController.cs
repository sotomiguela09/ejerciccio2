using Microsoft.AspNetCore.Mvc;

namespace practica7.Views.OperacionController
{
    public class OperacionController : Controller
    {
        public IActionResult Sumar(int num1, int num2)
        {
            ViewBag.Resultado = num1 + num2;
            return View("Resultado");
        }

        public IActionResult Restar(int num1, int num2)
        {
            ViewBag.Resultado = num1 - num2;
            return View("Resultado");
        }

        public IActionResult Multiplicar(int num1, int num2)
        {
            ViewBag.Resultado = num1 * num2;
            return View("Resultado");
        }

        public IActionResult Residuo(int num1, int num2)
        {
            ViewBag.Resultado = num1 % num2;
            return View("Resultado");



        }
    }
}
        
    

