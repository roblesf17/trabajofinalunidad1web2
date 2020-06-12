using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TrabajoFinal_Unidad1_Web2_Estrella_Robles_Sosa.Models;

namespace TrabajoFinal_Unidad1_Web2_Estrella_Robles_Sosa.Controllers
{
    public class Ejercicio2ListaProductosController : Controller
    {

        //declarando
        public static ArrayList array_tabla_A = new ArrayList();
        public static ArrayList array_tabla_B = new ArrayList();


        // GET: Ejercicio2ListaProductos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ejercicio_02_Lista_Producto(String submitButton)
        {
            //Intanciamos el objeto//
            ClsProducto objpalabra = new ClsProducto();
            //
            //recogemos el valor agregado desde la vista
            objpalabra.palabra = Request.Form["Valor1"];
            //


            //declaramos ViewBag para reproducri en load en la tabla en vista 
            //(estara vacia en primer inicio)
            ViewBag.data_A = array_tabla_A;
            ViewBag.data_B = array_tabla_B;
            //

            //Cada submit tendra un nombre que al hacer clic
            //con los case sabremos cuales seran presionados
            //podriamos llamarle eventos CLICK

            switch (submitButton)
            {
                //Es un button************************************************************
                case "Agregar a Tabla A":

                    array_tabla_A.Add(Request.Form["Valor1"]);

                    ViewBag.data_A = array_tabla_A;
                    return View();
                //**********************************************************************


                //Es un button************************************************************
                case "Agregar a Tabla B":

                    array_tabla_B.Add(Request.Form["Valor1"]);

                    ViewBag.data_B = array_tabla_B;
                    return View();
                //**********************************************************************

                //Es un button************************************************************
                case "Pasar a Tabla B":

                    array_tabla_A.Remove(objpalabra.palabra);
                    ViewBag.data_A = array_tabla_A;

                    array_tabla_B.Add(objpalabra.palabra);
                    ViewBag.data_B = array_tabla_B;

                    return View();
                //**********************************************************************

                //Es un button************************************************************
                case "Pasar a Tabla A":

                    array_tabla_B.Remove(objpalabra.palabra);
                    ViewBag.data_B = array_tabla_B; 

                    array_tabla_A.Add(objpalabra.palabra);
                    ViewBag.data_A = array_tabla_A;

                    return View();
                //**********************************************************************

                //Es un button************************************************************
                case "Pasar Todo a Tabla A":

                    foreach (var list in array_tabla_B)
                    {
                        array_tabla_A.Add(list);
                    }
                    array_tabla_B.Clear();


                    ViewBag.data_B = array_tabla_B;
                    ViewBag.data_A = array_tabla_A;
                    return View();
                //**********************************************************************

                //Es un button************************************************************
                case "Pasar Todo a Tabla B":

                    foreach (var list in array_tabla_A)
                    {
                        array_tabla_B.Add(list);
                    }
                    array_tabla_A.Clear();

                    ViewBag.data_A = array_tabla_A;
                    ViewBag.data_B = array_tabla_B;

                    return View();
                //**********************************************************************
                //Es un button************************************************************
                case "Limpiar Tablas":


                    array_tabla_A.Clear();
                    array_tabla_B.Clear();

                    ViewBag.data_A = array_tabla_A;
                    ViewBag.data_B = array_tabla_B;

                    return View();
                    //**********************************************************************

            }

            return View();
        }
    }
}