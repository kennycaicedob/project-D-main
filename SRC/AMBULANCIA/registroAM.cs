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
namespace AMBULANCIA
{
    public partial class registroAM : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        public registroAM()
        {
            InitializeComponent();
        }
        void mantenimiento(String accion)
        {
            objent.codigo = txtcodigo.Text;
            objent.marca = txtmarca.Text;
            objent.modelo = txtmodelo.Text;
            objent.placa = txtplaca.Text;
            objent.accion = accion;
            String men = objneg.N_mantenimiento_carros(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtcodigo.Text = "";
            txtmarca.Text = "";
            txtmodelo.Text = "";
            txtplaca.Text = "";
            
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar la ambulancia con placa " + txtplaca.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
