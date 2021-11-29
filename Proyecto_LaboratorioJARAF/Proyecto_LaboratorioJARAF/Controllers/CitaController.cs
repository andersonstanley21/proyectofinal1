using Proyecto_LaboratorioJARAF.Models;
using Proyecto_LaboratorioJARAF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_LaboratorioJARAF.Controllers
{
    public class CitaController : Controller
    {
        // GET: Cita

        ClsRCita cls = new ClsRCita();


        public ActionResult CrearCita()
        {
            var union = cls.UnionDeObjetos();

            return View(union);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            CITAS es = new CITAS();
            es.IdCita= Convert.ToInt32(id);
            CITAS estb = cls.buscar(es.IdCita);

            return View(estb);
        }
        [HttpPost]

        public ActionResult Edit(CITAS cita)
        {
            if (cita.IdCita == 0)
            {
                cls.Create(cita);

                return View();
            }
            else
            {
                cls.Update(cita);
                return View();

            }
            return View();

        }


        public ActionResult Update()
        {

            return View();

        }
        public ActionResult Update(CITAS citas)
        {
            
            if (citas.IdCita==0)
            {
                cls.Create(citas);

            }
            else
            {
                cls.Update(citas);

            }
            return RedirectToAction("CitaNueva");

        }

        [HttpPost]
        public ActionResult CitaNueva(CITAS citas)
        {
            cls.Create(citas);

            return RedirectToAction("CrearCita");


        }

        public ActionResult CitaNueva()
        {

            return View();
        }


    
        
    }
}