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
using actualizarclientess;
namespace Clientes
{
    public partial class RegistroCL : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        public RegistroCL()
        {
            InitializeComponent();
        }
        void mantenimiento(String accion)
        {
            objent.codigo2 = txtcodigo.Text;
            objent.nombres = txtnombres.Text;
            objent.cedula = txtcedula.Text;
            objent.telefono = txttelefono.Text;
            objent.cbancaria = txtcbancaria.Text;
            objent.fnacimiento = txtfnacimiento.Text;
            objent.direccion = txtdireccion.Text;
            objent.estado = txtestado.Text;
            objent.servicios = txtservicios.Text;
            objent.accion2 = accion;
            String men = objneg.N_mantenimiento_clientes(objent);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar aL cliente " + txtnombres.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           actualizacion formulario = new actualizacion();
            formulario.ShowDialog();
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar aL cliente " + txtnombres.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
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

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcbancaria_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtcbancaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla especial
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Verificar si la longitud de la cadena en la caja de texto es mayor que 10
            if (txtcbancaria.Text.Length >= 10 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
