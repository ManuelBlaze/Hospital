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
    public class CRegMedico
    {
        CDatMedico odatmedico = new CDatMedico();

        public bool guardarMedico(CEntMedico oentmedico)
        {
            return odatmedico.guardarMedico(oentmedico);
        }

        public bool anularMedico(CEntMedico oentmedico)
        {
            return odatmedico.anularMedico(oentmedico);
        }

        public DataSet consultarMedico(CEntMedico oentmedico)
        {
            return odatmedico.consultarMedico(oentmedico);
        }
    }
}
