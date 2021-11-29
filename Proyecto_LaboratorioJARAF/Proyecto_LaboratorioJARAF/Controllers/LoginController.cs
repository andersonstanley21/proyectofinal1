using Proyecto_LaboratorioJARAF.Models;
using Proyecto_LaboratorioJARAF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_LaboratorioJARAF.Controllers
{
    public class LoginController : Controller
    {
        

        private LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities();
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Inicio()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(USUARIO usuario)
        {
            try
            {

                using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
                {
                    var us = conexion.USUARIO.Where(x => x.Usuario1.Trim() == usuario.Usuario1 && x.Contraseña == usuario.Contraseña.Trim()).FirstOrDefault();
                    if (us == null)
                    {

                        return View();
                    }
                    Session["us"] = us;

                }
                return Redirect("/Login/Inicio");

            }

            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;


                return View();
            }




        }

       
        





    }
}