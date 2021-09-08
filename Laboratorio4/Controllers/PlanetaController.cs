using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4.Handlers; //Codigo necesario para acceder a handler y model.
using Laboratorio4.Models;


namespace Laboratorio4.Controllers
{
    public class PlanetaController : Controller
    {

        public ActionResult listadoDePlanetas()
        {
            PlanetaHandler accesoDatos = new PlanetaHandler();
            ViewBag.planeta = accesoDatos.obtenerTodoslosPlanetas();
            return View();
        }
    }
}