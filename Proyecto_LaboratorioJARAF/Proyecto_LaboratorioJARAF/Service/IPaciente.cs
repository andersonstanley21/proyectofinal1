using Proyecto_LaboratorioJARAF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_LaboratorioJARAF.Service
{
    interface IPaciente
    {
        void Create(Paciente paciente);

       
        void Update(Paciente paciente);
        List<Paciente> ListOfDataOfTablePaciente();
    }
}
