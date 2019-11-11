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
    public partial class VehiculoTerminacion : Form
    {
        ifix_DBDataContext dc = new ifix_DBDataContext();
        public VehiculoTerminacion()
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

        private void VehiculoTerminacion_Load(object sender, EventArgs e)
        {
            obtenerVehiculos();
            cmbServicio.Text = "";
            obtenerServicioVehi();
        }

        void obtenerServicioVehi()
        {
            
           /* var servicios = from srv in dc.obtenerServiciosVehiculoTerminacion(dc.obtenerVehiculoId(cmbNumSerie.Text.ToString()))
                            select new
                            {
                                srv.nombre
                            };
            cmbServicio.DataSource = servicios.ToList();
            cmbServicio.DisplayMember = "nombre";¨*/
        }

        private void BtnServicios_Click(object sender, EventArgs e)
        {
            cmbServicio.Text = "";
            //obtenerServicioVehi();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cmbNumSerie.Text != "" && cmbServicio.Text != "") {
                string fecha = dateTerm.Value.ToString("yyyy-MM-dd");
                DateTime fechaFormato = DateTime.Parse(fecha);
                dc.ingresarFechaTerminacion(dc.obtenerVehiculoId(cmbNumSerie.Text.ToString()),
                    dc.obtenerServicioId(cmbServicio.Text.ToString()),
                    fechaFormato);
                this.Hide();
            }else
            {
                MessageBox.Show("Hay campos vacios");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbNumSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServicio.Text = "";
            //obtenerServicioVehi();
        }

        private void CmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
