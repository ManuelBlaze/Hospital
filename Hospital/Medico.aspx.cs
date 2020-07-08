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
    public partial class Medico : System.Web.UI.Page
    {
        CRegMedico oregmedico = new CRegMedico();
        CEntMedico oentmedico = new CEntMedico();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdConsultarMed_Click(object sender, EventArgs e)
        {
            if(txtIDMed.Text == "")
            {
                lblConfirmarMed.Text = "El ID es obligatorio para consultar";
                txtIDMed.Focus();
            } else
            {
                DataSet ds = new DataSet();
                oentmedico.Id_medico = txtIDMed.Text;
                ds = oregmedico.consultarMedico(oentmedico);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    lblConfirmarMed.Text = "Médico no registrado";
                    txtNomMed.Focus();
                } else
                {
                    txtNomMed.Text = ds.Tables[0].Rows[0]["nom_medico"].ToString();
                    txtEspecialidadMed.Text = ds.Tables[0].Rows[0]["especialidad"].ToString();
                    txtTelMed.Text = ds.Tables[0].Rows[0]["tel_medico"].ToString();

                    lblConfirmarMed.Text = "----------";
                }
            }
        }

        protected void cmdIngresarMed_Click(object sender, EventArgs e)
        {
            oentmedico.Id_medico = txtIDMed.Text;
            oentmedico.Nom_medico = txtNomMed.Text;
            oentmedico.Especialidad = txtEspecialidadMed.Text;
            oentmedico.Tel_medico = txtTelMed.Text;

            if (oregmedico.guardarMedico(oentmedico))
            {
                lblConfirmarMed.Text = "Registro Guardado Exitosamente";
                reiniciarForm();
            }
            else
            {
                lblConfirmarMed.Text = "Error al Guardar el Registro";
            }
        }

        public void reiniciarForm()
        {
            txtIDMed.Text = "";
            txtNomMed.Text = "";
            txtEspecialidadMed.Text = "";
            txtTelMed.Text = "";
        }
    }
}