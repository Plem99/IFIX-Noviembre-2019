using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace iFix
{
    public partial class Servicios : Form
    {
        
        InicioSesion iniSesion = new InicioSesion();
        string direccion2;
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public Servicios(string usuarioNombre) {
            InitializeComponent();
            usuarioToolStripMenuItem.Text = usuarioNombre;
            cargarServicios();
            dgServicios.ReadOnly = true;
            dgServicios.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            SetFontAndColors();
            
        }
        public void getAyuda()
        {
            this.direccion2 = iniSesion.getDireccion2();
            System.Diagnostics.Process.Start(direccion2 + "MUsuario.pdf");
        }
        private void SetFontAndColors()
        {
            this.dgServicios.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgServicios.AutoResizeColumns();
            
        }

        private void Servicios_Load(object sender, EventArgs e){

            speech.SpeakAsync("Ingresó a los registros de Servicios, En esta página se despliegan los servicios y sus datos principales.");

            DataGridViewRow row = (DataGridViewRow)dgServicios.Rows[0].Clone();
            row.Cells[0].Value = "Cambio de llantas";
            row.Cells[1].Value = "$200";
            dgServicios.Rows.Add(row);
            DataGridViewRow row2 = (DataGridViewRow)dgServicios.Rows[1].Clone();
            row2.Cells[0].Value = "Alineación";
            row2.Cells[1].Value = "$500";
            dgServicios.Rows.Add(row2);
            DataGridViewRow row3 = (DataGridViewRow)dgServicios.Rows[1].Clone();
            row3.Cells[0].Value = "Balanceo";
            row3.Cells[1].Value = "$400";
            dgServicios.Rows.Add(row3);
            DataGridViewRow row4 = (DataGridViewRow)dgServicios.Rows[1].Clone();
            row4.Cells[0].Value = "Cambio de aceite";
            row4.Cells[1].Value = "$100";
            dgServicios.Rows.Add(row4);
            DataGridViewRow row5 = (DataGridViewRow)dgServicios.Rows[1].Clone();
            row5.Cells[0].Value = "Cambio de suspensión";
            row5.Cells[1].Value = "$1500";
            dgServicios.Rows.Add(row5);
            DataGridViewRow row6 = (DataGridViewRow)dgServicios.Rows[1].Clone();
            row6.Cells[0].Value = "Chequeo general";
            row6.Cells[1].Value = "$500";
            dgServicios.Rows.Add(row6);

            btnRegresar.GotFocus += new EventHandler(this.BtnGotFocusbtnRegresar);
            btnAyuda.GotFocus += new EventHandler(this.BtnGotFocusbtnAyuda);

        }

        public void BtnGotFocusbtnAyuda(object sender, EventArgs e)
        {
            //speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón para ingresar a la ayuda");
        }
        public void BtnGotFocusbtnRegresar(object sender, EventArgs e)
        {

            speech.Volume = 100;
            speech.Rate = 0;
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón para regresar al menú");
        }

        private void lblUsuario_Click(object sender, EventArgs e) { }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicios servi = new Servicios(serviciosToolStripMenuItem.Text);
            this.Hide();
            servi.Show();
        }


        private void vehiculosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Vehiculos vehicu = new Vehiculos(vehiculosToolStripMenuItem.Text);
            this.Hide();
            vehicu.Show();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Clientes client = new Clientes(clientesToolStripMenuItem.Text);
            this.Hide();
            client.Show();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarServicio editarServicio = new EditarServicio();
            editarServicio.Show();
            this.Hide();
        }


        void cargarServicios()
        {
            /*dgServicios.CellContentClick -= new DataGridViewCellEventHandler(dgServicios_CellContentClick);
            ifix_DBDataContext dc = new ifix_DBDataContext();
            var servicios = from serv in dc.obtenerServicios() select new {serv.nombre, serv.costo };

            DataGridViewColumn colnombre = new DataGridViewTextBoxColumn();
            colnombre.DataPropertyName = "nombre";
            colnombre.Name = "NOMBRE DEL SERVICIO";
            dgServicios.Columns.Add(colnombre);
            
            DataGridViewColumn colcosto = new DataGridViewTextBoxColumn();
            colcosto.DataPropertyName = "$" + "costo";
            colcosto.Name = "COSTO";
            dgServicios.Columns.Add(colcosto);
            dgServicios.AutoGenerateColumns = false;
            dgServicios.DataSource = servicios.ToList();*/

        }

        private void dgServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            Menu menu = new Menu(usuarioToolStripMenuItem.Text);
            this.Hide();
            //speech.SpeakAsyncCancelAll();
            menu.Show();
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AñadirServicio añadirServicio = new AñadirServicio();
            añadirServicio.ShowDialog();
            this.Hide();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            BorrarServicio borrarServicio = new BorrarServicio();
            borrarServicio.ShowDialog();
            this.Hide();
            speech.SpeakAsyncCancelAll();
            Servicios servico = new Servicios("ADMIIFIX");
            servico.Show();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingresó a la ayuda");
            getAyuda();
            //System.Diagnostics.Process.Start("MUsuario.pdf");
        }

        private void VentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            Venta venta = new Venta("ADMIIFIX");
            this.Hide();
            //speech.SpeakAsyncCancelAll();
            venta.Show();
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes repo = new Reportes(usuarioToolStripMenuItem.Text);
            this.Hide();
            repo.Show();
        }

        private void dgServicios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Servicios_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) //Venta
            {
                getAyuda();
                //System.Diagnostics.Process.Start("MUsuario.pdf");
            }
            if (e.KeyCode == Keys.F2) //Venta
            {
                Venta venta = new Venta(usuarioToolStripMenuItem.Text);
                this.Hide();
                venta.Show();
            }
            if (e.KeyCode == Keys.F3) //Cliente
            {
                Clientes client = new Clientes(usuarioToolStripMenuItem.Text);
                this.Hide();
                client.Show();
            }
            if (e.KeyCode == Keys.F4) //Vehiculos
            {
                Vehiculos vehicu = new Vehiculos(usuarioToolStripMenuItem.Text);
                this.Hide();
                vehicu.Show();
            }
            if (e.KeyCode == Keys.F5) //Servicios
            {
            }
            if (e.KeyCode == Keys.F6) //Reportes
            {
                Reportes repo = new Reportes(usuarioToolStripMenuItem.Text);
                this.Hide();
                repo.Show();
            }
            if (e.KeyCode == Keys.Escape) // Reportes
            {
                speech.SpeakAsyncCancelAll();
                Menu mainMenu = new Menu("ADMIIFIX");
                this.Hide();
                //speech.SpeakAsyncCancelAll();
                mainMenu.Show();
            }

            if(e.Shift && e.KeyCode == Keys.A)
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Ingresó a la ayuda");
                //MessageBox.Show("En esta página se encuentran los servicios.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (e.KeyCode == Keys.L)
            {
                Lupa2 lupa = new Lupa2();
                // this.Hide();
                lupa.Show();
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Ingresó a la lupa");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAyuda();
            //System.Diagnostics.Process.Start("MUsuario.pdf");
        }
    }
}
