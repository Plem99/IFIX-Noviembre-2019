using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFix
{
    public partial class AñadirServicio : Form
    {
        public AñadirServicio()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != "" && txtCosto.Text != "" )
            {
                /*ifix_DBDataContext dc = new ifix_DBDataContext();

                string desc = txtNombre.Text.ToString();
                double costo = Convert.ToDouble(txtCosto.Text);

                dc.ingresarServicio(desc, costo);*/

                MessageBox.Show("El servicio ha sido añadido");
                this.Hide();
                Servicios servicio = new Servicios("ADMIIFIX");
                servicio.Show();
                
            }else
            {
                MessageBox.Show("Hay campos vacios");
            }
        }

        private void AñadirServicio_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras");
            }
        }

        private void TxtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Servicios servicio = new Servicios("ADMIIFIX");
            servicio.Show();
            this.Hide();
        }
    }
}
