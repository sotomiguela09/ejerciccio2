using Microsoft.AspNetCore.Mvc;

namespace ejercicio_3.Controllers
{
    
    
        public class NumeroController : Controller
        {
            public ActionResult Signo(int numero)
            {
                string resultado;
                if (numero > 0) resultado = "El número es positivo.";
                else if (numero < 0) resultado = "El número es negativo.";
                else resultado = "El número es cero.";

                ViewBag.Numero = numero;
                ViewBag.Resultado = resultado;
                return View();
            }

            public ActionResult Tabla(int numero)
            {
                ViewBag.Numero = numero;
                return View();
            }
        }
    }
       
        
    

