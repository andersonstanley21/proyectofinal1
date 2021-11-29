using Proyecto_LaboratorioJARAF.Models;
using Proyecto_LaboratorioJARAF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_LaboratorioJARAF.Repository
{
    public class ClsExamenes : IExamenes
    {
        public List<EXAMENES> ListOfDataOfTableEXAMENES()
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {
                List<EXAMENES> Exa = conexion.EXAMENES.ToList();

                return Exa;

            }

        }
    }
}