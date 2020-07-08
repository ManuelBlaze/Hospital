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
    public class CDatMedico
    {
        CConexion oConexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardarMedico(CEntMedico omedico)
        {
            try //Desactiva la recoleccion automatica de errores
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_guardar_medico";

                //Declarar todas las variables del proc almacenado
                ocmd.Parameters.Add("@pid_medico", omedico.Id_medico);
                ocmd.Parameters.Add("@pnom_medico", omedico.Nom_medico);
                ocmd.Parameters.Add("@pespecialidad", omedico.Especialidad);
                ocmd.Parameters.Add("@ptel_medico", omedico.Tel_medico);


                //Consulta que no contiene SELECT
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); //solo se ejecuta si hay error
            }

        }

        public bool anularMedico(CEntMedico omedico)
        {
            try
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_anular_medico";

                //Declarar todas las variables del proc almacenado
                ocmd.Parameters.Add("@pid_medico", omedico.Id_medico);

                //Consulta que no contiene SELECT
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); //solo se ejecuta si hay error
            }
        }

        public DataSet consultarMedico(CEntMedico omedico)
        {

            try
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_consultar_medico";

                //Declarar todas las variables del proc almacenado
                ocmd.Parameters.Add("@pid_medico", omedico.Id_medico);

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
