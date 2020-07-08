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
    public class CDatCitas
    {
        CConexion oConexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardarCita(CEntCitas ocitas)
        {
            try //Desactiva la recoleccion automatica de errores
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_guardar_citas";

                //Declarar todas las variables del proc almacenado
                ocmd.Parameters.Add("@pcod_cita", ocitas.Cod_cita);
                ocmd.Parameters.Add("@pfecha", ocitas.Fecha);
                ocmd.Parameters.Add("@phora", ocitas.Hora);
                ocmd.Parameters.Add("@pId_paciente", ocitas.Id_paciente1);
                ocmd.Parameters.Add("@pid_medico", ocitas.Id_medico);
                ocmd.Parameters.Add("@pvalor", ocitas.Valor);
                ocmd.Parameters.Add("@pdiagnostico", ocitas.Diagnostico);
                ocmd.Parameters.Add("@pNom_acompanante", ocitas.Nom_acompanante1);

                //Consulta que no contiene SELECT
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); //solo se ejecuta si hay error
            }

        }

        public bool anularCita(CEntCitas ocitas)
        {
            try
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_anular_citas";

                //Declarar todas las variables del proc almacenado
                ocmd.Parameters.Add("@pcod_cita", ocitas.Cod_cita);

                //Consulta que no contiene SELECT
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); //solo se ejecuta si hay error
            }
        }

        public DataSet consultarCita(CEntCitas ocitas)
        {

            try
            {
                ocmd.Connection = oConexion.conectar("bdHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_consultar_citas";

                //Declarar todas las variables del proc almacenado
                ocmd.Parameters.Add("@pcod_cita", ocitas.Cod_cita);

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
