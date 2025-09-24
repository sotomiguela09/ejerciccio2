using Microsoft.AspNetCore.Mvc;

namespace ejercicio5.Controllers
{
    public class NumeroController1 : Controller

    {
        public ActionResult Signo(int numero)
        {
            string resultado;
            if (numero > 0) resultado = "El número es positivo.";
            else if (numero < 0) resultado = "El número es negativo.";
            else resultado = "El número es cero.";

            ViewBag.Numero = numero;
            ViewBag.Resultado = resultado;
            {
                return View();
            }
        }
    }
}
