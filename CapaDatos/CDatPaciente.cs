using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using System.Data.Odbc;

namespace CapaDatos
{
    public class CDatPaciente
    {
        CConexion oConexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardarPaciente(CEntPaciente opaciente)
        {
            try //Desactiva la recoleccion automatica de errores
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_guardar_paciente";

                //Declarar todas las variables del proc almacenado
                ocmd.Parameters.Add("@pId_paciente", opaciente.Id_paciente1);
                ocmd.Parameters.Add("@ptip_doc", opaciente.Tip_doc);
                ocmd.Parameters.Add("@pnom_paciente", opaciente.Nom_paciente);
                ocmd.Parameters.Add("@pdir_paciente", opaciente.Dir_paciente);
                ocmd.Parameters.Add("@ptel_paciente", opaciente.Tel_paciente);
                ocmd.Parameters.Add("@pcel_paciente", opaciente.Cel_paciente);


                //Consulta que no contiene SELECT
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); //solo se ejecuta si hay error
            }

        }

        public bool anularPaciente(CEntPaciente opaciente)
        {
            try
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_anular_paciente";

                //Declarar todas las variables del proc almacenado
                ocmd.Parameters.Add("@pId_paciente", opaciente.Id_paciente1);

                //Consulta que no contiene SELECT
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); //solo se ejecuta si hay error
            }
        }

        public DataSet consultarPaciente(CEntPaciente opaciente)
        {

            try
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_consultar_paciente";

                //Declarar todas las variables del proc almacenado
                ocmd.Parameters.Add("@pId_paciente", opaciente.Id_paciente1);

                SqlDataAdapter da = new SqlDataAdapter(ocmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); //solo se ejecuta si hay error
            }

        }

    }
}
