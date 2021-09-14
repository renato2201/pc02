using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace practica02.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Formulario(){
            return View();
        }
        [HttpPost]
        public IActionResult Formulario(string nombres, string apepa, string apema, string tipo, string desc, string tel, string dist, string dir){
            Console.WriteLine(nombres);
            Console.WriteLine(apepa);
            Console.WriteLine(apema);
            Console.WriteLine(tipo);
            Console.WriteLine(desc);
            Console.WriteLine(tel);
            Console.WriteLine(dist);
            Console.WriteLine(dir); 
            return RedirectToAction("Confirmacion");
        }
        public IActionResult Confirmacion(){
            return View();
        }
    }
}

    