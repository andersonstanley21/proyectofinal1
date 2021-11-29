using Proyecto_LaboratorioJARAF.Models;
using Proyecto_LaboratorioJARAF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_LaboratorioJARAF.Repository
{
    public class ClsRLogin : ILogin
    {
        public void Create(USUARIO usuario)
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {
                try
                {
                    conexion.USUARIO.Add(usuario);
                    conexion.SaveChanges();
                }
                catch (Exception ex)
                {

                }
            }
        }

        internal static object ListaRegistro()
        {
            throw new NotImplementedException();
        }

        public void Delete(USUARIO usuario)
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {
                usuario = conexion.USUARIO.Find(usuario.IdUsuario);
                conexion.USUARIO.Remove(usuario); //Remove = Eliminar
                conexion.SaveChanges();
            }
        }

        public void Update(USUARIO usuario)
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {
                USUARIO us = conexion.USUARIO.Find(usuario.IdUsuario);
                us.Usuario1 = usuario.Usuario1;
                us.Contraseña = usuario.Contraseña;
                conexion.SaveChanges();
            }
        }

        public List<USUARIO> ListaRegistros()
        {
            using (LABORATORIO_CLINICO_JARAF2Entities conexion = new LABORATORIO_CLINICO_JARAF2Entities())
            {
                List<USUARIO> Registros = conexion.USUARIO.ToList(); // = Selcet * from estudiante
                return Registros;
            }
        }
    }
}