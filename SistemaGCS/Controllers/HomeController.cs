using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaGCS.Models;
using System.Web.Mvc;

namespace SistemaGCS.Controllers
{
    public class HomeController : Controller
    {
        private Proyecto objProyecto = new Proyecto();

        private Metodologia objMeto = new Metodologia();
        private Solicitud_Cambios objSC = new Solicitud_Cambios();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.ProyectosNuevos = objProyecto.ContarProyectosPorEstado("Nuevo");
            ViewBag.ProyectosEnProgreso = objProyecto.ContarProyectosPorEstado("En Progreso");
            ViewBag.ProyectosTerminados = objProyecto.ContarProyectosPorEstado("Terminado");

            return View();
        }
    }
}