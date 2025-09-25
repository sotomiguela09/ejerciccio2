using Microsoft.AspNetCore.Mvc;

namespace ejercicio_10.Controllers
{
    public class CorreoController : Controller


    {
        public IActionResult Usuario(string email)
        {
            string usuario = email.Split('@')[0];
            ViewBag.Mensaje = $"El usuario del correo {email} es: {usuario}";
            return View();
        }
    }
}