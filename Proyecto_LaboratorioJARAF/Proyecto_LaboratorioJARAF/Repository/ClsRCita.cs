using Proyecto_LaboratorioJARAF.Models;
using Proyecto_LaboratorioJARAF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proyecto_LaboratorioJARAF.Repository
{
    public class ClsRCita : Icitas
    {

        LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities();

        public void Create(CITAS citas)
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {
                try
                {
                    CITAS ci = new CITAS();
                    ci.Hora = citas.Hora;
                    ci.Fecha = citas.Fecha;
                    ci.IdExamenes = citas.IdExamenes;
                    ci.IdPaciente = citas.IdPaciente;
                    conexion.CITAS.Add(citas);
                    conexion.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }

        public List<CITAS> UnionDeObjetos()
        {
            var Consulta = conexion.CITAS.Include(p => p.Paciente).Include(e => e.EXAMENES).ToList();
            return Consulta;
        }

        public void Update(CITAS citas)
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {
                CITAS cita = conexion.CITAS.Find(citas.IdCita);
                cita.Hora = citas.Hora;
                cita.Fecha = citas.Fecha;
                cita.IdExamenes = citas.IdExamenes;
                cita.IdPaciente = cita.IdPaciente;
                conexion.SaveChanges();
            }


        }

        public CITAS buscar(int id)
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {


                CITAS es = conexion.CITAS.Find(id);
                return es;

            } 

               
            

        }

    }

}