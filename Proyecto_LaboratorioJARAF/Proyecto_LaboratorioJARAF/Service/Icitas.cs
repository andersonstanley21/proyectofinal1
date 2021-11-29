using Proyecto_LaboratorioJARAF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaboratorioJARAF.Service
{
    interface Icitas
    {
        void Create(CITAS citas);
        void Update(CITAS citas);
        CITAS buscar(int id);
        List<CITAS> UnionDeObjetos();
    }
}
