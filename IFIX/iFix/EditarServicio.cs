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
    public partial class EditarServicio : Form
    {
        ifix_DBDataContext dc = new ifix_DBDataContext();
        public EditarServicio()
        {
            InitializeComponent();
            servicioCombobox();
            this.CenterToScreen();
        }

        void servicioCombobox()
        {

            //var servicios = from srv in dc.obtenerServicios() select new { srv.nombre, srv.costo };

            //cmbServicio.DataSource = servicios.ToList();
            //cmbServicio.DisplayMember = "nombre";

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            if(cmbServicio.Text != "" && txtNombre.Text != "" && txtCosto.Text != "")
            {
                //dc.actualizarServicio(cmbServicio.Text.ToString(), txtNombre.Text.ToString(),
                //float.Parse(txtCosto.Text));

                MessageBox.Show("El servicio ha sido actualizado");
                this.Hide();
                Servicios servico = new Servicios("ADMIIFIX");
                servico.Show();
            }else
            {
                MessageBox.Show("Hay campos vacios");
            }
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
            this.Hide();
            Servicios servico = new Servicios("ADMIIFIX");
            servico.Show();
        }

        private void EditarServicio_Load(object sender, EventArgs e)
        {

        }
    }
}
