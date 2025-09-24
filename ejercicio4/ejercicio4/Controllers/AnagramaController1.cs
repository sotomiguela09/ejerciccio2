using Microsoft.AspNetCore.Mvc;

namespace ejercicio4.Controllers
{
    public class AnagramaController1 : Controller
    {
        public ActionResult Verificar (string texto1, string texto2)
        {
            bool esAnagrama = false;

            if (!string.IsNullOrEmpty(texto1) && !string.IsNullOrEmpty(texto2))
            {
                string t1 = new string(texto1.ToLower().Where(c => c != ' ').ToArray());
                string t2 = new string(texto2.ToLower().Where(c => c != ' ').ToArray());

                esAnagrama = t1.OrderBy(c => c).SequenceEqual(t2.OrderBy(c => c));
            }

            ViewBag.Texto1 = texto1;
            ViewBag.Texto2 = texto2;
            ViewBag.Resultado = esAnagrama ? "Son anagramas" : "No son anagramas";

            return View();
        }
    }
}

