using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clientes;
using actualizarclientess;
using AMBULANCIA;
using PARAMEDICO;
using actualizarconductor;
using actualizarparamedico;
using CONDUCTOR;

namespace LOGIN
{
    public partial class PRINCIPAL : Form
    {
        public PRINCIPAL()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            submenucliente.Visible = false;
            submenuconductor.Visible = false;
            submenuambulancia.Visible = false;
            submenuparamedico.Visible = false;
        }

        private void hideSubMenu()
        {
            if (submenucliente.Visible == true)
                submenucliente.Visible = false;
            if (submenuconductor.Visible == true)
                submenucliente.Visible = false;
            if (submenuparamedico.Visible == true)
                submenucliente.Visible = false;
            if (submenuambulancia.Visible == true)
                submenucliente.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelformulario.Controls.Add(childForm);
            panelformulario.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCL formulario = new RegistroCL();
            formulario.ShowDialog();
            
        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            registroAM formulario = new registroAM();
            
            formulario.ShowDialog();
            
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RegistroCO formulario = new RegistroCO();
            
            formulario.ShowDialog();
        }

        private void modificarEliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            actCond formulario = new actCond();
            
            formulario.ShowDialog();
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            registroPA formulario = new registroPA();
            
            formulario.ShowDialog();
        }

        private void modificarEliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            actParamedico formulario = new actParamedico();
            
            formulario.ShowDialog();
        }

        private void modificarEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizacion formulario = new actualizacion();
            
            formulario.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuambulancia);
        }

        private void ambulanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            showSubMenu(submenucliente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void btnconductor_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuconductor);
        }

        private void btnparamedico_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuparamedico);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void panelformulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            openChildFormInPanel(new RegistroCL());
            hideSubMenu();
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new actualizacion());
            hideSubMenu();
        }

        private void gestiónDeEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            showSubMenu(submenucliente);
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuconductor);
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuparamedico);
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuambulancia);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new RegistroCO());
            hideSubMenu();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new actCond());
            hideSubMenu();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new registroPA());
            hideSubMenu();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new actParamedico());
            hideSubMenu();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new registroAM());
            hideSubMenu();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new registroAM());
            hideSubMenu();
        }

        private void modificarEliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            
            hideSubMenu();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

