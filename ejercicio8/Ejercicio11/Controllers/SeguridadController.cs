using Microsoft.AspNetCore.Mvc;

namespace Ejercicio11.Controllers{
    using System.Text.RegularExpressions;

    public class SeguridadController : Controller
    {
     



        
public IActionResult ClaveFuerte(string clave)
        {
            bool esFuerte = clave.Length >= 8 &&
                            Regex.IsMatch(clave, "[A-Z]") &&
                            Regex.IsMatch(clave, "[a-z]") &&
                            Regex.IsMatch(clave, "[0-9]");

            ViewBag.Mensaje = esFuerte ? "La clave es segura ✅" : "La clave NO es segura ❌";
            return View();

        }
    }
}

            
