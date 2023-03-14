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
namespace actualizarconductor
{
    public partial class actCond : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        public actCond()
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
            dataGridView1.DataSource = objneg.N_listar_conductor();

        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void actCond_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_conductor();
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

        private void iconButton1_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            txtcodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtnombres.Text = dataGridView1[1, fila].Value.ToString();
            txtcedula.Text = dataGridView1[2, fila].Value.ToString();
            txttelefono.Text = dataGridView1[3, fila].Value.ToString();
            txtdialibre.Text = dataGridView1[4, fila].Value.ToString();
            txtfnacimiento.Text = dataGridView1[5, fila].Value.ToString();
            txtdireccion.Text = dataGridView1[6, fila].Value.ToString();
            txtestado.Text = dataGridView1[7, fila].Value.ToString();
            txtservicios.Text = dataGridView1[8, fila].Value.ToString();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                objent.nombres = txtbuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_conductor(objent);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objneg.N_listar_conductor();
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
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

        private void iconButton5_Click(object sender, EventArgs e)
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

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
