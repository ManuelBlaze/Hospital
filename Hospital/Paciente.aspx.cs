using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaEntidad;
using CapaRegNegocio;
using System.Data;

namespace Hospital
{
    public partial class Paciente : System.Web.UI.Page
    {
        CRegPaciente oregpaciente = new CRegPaciente();
        CEntPaciente oentpaciente = new CEntPaciente();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdConsultarPac_Click(object sender, EventArgs e)
        {
            if (txtIDPac.Text == "")
            {
                lblConfirmarPac.Text = "Ingresa el ID de paciente para consultar";
                txtIDPac.Focus();
            } else
            {
                DataSet ds = new DataSet();
                oentpaciente.Id_paciente1 = txtIDPac.Text;
                ds = oregpaciente.consultarPaciente(oentpaciente);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    lblConfirmarPac.Text = "Usuario no registrado";
                    txtNomPac.Focus();
                } else
                {
                    txtNomPac.Text = ds.Tables[0].Rows[0]["nom_paciente"].ToString();
                    txtTipoIDPac.Text = ds.Tables[0].Rows[0]["tip_doc"].ToString();
                    txtDireccionPac.Text = ds.Tables[0].Rows[0]["dir_paciente"].ToString();
                    txtTelPac.Text = ds.Tables[0].Rows[0]["tel_paciente"].ToString();
                    txtCelPac.Text = ds.Tables[0].Rows[0]["cel_paciente"].ToString();
                    lblConfirmarPac.Text = "---------";
                }
                
            }
        }

        protected void cmdIngresarPac_Click(object sender, EventArgs e)
        {
            oentpaciente.Id_paciente1 = txtIDPac.Text;
            oentpaciente.Nom_paciente = txtNomPac.Text;
            oentpaciente.Tip_doc = txtTipoIDPac.Text;
            oentpaciente.Dir_paciente = txtDireccionPac.Text;
            oentpaciente.Tel_paciente = txtTelPac.Text;
            oentpaciente.Cel_paciente = txtCelPac.Text;

            if (oregpaciente.guardarPaciente(oentpaciente))
            {
                lblConfirmarPac.Text = "Registro Guardado Exitosamente";
                reiniciarForm();
            }
            else
            {
                lblConfirmarPac.Text = "Error al Guardar el Registro";
            }
        }

        public void reiniciarForm ()
        {
            txtIDPac.Text = "";
            txtNomPac.Text = "";
            txtTipoIDPac.Text = "";
            txtDireccionPac.Text = "";
            txtTelPac.Text = "";
            txtCelPac.Text = "";
        }
    }
}