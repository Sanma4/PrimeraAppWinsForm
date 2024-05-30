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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "") { 
                txtApellido.BackColor = Color.Red;
                txtApellido.ForeColor = Color.White;
            }
            else { 
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                txtApellido.ForeColor = Color.Black;
            }
            if (txtNombre.Text == "") { 
                txtNombre.BackColor = Color.Red;
                txtNombre.ForeColor = Color.White;
            }
            else { 
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                txtNombre.ForeColor = Color.Black;
            }
            if (txtEdad.Text == "") { 
                txtEdad.BackColor = Color.Red;
                txtEdad.ForeColor = Color.White;
            }
            else { 
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
                txtEdad.ForeColor = Color.Black;
            }
            if (txtDireccion.Text == "") {
                txtDireccion.BackColor = Color.Red;
                txtDireccion.ForeColor = Color.White;
            }
            else {
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;
                txtDireccion.ForeColor = Color.Black;
            }
            lvResultado.Items.Add(txtApellido.Text);
            lvResultado.Items.Add(txtNombre.Text);
            lvResultado.Items.Add(txtEdad.Text);
            lvResultado.Items.Add(txtDireccion.Text);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
             btnCancelar.BackColor = System.Drawing.SystemColors.Control;
             btnCancelar.ForeColor = Color.Black;
        }

    }
}
