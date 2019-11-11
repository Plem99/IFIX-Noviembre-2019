using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFix
{
    public partial class Vehiculos : Form
    {
        InicioSesion iniSesion = new InicioSesion();
        string direccion;
        string direccion2;
        ifix_DBDataContext dc = new ifix_DBDataContext();
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public Vehiculos(string usuarioNombre) {
            InitializeComponent();
            usuarioToolStripMenuItem.Text = usuarioNombre;
            cargarVehiculos();
            SetFontAndColors();
            
        }
        public void getAyuda()
        {
            this.direccion2 = iniSesion.getDireccion2();
            System.Diagnostics.Process.Start(direccion2 + "MUsuario.pdf");
        }
        public void getinfo(int n)
        {
            SoundPlayer reproducir;
            this.direccion = iniSesion.getDireccion();
            switch (n)
            {
                case 1:
                    reproducir = new SoundPlayer(direccion + "FechaAna.wav");
                    reproducir.Play();
                    break;
            }

        }
        private void SetFontAndColors()
        {
            this.dgVehiculos.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgVehiculos.AutoResizeColumns();
        }

        void cargarVehiculos()
        {
            dgVehiculos.CellContentClick -= new DataGridViewCellEventHandler(dgVehiculos_CellContentClick);
            
            /*var vehiculos = from vhl in dc.obtenerVehiculos() select new {
                vhl.modelo,
                vhl.marca,
                vhl.color,
                vhl.num_serie,
                vhl.anio
            };

            
            DataGridViewColumn colmodelo = new DataGridViewTextBoxColumn();
            colmodelo.DataPropertyName = "modelo";
            colmodelo.Name = "MODELO";
            dgVehiculos.Columns.Add(colmodelo);

            DataGridViewColumn colmarca = new DataGridViewTextBoxColumn();
            colmarca.DataPropertyName = "marca";
            colmarca.Name = "MARCA";
            dgVehiculos.Columns.Add(colmarca);
            

            DataGridViewColumn colcolor = new DataGridViewTextBoxColumn();
            colcolor.DataPropertyName = "color";
            colcolor.Name = "COLOR";
            dgVehiculos.Columns.Add(colcolor);

            DataGridViewColumn colnum_serie = new DataGridViewTextBoxColumn();
            colnum_serie.DataPropertyName = "num_serie";
            colnum_serie.Name = "Num. Serie";
            dgVehiculos.Columns.Add(colnum_serie);

            DataGridViewColumn colanio = new DataGridViewTextBoxColumn();
            colanio.DataPropertyName = "anio";
            colanio.Name = "AÑO";
            dgVehiculos.Columns.Add(colanio);

            dgVehiculos.AutoGenerateColumns = false;
            dgVehiculos.DataSource = vehiculos.ToList();*/

        }

        void cargarVehiculosEstado(int tipo)
        {
            dgVehiculos.CellContentClick -= new DataGridViewCellEventHandler(dgVehiculos_CellContentClick);

            /*var vehiculos = from vhl in dc.obtenerVehiculosEstado(tipo)
                            select new
                            {
                                vhl.modelo,
                                vhl.marca,
                                vhl.color,
                                vhl.num_serie,
                                vhl.anio
                            };


            DataGridViewColumn colmodelo = new DataGridViewTextBoxColumn();
            colmodelo.DataPropertyName = "modelo";
            colmodelo.Name = "MODELO";
            dgVehiculos.Columns.Add(colmodelo);

            DataGridViewColumn colmarca = new DataGridViewTextBoxColumn();
            colmarca.DataPropertyName = "marca";
            colmarca.Name = "MARCA";
            dgVehiculos.Columns.Add(colmarca);


            DataGridViewColumn colcolor = new DataGridViewTextBoxColumn();
            colcolor.DataPropertyName = "color";
            colcolor.Name = "COLOR";
            dgVehiculos.Columns.Add(colcolor);

            DataGridViewColumn colnum_serie = new DataGridViewTextBoxColumn();
            colnum_serie.DataPropertyName = "num_serie";
            colnum_serie.Name = "Num. Serie";
            dgVehiculos.Columns.Add(colnum_serie);

            DataGridViewColumn colanio = new DataGridViewTextBoxColumn();
            colanio.DataPropertyName = "anio";
            colanio.Name = "AÑO";
            dgVehiculos.Columns.Add(colanio);

            dgVehiculos.AutoGenerateColumns = false;
            dgVehiculos.DataSource = vehiculos.ToList();*/

        }

        private void Vehiculos_Load(object sender, EventArgs e) {
            speech.SpeakAsync("Ingresó a los registros de vehpiculos, En esta página se despliegan los vehiculos y sus datos principales.");
            DataGridViewRow row = (DataGridViewRow)dgVehiculos.Rows[0].Clone();
            row.Cells[0].Value = "Focus";
            row.Cells[1].Value = "123";
            row.Cells[2].Value = "juan2019";
            //row.Cells[4].Value = "Cambio de llantas";
            dgVehiculos.Rows.Add(row);
            DataGridViewRow row2 = (DataGridViewRow)dgVehiculos.Rows[1].Clone();
            row2.Cells[0].Value = "Carrera GT2";
            row2.Cells[1].Value = "135";
            row2.Cells[2].Value = "prueba01";
            //row2.Cells[4].Value = "Alineación";
            dgVehiculos.Rows.Add(row2);
            DataGridViewRow row3 = (DataGridViewRow)dgVehiculos.Rows[1].Clone();
            row3.Cells[0].Value = "Mazda 3";
            row3.Cells[1].Value = "124";
            row3.Cells[2].Value = "juan2019";
            //row3.Cells[4].Value = "Balanceo";
            dgVehiculos.Rows.Add(row3);
            //dgVehiculos.Rows.Add(row2);

            btnRegresar.GotFocus += new EventHandler(this.BtnGotFocusbtnRegresar);
            btnSal.GotFocus += new EventHandler(this.BtnGotFocusbtnSal);
            btnAyuda.GotFocus += new EventHandler(this.BtnGotFocusbtnAyuda);
        }
        public void BtnGotFocusbtnRegresar(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón para Regresar al menú");
        }
        public void BtnGotFocusbtnSal(object sender, EventArgs e)
        {
            //speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón para agregar una fecha a los registros");
        }
        public void BtnGotFocusbtnAyuda(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón para ingresar a la ayuda");
        }

        private void lblUsuario_Click(object sender, EventArgs e) { }

        private void btnRegresar_Click_1(object sender, EventArgs e) {
            speech.SpeakAsyncCancelAll();
            Menu menu = new Menu(usuarioToolStripMenuItem.Text);
            this.Hide();
            //speech.SpeakAsyncCancelAll();
            menu.Show();
        }


        private void dgVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }
        

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicios servi = new Servicios(serviciosToolStripMenuItem.Text);
            this.Hide();
            servi.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes client = new Clientes(clientesToolStripMenuItem.Text);
            this.Hide();
            client.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculos vehicu = new Vehiculos(vehiculosToolStripMenuItem.Text);
            this.Hide();
            vehicu.Show();
        }

        private void ORDENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TerminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarVehiculosEstado(2);

            
        }

        private void PendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarVehiculosEstado(1);
        }

        private void BtnTerm_Click(object sender, EventArgs e)
        {
            VehiculoTerminacion vehiculoTerminacion = new VehiculoTerminacion();
            vehiculoTerminacion.Show();
        }
        int i = 0;
        private void BtnSal_Click(object sender, EventArgs e)
        {
            //VehiculoSalida vehiculoSalida = new VehiculoSalida();
            //vehiculoSalida.Show();
            //getinfo(1);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Fecha añadida");
            DateTime fecha = DateTime.Now;

            

            DataGridViewRow row = (DataGridViewRow)dgVehiculos.Rows[i].Clone();
            dgVehiculos.Rows[i].Cells[3].Value = fecha;
            i++;

            

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
            Venta venta = new Venta(usuarioToolStripMenuItem.Text);
            this.Hide();
            venta.Show();
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes repo = new Reportes(usuarioToolStripMenuItem.Text);
            this.Hide();
            repo.Show();
        }

        private void Vehiculos_KeyUp(object sender, KeyEventArgs e)
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
            }
            if (e.KeyCode == Keys.F5) //Servicios
            {
                Servicios servi = new Servicios(usuarioToolStripMenuItem.Text);
                this.Hide();
                servi.Show();
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
            /*
            if (e.KeyCode == Keys.Escape) // Reportes
            {
                speech.SpeakAsyncCancelAll();
                Menu mainMenu = new Menu("ADMIIFIX");
                this.Hide();
                //speech.SpeakAsyncCancelAll();
                
                mainMenu.Show();
            }*/

            if(e.Shift && e.KeyCode == Keys.A)
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Ingresó a la ayuda");
                getAyuda();
                //MessageBox.Show("En esta página se despliegan todos los vehículos.\n Asignación de una fecha cuando se realizan todos los servicios de un vehículo.", "Ayuda.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (e.KeyCode == Keys.L)
            {
                Lupa2 lupa = new Lupa2();
                // this.Hide();
                lupa.Show();
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Ingresó a la lupa");
            }
            if (e.Shift && e.KeyCode == Keys.T)
            {
                //getinfo(1);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Fecha añadida");
                DateTime fecha = DateTime.Now;



                DataGridViewRow row = (DataGridViewRow)dgVehiculos.Rows[i].Clone();
                dgVehiculos.Rows[i].Cells[3].Value = fecha;
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAyuda();
            //System.Diagnostics.Process.Start("MUsuario.pdf");
        }
    }
}
