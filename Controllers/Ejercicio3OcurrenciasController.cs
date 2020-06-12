using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal_Unidad1_Web2_Estrella_Robles_Sosa.Models;

namespace TrabajoFinal_Unidad1_Web2_Estrella_Robles_Sosa.Controllers
{
    public class Ejercicio3OcurrenciasController : Controller
    {
        // GET: Ejercicio3Ocurrencias
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuscarPalabras()
        {
            char[] simbolos = { ' ', ',', '.', ':' };

            ClsOcurrencia objPalabras = new ClsOcurrencia();
            objPalabras.texto = Request.Form["texto"];
            objPalabras.palabra = Request.Form["palabra"];

            return View("BuscarPalabras", objPalabras);
        }
    }
}