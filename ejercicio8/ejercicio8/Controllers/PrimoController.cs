using Microsoft.AspNetCore.Mvc;

namespace ejercicio8.Controllers
{
    public class PrimoController : Controller
    {
        public IActionResult Verificar(int numero)
        {
            bool esPrimo = EsPrimo(numero);
            ViewBag.Mensaje = esPrimo ? $"{numero} es primo" : $"{numero} no es primo";
            return View();
        }

        private bool EsPrimo(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
