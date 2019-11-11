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
    public partial class BorrarServicio : Form
    {
        ifix_DBDataContext dc = new ifix_DBDataContext();
        public BorrarServicio()
        {
            InitializeComponent();
            servicioCombobox();
            this.CenterToScreen();

        }

        void servicioCombobox()
        {
            
           /* var servicios = from srv in dc.obtenerServicios() select new { srv.nombre, srv.costo };

            cmbServicio.DataSource = servicios.ToList();
            cmbServicio.DisplayMember = "nombre";*/

        }

        private void BorrarServicio_Load(object sender, EventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            //dc.borrarServicio(cmbServicio.Text.ToString());
            MessageBox.Show("El servicio ha sido eliminado");
            this.Hide();
            Servicios servico = new Servicios("ADMIIFIX");
            servico.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Servicios servico = new Servicios("ADMIIFIX");
            servico.Show();
        }
    }
}
