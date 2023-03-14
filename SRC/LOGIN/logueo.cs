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
namespace LOGIN
{
    

    public partial class logueo : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        PRINCIPAL frm1 = new PRINCIPAL();

        public static string usuario_nombre;
        void p_logueo()
        {
            try
            {
                DataTable dt = new DataTable();
            objent.usuario = txtusuario.Text;
            objent.clave = txtcontra.Text;
            dt = objneg.N_user(objent);

            if (dt.Rows.Count > 0)
            {
               MessageBox.Show("BIENVENIDO" + dt.Rows[0][1].ToString(),"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                frm1.ShowDialog();
                

                logueo login = new logueo();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new PRINCIPAL());
                txtcontra.Clear();
                txtusuario.Clear();

            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS" , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public logueo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_logueo(); 
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logueo_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            p_logueo();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
