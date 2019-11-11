using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFix
{
    public partial class Reportes : Form
    {
        //string direccion = "C:\\Users\\Plem\\Desktop\\FINALPROYECTO\\IFIX\\Sonidos\\";
        InicioSesion iniSesion = new InicioSesion();
        string direccion2;
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public Reportes(string usuarioNombre) {
            InitializeComponent();
            usuarioToolStripMenuItem.Text = usuarioNombre;
        }
        public void getAyuda()
        {
            this.direccion2 = iniSesion.getDireccion2();
            System.Diagnostics.Process.Start(direccion2 + "MUsuario.pdf");
        }
        private void Reportes_Load(object sender, EventArgs e) {
            speech.SpeakAsync("Ingresó a los reportes, En esta página se despliegan los reportes del sistema");
            // TODO: This line of code loads data into the 'DSFix.reporte_vehiculos' table. You can move, or remove it, as needed.
            /*this.reporte_vehiculosTableAdapter.Fill(this.DSFix.reporte_vehiculos);
            this.reportViewer1.RefreshReport();*/
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

        private void lblUsuario_Click(object sender, EventArgs e){ }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            Menu menu = new Menu(usuarioToolStripMenuItem.Text);
            this.Hide();
            menu.Show();
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicios servi = new Servicios(serviciosToolStripMenuItem.Text);
            this.Hide();
            servi.Show();
        }

        private void VehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculos vehicu = new Vehiculos(vehiculosToolStripMenuItem.Text);
            this.Hide();
            vehicu.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes client = new Clientes(clientesToolStripMenuItem.Text);
            this.Hide();
            client.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            Venta venta = new Venta("ADMIIFIX");
            this.Hide();
            //speech.SpeakAsyncCancelAll();
            venta.Show();

        }

        private void Reportes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) //Venta
            {
                //System.Diagnostics.Process.Start("C:\\Users\\iceca\\Downloads\\ConstanciaVigencia.pdf");
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
                Servicios servi = new Servicios(usuarioToolStripMenuItem.Text);
                this.Hide();
                servi.Show();
            }
            if (e.KeyCode == Keys.F6) //Reportes
            {

            }
            if (e.KeyCode == Keys.L)
            {
                Lupa2 lupa = new Lupa2();
                // this.Hide();
                lupa.Show();
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Ingresó a la lupa");
            }
            if (e.KeyCode == Keys.Escape) // Reportes
            {
                speech.SpeakAsyncCancelAll();
                Menu mainMenu = new Menu("ADMIIFIX");
                this.Hide();
                //speech.SpeakAsyncCancelAll();
                mainMenu.Show();
            }

            if (e.Shift && e.KeyCode == Keys.A)
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Ingresó a la ayuda");
                getAyuda();
                //MessageBox.Show("Aqui se generan los reportes mensualmente.", "Ayuda.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

            private void btnAyuda_Click(object sender, EventArgs e)
        {
            //getAyuda();
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingresó a la ayuda");
            getAyuda();
            //MessageBox.Show("Aqui se generan los reportes mensualmente.", "Ayuda.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //System.Diagnostics.Process.Start("MUsuario.pdf");            // MessageBox.Show("Aqui se generan los reportes mensualmente.", "Ayuda.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
