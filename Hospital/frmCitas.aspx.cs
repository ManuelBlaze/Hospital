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
    public partial class frmCitas : System.Web.UI.Page
    {
        CRegCitas oregcitas = new CRegCitas();
        CEntCitas oentcitas = new CEntCitas();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void confirmarCita_Click(object sender, EventArgs e)
        {
            if (txtCodCita.Text == "")
            {
                lblConfirmar.Text = "El código de cita es Obligatorio";
                txtCodCita.Focus();
            } else
            {
                DataSet ds = new DataSet();
                oentcitas.Cod_cita = txtCodCita.Text;
                ds = oregcitas.consultarCita(oentcitas);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    lblConfirmar.Text = "Cita no asignada";
                    txtFecha.Focus();
                } else
                {
                    txtFecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                    txtHora.Text = ds.Tables[0].Rows[0]["hora"].ToString();
                    txtIdPaciente.Text = ds.Tables[0].Rows[0]["Id_paciente"].ToString();

                    lblBuscarPac.Text = ds.Tables[1].Rows[0]["nom_paciente"].ToString();
                    lblTelPac.Text = ds.Tables[1].Rows[0]["tel_paciente"].ToString();

                    txtIdMedico.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                    lblBuscarMed.Text = ds.Tables[2].Rows[0]["nom_medico"].ToString();
                    lblEspMed.Text = ds.Tables[2].Rows[0]["especialidad"].ToString();

                    txtVlr.Text = ds.Tables[0].Rows[0]["valor"].ToString();
                    txtDiagnostico.Text = ds.Tables[0].Rows[0]["diagnostico"].ToString();
                    txtNomAcomp.Text = ds.Tables[0].Rows[0]["Nom_acompanante"].ToString();

                    lblConfirmar.Text = "---------";
                }
            }
        }

        protected void guardar_Click(object sender, EventArgs e)
        {
            oentcitas.Cod_cita = txtCodCita.Text;
            oentcitas.Fecha = Convert.ToDateTime(txtFecha.Text);
            oentcitas.Hora = Convert.ToDateTime(txtHora.Text);
            oentcitas.Id_paciente1 = txtIdPaciente.Text;
            oentcitas.Id_medico = txtIdMedico.Text;
            oentcitas.Valor = Convert.ToInt32(txtVlr.Text);            
            oentcitas.Diagnostico = txtDiagnostico.Text;
            oentcitas.Nom_acompanante1 = txtNomAcomp.Text;

            if (oregcitas.guardarCita(oentcitas))
            {
                lblConfirmar.Text = "Registro Guardado Exitosamente";
                reiniciarForm();
            } else
            {
                lblConfirmar.Text = "Error al Guardar el Registro";
            }
        }

        public void reiniciarForm()
        {
            txtCodCita.Text = "";
            txtFecha.Text = "";
            txtHora.Text = "";
            txtIdPaciente.Text = "";
            txtIdMedico.Text = "";
            txtVlr.Text = "";
            txtDiagnostico.Text = "";
            txtNomAcomp.Text = "";
        }
    }
}