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
namespace actualizarclientess
{
    public partial class actualizacion : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        public actualizacion()
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
            dataGridView1.DataSource = objneg.N_listar_clientes();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actualizacion_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_clientes();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + txtnombres.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + txtnombres.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                objent.cedula = txtbuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_clientes(objent);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objneg.N_listar_clientes();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtcodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtnombres.Text = dataGridView1[1, fila].Value.ToString();
            txtcedula.Text = dataGridView1[2, fila].Value.ToString();
            txttelefono.Text = dataGridView1[3, fila].Value.ToString();
            txtcbancaria.Text = dataGridView1[4, fila].Value.ToString();
            txtfnacimiento.Text = dataGridView1[5, fila].Value.ToString();
            txtdireccion.Text = dataGridView1[6, fila].Value.ToString();
            txtestado.Text = dataGridView1[7, fila].Value.ToString();
            txtservicios.Text = dataGridView1[8, fila].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + txtnombres.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + txtnombres.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }
    }
}
