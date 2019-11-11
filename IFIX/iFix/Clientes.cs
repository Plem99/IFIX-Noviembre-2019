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
    public partial class Clientes : Form
    {
        //string direccion = "C:\\Users\\Plem\\Desktop\\FINALPROYECTO\\IFIX\\Sonidos\\";
        InicioSesion iniSesion = new InicioSesion();
        string direccion2;
        ifix_DBDataContext dc = new ifix_DBDataContext();
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public Clientes(string usuarioNombre) {
            InitializeComponent();
            usuarioToolStripMenuItem.Text = usuarioNombre;
            cargarClientes();
            SetFontAndColors();
        }

        public void getAyuda()
        {
            this.direccion2 = iniSesion.getDireccion2();
            System.Diagnostics.Process.Start(direccion2 + "MUsuario.pdf");
        }
        private void SetFontAndColors()
        {
            this.dgClientes.DefaultCellStyle.Font = new Font("Tahoma", 9);
            dgClientes.AutoResizeColumns();
        }


        void cargarClientes()
        {
            dgClientes.CellContentClick -= new DataGridViewCellEventHandler(dgClientes_CellContentClick);
            
            /*var clientes = from clt in dc.mostrarClientes() select new { clt.nombre, clt.usuario, clt.email };


            DataGridViewColumn colnombre = new DataGridViewTextBoxColumn();
            colnombre.DataPropertyName = "nombre";
            colnombre.Name = "NOMBRE";
            dgClientes.Columns.Add(colnombre);

            DataGridViewColumn colusuario = new DataGridViewTextBoxColumn();
            colusuario.DataPropertyName = "usuario";
            colusuario.Name = "USUARIO";
            dgClientes.Columns.Add(colusuario);
            dgClientes.AutoGenerateColumns = false;

            DataGridViewColumn colemail = new DataGridViewTextBoxColumn();
            colemail.DataPropertyName = "email";
            colemail.Name = "EMAIL";
            dgClientes.Columns.Add(colemail);
            dgClientes.AutoGenerateColumns = false;

            dgClientes.DataSource = clientes.ToList();*/

        }

        private void Clientes_Load(object sender, EventArgs e) {
            speech.SpeakAsync("Ingresó a los registros de Clientes, En esta página se despliegan los clientes y sus datos principales.");
            
            DataGridViewRow row = (DataGridViewRow)dgClientes.Rows[0].Clone();
            row.Cells[0].Value = "juan2019";
            row.Cells[1].Value = "8341112233";
            row.Cells[2].Value = "juan@correo.com";
            dgClientes.Rows.Add(row);
            DataGridViewRow row2 = (DataGridViewRow)dgClientes.Rows[1].Clone();
            row2.Cells[0].Value = "prueba01";
            row2.Cells[1].Value = "8344445566";
            row2.Cells[2].Value = "otro@nose.com";
            dgClientes.Rows.Add(row2);
            DataGridViewRow row3 = (DataGridViewRow)dgClientes.Rows[1].Clone();
            row3.Cells[0].Value = "carlos99";
            row3.Cells[1].Value = "3847778899";
            row3.Cells[2].Value = "carlos@gmail.com";
            dgClientes.Rows.Add(row3);
            DataGridViewRow row4 = (DataGridViewRow)dgClientes.Rows[1].Clone();
            row4.Cells[0].Value = "otro1234";
            row4.Cells[1].Value = "1111111111";
            row4.Cells[2].Value = "otro@algo.com";
            dgClientes.Rows.Add(row4);

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

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void vehiculosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Vehiculos vehicu = new Vehiculos(usuarioToolStripMenuItem.Text);
            this.Hide();
            vehicu.Show();
        }

        private void serviciosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Servicios servi = new Servicios(usuarioToolStripMenuItem.Text);
            this.Hide();
            servi.Show();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(usuarioToolStripMenuItem.Text);
            this.Hide();
            venta.Show();
        }

        private void BtnDelClien_Click(object sender, EventArgs e)
        {
            BorrarCliente borrarCliente = new BorrarCliente();
            borrarCliente.Show();
            dgClientes.DataSource = null;
            cargarClientes();
            this.Hide();
            

        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingresó a la ayuda");
            getAyuda();
            //System.Diagnostics.Process.Start("MUsuario.pdf");            // MessageBox.Show("En esta página se despliegan los clientes y se pueden eliminar si así se desea.","Ayuda.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes repo = new Reportes(usuarioToolStripMenuItem.Text);
            this.Hide();
            repo.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_KeyUp(object sender, KeyEventArgs e)
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

            if (e.Shift && e.KeyCode == Keys.A) // Reportes
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Ingresó a la ayuda");
                getAyuda();
                //MessageBox.Show("En esta página se despliegan los clientes y sus datos principales.", "Ayuda.", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
