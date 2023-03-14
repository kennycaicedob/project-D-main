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
namespace CONDUCTOR
{
    public partial class RegistroCO : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        public RegistroCO()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objent.codigo3 = txtcodigo.Text;
            objent.nombres3 = txtnombres.Text;
            objent.cedula3 = txtcedula.Text;
            objent.telefono3 = txttelefono.Text;
            objent.dialibre3 = txtdialibre.Text;
            objent.fnacimiento3 = txtfnacimiento.Text;
            objent.direccion3 = txtdireccion.Text;
            objent.estado3 = txtestado.Text;
            objent.servicios3 = txtservicios.Text;
            objent.accion3 = accion;
            String men = objneg.N_mantenimiento_conductor(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtcodigo.Text = "";
            txtdialibre.Text = "";
            txtcedula.Text = "";
            txtdireccion.Text = "";
            txtestado.Text = "";
            txtfnacimiento.Text = "";
            txtnombres.Text = "";
            txtservicios.Text = "";
            txttelefono.Text = "";


        }
        private void RegistroCO_Load(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar a " + txtnombres.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcbancaria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfnacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtservicios_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar a " + txtnombres.Text + "?", "Mensaje",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla especial
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Verificar si la longitud de la cadena en la caja de texto es mayor que 10
            if (txtcedula.Text.Length >= 10 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla especial
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Verificar si la longitud de la cadena en la caja de texto es mayor que 10
            if (txttelefono.Text.Length >= 10 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
