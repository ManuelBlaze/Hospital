using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaRegNegocio
{
    public class CRegPaciente
    {
        CDatPaciente odatpaciente = new CDatPaciente();

        public bool guardarPaciente(CEntPaciente oentpaciente)
        {
            return odatpaciente.guardarPaciente(oentpaciente);
        }

        public bool anularPaciente(CEntPaciente oentpaciente)
        {
            return odatpaciente.anularPaciente(oentpaciente);
        }

        public DataSet consultarPaciente(CEntPaciente oentpaciente)
        {
            return odatpaciente.consultarPaciente(oentpaciente);
        }
    }
}
