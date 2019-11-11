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
    public partial class VehiculoSalida : Form
    {
        ifix_DBDataContext dc = new ifix_DBDataContext();
        public VehiculoSalida()
        {
            InitializeComponent();
            this.CenterToScreen();
            obtenerVehiculos();
        }

        void obtenerVehiculos()
        {
            /*var vehiculos = from vhl in dc.obtenerVehiculos()
                            select new
                            {
                                vhl.num_serie,

                            };
            cmbNumSerie.DataSource = vehiculos.ToList();
            cmbNumSerie.DisplayMember = "num_serie";*/
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(cmbNumSerie.Text != "")
            {
                string fecha = dateTerm.Value.ToString("yyyy-MM-dd");
                DateTime fechaFormato = DateTime.Parse(fecha);
                dc.ingresarFechaSalida(dc.obtenerVehiculoId(cmbNumSerie.Text.ToString()),
                    fechaFormato);
                this.Hide();
            }else
            {
                MessageBox.Show("Hay campos vacios");
            }
        }

        private void cmbNumSerie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VehiculoSalida_Load(object sender, EventArgs e)
        {
            obtenerVehiculos();
        }
    }
}
