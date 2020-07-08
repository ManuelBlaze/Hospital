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
    public class CRegCitas
    {
        CDatCitas odatcitas = new CDatCitas();

        public bool guardarCita(CEntCitas oentcitas)
        {
            return odatcitas.guardarCita(oentcitas);
        }

        public bool anularCita(CEntCitas oentcitas)
        {
            return odatcitas.anularCita(oentcitas);
        }

        public DataSet consultarCita(CEntCitas oentcitas)
        {
            return odatcitas.consultarCita(oentcitas);
        }
    }
}
