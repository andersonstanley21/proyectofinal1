using Proyecto_LaboratorioJARAF.Models;
using Proyecto_LaboratorioJARAF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_LaboratorioJARAF.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        ClsRPaciente clsRPaciente = new ClsRPaciente();
        // GET: Paciente
        public ActionResult Index2()
        {
            var listado = clsRPaciente.ListOfDataOfTablePaciente();

            return View(listado);
        }

        // Guardar
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Paciente paciente)
        {
            clsRPaciente.Create(paciente);

            return RedirectToAction("Index2");
        }

        // Eliminar
        

    }
}