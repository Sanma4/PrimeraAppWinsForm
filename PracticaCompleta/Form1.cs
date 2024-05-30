using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCompleta
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Se terminó C# por hoy, adios.");
        }


        private void btnControlButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento click ¡CUIDADO!");
            //this.BackColor = Color.Blue;

            if (txtEscritura.Text == "")
                txtEscritura.BackColor = Color.Red;
            else
                txtEscritura.BackColor = System.Drawing.SystemColors.Control;
        }

        private void Formulario_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón izquierdo, cuidado");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el botón derecho, cuidado");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono la rueda del ratón, cuidado");
        }

        private void lblAviso_Click(object sender, EventArgs e)
        {

        }

        private void lblAviso_MouseMove(object sender, MouseEventArgs e)
        {
            lblAviso.BackColor = Color.Cyan;
            lblAviso.Cursor = Cursors.Hand;
        }

        private void lblAviso_MouseLeave(object sender, EventArgs e)
        {
            lblAviso.Cursor = Cursors.Arrow;
            lblAviso.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtEscritura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtName.Text.Length + " caracteres");
        }
    }
}
