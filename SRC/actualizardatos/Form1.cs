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
using Clientes;
namespace actualizardatos
{
    public partial class Form1 : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        public Form1()
        {
            InitializeComponent();
        }


        void mantenimiento(String accion)
        {
            objent.codigo = txtcodigo.Text;
            objent.marca = txtmarca.Text;
            objent.modelo =txtmodelo.Text;
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
            txtbuscar.Text = "";
            dataGridView1.DataSource = objneg.N_listar_carros();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_carros();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + txtplaca.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + txtplaca.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + txtplaca.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                objent.placa = txtbuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_carros(objent);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objneg.N_listar_carros();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtcodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtmarca.Text = dataGridView1[1, fila].Value.ToString();
            txtmodelo.Text = dataGridView1[2, fila].Value.ToString();
            txtplaca.Text = dataGridView1[3, fila].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroCL formulario = new RegistroCL();
            formulario.ShowDialog();
        }
    }
}
