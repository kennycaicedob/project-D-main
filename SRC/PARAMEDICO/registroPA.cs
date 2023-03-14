using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;
namespace PARAMEDICO
{
    public partial class registroPA : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        public registroPA()
        {
            InitializeComponent();
        }
        void mantenimiento(String accion)
        {
            objent.codigo4 = txtcodigo.Text;
            objent.nombres4 = txtnombres.Text;
            objent.cedula4 = txtcedula.Text;
            objent.telefono4 = txttelefono.Text;
            objent.email4 = txtcbancaria.Text;
            objent.fnacimiento4 = txtfnacimiento.Text;
            objent.direccion4 = txtdireccion.Text;
            objent.estado4 = txtestado.Text;
            objent.servicios4 = txtservicios.Text;
            objent.accion4 = accion;
            String men = objneg.N_mantenimiento_paramedico(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtcodigo.Text = "";
            txtcbancaria.Text = "";
            txtcedula.Text = "";
            txtdireccion.Text = "";
            txtestado.Text = "";
            txtfnacimiento.Text = "";
            txtnombres.Text = "";
            txtservicios.Text = "";
            txttelefono.Text = "";


        }
        private void registroPA_Load(object sender, EventArgs e)
        {
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar a " + txtnombres.Text + "?", "Mensaje",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }
    }
}
