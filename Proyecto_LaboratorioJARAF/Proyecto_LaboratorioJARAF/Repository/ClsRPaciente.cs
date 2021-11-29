using Proyecto_LaboratorioJARAF.Models;
using Proyecto_LaboratorioJARAF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_LaboratorioJARAF.Repository
{
    public class ClsRPaciente : IPaciente
    {
        public void Create(Paciente paciente)
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {
                try
                {
                    Paciente pa = new Paciente();
                    pa.Nombre = paciente.Nombre;
                    pa.Apellido = paciente.Apellido;
                    pa.Edad = paciente.Edad;
                    pa.Direccion = paciente.Direccion;
                    pa.telefono = paciente.telefono;

                    conexion.Paciente.Add(paciente);
                    conexion.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }

       

        public List<Paciente> ListOfDataOfTablePaciente()
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {
                List<Paciente> Registros = conexion.Paciente.ToList(); // = Selcet * from paciente
                return Registros;
            }


        }

        public void Update(Paciente paciente)
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {
                Paciente us = conexion.Paciente.Find(paciente.IdPaciente);
                us.Nombre = paciente.Nombre;
                us.Apellido = paciente.Apellido;
                us.Edad = paciente.Edad;
                us.Direccion = paciente.Direccion;
                us.telefono = paciente.telefono;


                conexion.SaveChanges();
            }
        }
    }
}