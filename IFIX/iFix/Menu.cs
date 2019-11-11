using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Speech.Synthesis;

namespace iFix
{
    public partial class Menu : Form
    {
        InicioSesion iniSesion = new InicioSesion();
        SpeechSynthesizer speech = new SpeechSynthesizer();
        string direccion;
            
        
        public void getayuda()
        {
            this.direccion = iniSesion.getDireccion();
            SoundPlayer reproducir = new SoundPlayer(direccion + "Ayuda.wav");
            reproducir.Play();
        }
        public Menu(string usuarioNombre)
        {
            InitializeComponent();
            nombreToolStripMenuItem.Text = usuarioNombre;
        }

        private void Menu_Load(object sender, EventArgs e) {
            /*SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Volume = 100;
            speech.Rate = 0;
            speech.SpeakAsync("Menú Principal");
            */

            speech.SpeakAsync("Ingresó al Menú Principal, las opciones disponibles son, Venta, Clientes, Vehículos, Servicios, Reportes y Ayuda");
            btnVenta.GotFocus += new EventHandler(this.BtnGotFocusbtnVenta);
            btnClientes.GotFocus += new EventHandler(this.BtnGotFocusbtnClientes);
            btnVehiculos.GotFocus += new EventHandler(this.BtnGotFocusbtnVehiculos);
            btnServicios.GotFocus += new EventHandler(this.BtnGotFocusbtnServicios);
            btnReportes.GotFocus += new EventHandler(this.BtnGotFocusbtnReportes);
            btnAyuda.GotFocus += new EventHandler(this.BtnGotFocusbtnAyuda);
            //nombreToolStripMenuItem.GotFocus += new EventHandler(this.BtnGotFocusInicioSesion);
        }

        public void BtnGotFocusbtnVenta(object sender, EventArgs e)
        {

            speech.Volume = 100;
            speech.Rate = 0;
            
            speech.SpeakAsync("Se encuantra en: Boton de Ventas");
        }
        public void BtnGotFocusbtnClientes(object sender, EventArgs e)
        {
            speech.Volume = 100;
            speech.Rate = 0;
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Se encuantra en: Boton de Visualización de Clientes");
        }
        public void BtnGotFocusbtnVehiculos(object sender, EventArgs e)
        {
            speech.Volume = 100;
            speech.Rate = 0;
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Se encuantra en: Boton de Visualización de Vehículos");
        }
        public void BtnGotFocusbtnServicios(object sender, EventArgs e)
        {
            speech.Volume = 100;
            speech.Rate = 0;
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Se encuantra en: Boton de Visualización de Servicios");
        }
        public void BtnGotFocusbtnReportes(object sender, EventArgs e)
        {
            speech.Volume = 100;
            speech.Rate = 0;
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Se encuantra en: Boton de Visualización de Reportes");
        }
        public void BtnGotFocusbtnAyuda(object sender, EventArgs e)
        {
            speech.Volume = 100;
            speech.Rate = 0;
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Se encuantra en: Boton de Ayuda");
        }


        private void lblUsuario_Load(object sender, EventArgs e) { }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            Venta venta = new Venta(nombreToolStripMenuItem.Text);
            this.Hide();
            //speech.SpeakAsyncCancelAll();
            venta.Show();
        }

        private void lblUsuario_Click(object sender, EventArgs e) { }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            Clientes clientes = new Clientes(nombreToolStripMenuItem.Text);
            this.Hide();
            //speech.SpeakAsyncCancelAll();
            clientes.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            Vehiculos vehiculos = new Vehiculos(nombreToolStripMenuItem.Text);
            this.Hide();
            //speech.SpeakAsyncCancelAll();
            vehiculos.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            Servicios servicios = new Servicios(nombreToolStripMenuItem.Text);
            this.Hide();
            //speech.SpeakAsyncCancelAll();
            servicios.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            Reportes reportes = new Reportes(nombreToolStripMenuItem.Text);
            this.Hide();
            //speech.SpeakAsyncCancelAll();
            reportes.Show();
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e){
            /*
             * TODO:
             *       hacer la pagina de mi perfil y el direccionamiento 
             */
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e){
            /*
             * TODO:
             *      hacer la pagina de aydua y el direccionamiento
             * 
             */
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e){
            InicioSesion inicio = new InicioSesion();
            this.Close();
            inicio.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            //getayuda();
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("En esta página se encuentran los componentes del sistema.\n" +
                "- Tecla 'N' para hacer una nueva venta.\n" +
                "- Tecla 'V' para acceder a vehículos.\n" +
                "- Tecla 'C' para acceder a clientes.\n" +
                "- Tecla 'S' para acceder a servicios.\n" +
                "- Tecla 'R' para acceder a reportes.\n" +
                "- Tecla 'ESC' para cerrar sesión.");
            MessageBox.Show("En esta página se encuentran los componentes del sistema.\n" +
                "- Tecla 'N' para hacer una nueva venta.\n" +
                "- Tecla 'V' para acceder a vehículos.\n" +
                "- Tecla 'C' para acceder a clientes.\n" +
                "- Tecla 'S' para acceder a servicios.\n" +
                "- Tecla 'R' para acceder a reportes.\n" +
                "- Tecla 'ESC' para cerrar sesión.", "Ayuda.", MessageBoxButtons.OK, MessageBoxIcon.Information) ;

            //System.Diagnostics.Process.Start("MUsuario.pdf");


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e) {  }

        private void Menu_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.N)
            {
                speech.SpeakAsyncCancelAll();
                Venta venta = new Venta(nombreToolStripMenuItem.Text);
                this.Hide();
                venta.Show();
            }
            if (e.KeyCode == Keys.S)
            {
                speech.SpeakAsyncCancelAll();
                Servicios servicios = new Servicios(nombreToolStripMenuItem.Text);
                this.Hide();
                servicios.Show();
            }
            if (e.KeyCode == Keys.C)
            {
                speech.SpeakAsyncCancelAll();
                Clientes clientes = new Clientes(nombreToolStripMenuItem.Text);
                this.Hide();
                clientes.Show();
            }
            if (e.KeyCode == Keys.R)
            {
                speech.SpeakAsyncCancelAll();
                Reportes reportes = new Reportes(nombreToolStripMenuItem.Text);
                this.Hide();
                reportes.Show();
            }
            if (e.KeyCode == Keys.V)
            {
                speech.SpeakAsyncCancelAll();
                Vehiculos vehiculos = new Vehiculos(nombreToolStripMenuItem.Text);
                this.Hide();
                vehiculos.Show();
            }
            if (e.KeyCode == Keys.Escape)
            {
                speech.SpeakAsyncCancelAll();
                InicioSesion inicio = new InicioSesion();
                this.Close();
                inicio.Show();
            }
            if (e.KeyCode == Keys.L)
            {
                Lupa2 lupa = new Lupa2();
                  // this.Hide();
                lupa.Show();
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Ingresó a la lupa");
            }


            if (e.Shift && e.KeyCode == Keys.A)
            {
                //getayuda();
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("En esta página se encuentran los componentes del sistema.\n" +
                    "- Tecla 'N' para hacer una nueva venta.\n" +
                    "- Tecla 'V' para acceder a vehículos.\n" +
                    "- Tecla 'C' para acceder a clientes.\n" +
                    "- Tecla 'S' para acceder a servicios.\n" +
                    "- Tecla 'R' para acceder a reportes.\n" +
                    "- Tecla 'ESC' para cerrar sesión.");
                MessageBox.Show("En esta página se encuentran los componentes del sistema.\n" +
               "- Tecla 'N' para hacer una nueva venta.\n" +
               "- Tecla 'V' para acceder a vehículos.\n" +
               "- Tecla 'C' para acceder a clientes.\n" +
               "- Tecla 'S' para acceder a servicios.\n" +
               "- Tecla 'R' para acceder a reportes.\n" +
               "- Tecla 'ESC' para cerrar sesión.", "Ayuda.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
