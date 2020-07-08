using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEntPaciente
    {
        private String Id_paciente;
        private String tip_doc;
        private String nom_paciente;
        private String dir_paciente;
        private String tel_paciente;
        private String cel_paciente;

        //Encapsulamiento
        public string Id_paciente1 { get => Id_paciente; set => Id_paciente = value; }
        public string Tip_doc { get => tip_doc; set => tip_doc = value; }
        public string Nom_paciente { get => nom_paciente; set => nom_paciente = value; }
        public string Dir_paciente { get => dir_paciente; set => dir_paciente = value; }
        public string Tel_paciente { get => tel_paciente; set => tel_paciente = value; }
        public string Cel_paciente { get => cel_paciente; set => cel_paciente = value; }
    }
}
