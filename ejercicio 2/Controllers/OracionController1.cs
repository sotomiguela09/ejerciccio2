using Microsoft.AspNetCore.Mvc;

namespace ejercicio_2.Controllers
{
    public class OracionController1 : Controller
    {
        public ActionResult ContarVocales(string frase)
        {
            int contador = 0;
            if (!string.IsNullOrEmpty(frase))
            {
                string vocales = "aeiou";
                foreach (char c in frase)
                {
                    if (vocales.Contains(c)) contador++;
                }
            }
            ViewBag.Frase = frase;
            ViewBag.TotalVocales = contador;
            return View();
        }
        
          
        }
    }

