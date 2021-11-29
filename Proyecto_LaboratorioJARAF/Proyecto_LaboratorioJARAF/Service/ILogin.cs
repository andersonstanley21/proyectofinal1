using Proyecto_LaboratorioJARAF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaboratorioJARAF.Service
{
    interface ILogin
    {
        
        
            void Create(USUARIO usuario);

            void Delete(USUARIO usuario); // Elimina el usuario.

            void Update(USUARIO usuario); // Actualiza los datos del usuario.

            List<USUARIO> ListaRegistros();
        
    }
}
