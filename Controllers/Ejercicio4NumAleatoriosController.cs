using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TrabajoFinal_Unidad1_Web2_Estrella_Robles_Sosa.Models;


namespace TrabajoFinal_Unidad1_Web2_Estrella_Robles_Sosa.Controllers
{
    public class Ejercicio4NumAleatoriosController : Controller
    {
        // GET: Ejercicio4NumAleatorios
        public ActionResult Index()
        {
            return View();
        }

        List<ClsNumero> objLista = new List<ClsNumero>();

        int mayor = -99999;
        int menor = 999999;
        int suma = 0;
        double promedio = 0;
        int contador_temporal = 0;

        public ActionResult Ejercicio_04_Numeros_Aleatorios()
        {
            Random rnd = new Random();

            int temporal_cantidad = Convert.ToInt32(Request.Form["Valor1"]);

            for (int i = 0; i < temporal_cantidad; i++)
            {
                //instancia para el objeto 1
                ClsNumero obj_numero = new ClsNumero();
                //instanciar atributos de la clase para ese objeto

                obj_numero.numero = Convert.ToString(rnd.Next(1000));
                //pasar el objeto a la lista

                ///HALLAR EL MAYOR y MENOR DE N
                //if (temporal_cantidad == 0)
                //{
                //    mayor = Convert.ToInt32( obj_numero.numero);
                //    menor = 10000000;
                //}

                if (Convert.ToInt32(obj_numero.numero) > mayor)
                {
                    mayor = Convert.ToInt32(obj_numero.numero);
                }

                if (Convert.ToInt32(obj_numero.numero) < menor)
                {
                    menor = Convert.ToInt32(obj_numero.numero);
                }

                ///HALLAR SUMA
                suma = suma + Convert.ToInt32(obj_numero.numero);
                contador_temporal = i;

                objLista.Add(obj_numero);
            }

            promedio = Convert.ToDouble(suma) / Convert.ToDouble(contador_temporal + 1);

            ViewBag.mayor = Convert.ToString(mayor);
            ViewBag.menor = Convert.ToString(menor);
            ViewBag.suma = Convert.ToString(suma);
            ViewBag.promedio = Convert.ToString(promedio);

            return View(objLista);
        }
    }
}