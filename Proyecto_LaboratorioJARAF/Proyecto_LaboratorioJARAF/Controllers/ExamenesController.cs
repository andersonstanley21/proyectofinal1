using Proyecto_LaboratorioJARAF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_LaboratorioJARAF.Controllers
{
    public class ExamenesController : Controller
    {
        // GET: Examenes

        ClsExamenes clsExamenes = new ClsExamenes();
        public ActionResult EXAMENES()
        {

            var list = clsExamenes.ListOfDataOfTableEXAMENES();

            return View(list);


            return View();
        }
    }
}