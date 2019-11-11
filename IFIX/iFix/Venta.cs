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
    public partial class Venta : Form
    {
        InicioSesion iniSesion = new InicioSesion();
        string direccion;
        string direccion2;
        List<string> listaServicios = new List<string>();
        SpeechSynthesizer speech = new SpeechSynthesizer();

        public void getAyuda()
        {
            this.direccion2 = iniSesion.getDireccion2();
            System.Diagnostics.Process.Start(direccion2+"MUsuario.pdf");
        }
        public void getinfo(int n)
        {
            SoundPlayer reproducir;
            this.direccion = iniSesion.getDireccion();
            switch (n)
            {
                case 1:
                    reproducir = new SoundPlayer(direccion + "Salir.wav");
                    reproducir.Play();
                    break;
                case 2:
                    reproducir = new SoundPlayer(direccion + "SelecUsuario.wav");
                    reproducir.Play();
                    break;
                case 3:
                    reproducir = new SoundPlayer(direccion + "NoCliente.wav");
                    reproducir.Play();
                    break;
                case 4:
                    reproducir = new SoundPlayer(direccion + "NoVehiculo.wav");
                    reproducir.Play();
                    break;
                case 5:
                    reproducir = new SoundPlayer(direccion + "SelecVehiculo.wav");
                    reproducir.Play();
                    break;
                case 6:
                    reproducir = new SoundPlayer(direccion + "SelecServicio.wav");
                    reproducir.Play();
                    break;
                case 7:
                    reproducir = new SoundPlayer(direccion + "ServicioAgr.wav");
                    reproducir.Play();
                    break;
                case 8:
                    reproducir = new SoundPlayer(direccion + "VentaFin.wav");
                    reproducir.Play();
                    break;
                case 9:
                    reproducir = new SoundPlayer(direccion + "ServElim.wav");
                    reproducir.Play();
                    break;
                case 10:
                    reproducir = new SoundPlayer(direccion + "Clientes.wav");
                    reproducir.Play();
                    break;
                case 11:
                    reproducir = new SoundPlayer(direccion + "Vehiculos.wav");
                    reproducir.Play();
                    break;
                case 12:
                    reproducir = new SoundPlayer(direccion + "Servicios.wav");
                    reproducir.Play();
                    break;
                case 13:
                    reproducir = new SoundPlayer(direccion + "ServicioAna.wav");
                    reproducir.Play();
                    break;
            }

        }
        public Venta(string usuarioNombre) {
            InitializeComponent();
            usuarioToolStripMenuItem.Text = usuarioNombre;
            
        }

        void servicioCombobox()
        {
            
        }

        void clientesCombobox()
        {
            
        }


        

        private void Venta_Load(object sender, EventArgs e){
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingresó al Formulario de Venta");
            cboUsuario.GotFocus += new EventHandler(this.TextGotFocusCliente);
            cboVehiculo.GotFocus += new EventHandler(this.TextGotFocusVehiculo);
            cmbServicios.GotFocus += new EventHandler(this.TextGotFocusServicio);

            lbxServiciosSeleccionados.GotFocus += new EventHandler(this.lbxServiciosSeleccionadosFocus);
            //btn eliminar
            button1.GotFocus += new EventHandler(this.BtnGotFocusbutton1);
            btnRegCliente.GotFocus += new EventHandler(this.BtnGotFocusbtnRegCliente);
            btnRegVehiculo.GotFocus += new EventHandler(this.BtnGotFocusbtnRegVehiculo);
            //btn añadir servicios
            btnAdd.GotFocus += new EventHandler(this.BtnGotFocusbtnAdd);
            btnConfirmar.GotFocus += new EventHandler(this.BtnGotFocusbtnConfirmar);
            //btn ayuda
            button2.GotFocus += new EventHandler(this.BtnGotFocusbutton2);
            txtTotal.GotFocus += new EventHandler(this.TxtGotFocustxtTotal);

            btnRegresar.GotFocus += new EventHandler(this.BtnGotFocusbtnRegresar);



        }
        public void BtnGotFocusbtnRegresar(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón para regresar al Menú principal");
        }
        public void TxtGotFocustxtTotal(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("El Total a pagar es: " + total.ToString()+ "Pesos mexicanos, con " + ".00"+" Centavos");
        }
        public void lbxServiciosSeleccionadosFocus(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Lista de servicios Seleccionados");
        }
        public void BtnGotFocusbutton1(object sender, EventArgs e)
        {
            //speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón de eliminar");
        }
        public void BtnGotFocusbtnRegCliente(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón de registrar nuevo cliente");
        }
        public void BtnGotFocusbtnRegVehiculo(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón de registrar nuevo vehiculo");
        }
        public void BtnGotFocusbtnAdd(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón de Añadir servicio");
        }
        public void BtnGotFocusbtnConfirmar(object sender, EventArgs e)
        {
            //speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón de confirmar venta");

        }
        public void BtnGotFocusbutton2(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón de ayuda");
        }
        public void TextGotFocusCliente(object sender, EventArgs e)
        {
            //getinfo(10);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Seleccionar Clientes");
        }
        public void TextGotFocusVehiculo(object sender, EventArgs e)
        {
            //getinfo(11);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Seleccionar Vehículos");
        }
        public void TextGotFocusServicio(object sender, EventArgs e)
        {
            //getinfo(12);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Seleccionar servicio");
        }

        private void lblUsuario_Click(object sender, EventArgs e){ }

        private void chklbServicios_SelectedIndexChanged(object sender, EventArgs e) { }

        private void lbxServiciosSeleccionados_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
           if(cboUsuario.Text == "")
            {
                Menu mainMenu = new Menu("ADMIIFIX");
                this.Hide();
                speech.SpeakAsyncCancelAll();
                mainMenu.Show();
            }
            else
            {
                //getinfo(1);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("¿Seguro que desea salir?");
                DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    Menu mainMenu = new Menu("ADMIIFIX");
                    this.Hide();
                    speech.SpeakAsyncCancelAll();
                    mainMenu.Show();
                }
                else if (result == DialogResult.No)
                {
                }
            }
            
        }
        int aux = 1;
        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            AgregarCliente agregarCliente = new AgregarCliente();
            agregarCliente.ShowDialog();
            


            if (aux == 2)
            {
                cboUsuario.Items.Add("otro1234");
            }
            aux++;
        }

        private void btnRegVehiculo_Click(object sender, EventArgs e)
        {
            

            if(cboUsuario.Text.Equals(""))
            {
                //getinfo(2);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Seleccione un usuario.");
                MessageBox.Show("Seleccione un usuario.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            {
                speech.SpeakAsyncCancelAll();
                AñadirVehiculo añadirVehiculo = new AñadirVehiculo(cboUsuario.Text);
                añadirVehiculo.ShowDialog();
                
                cboVehiculo.Items.Add("12345678912345678");
            }
        }

        void obtenerVehiCliente()
        {
         
        }
        private void camposVacios()
        {
            if (cboUsuario.Text == "")
            {
                //getinfo(3);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("No se ha seleccionado un cliente.");
                MessageBox.Show("No se ha seleccionado un cliente.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cboVehiculo.Text == "")
            {
                //getinfo(4);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("No se ha seleccionado un vehículo.");
                MessageBox.Show("No se ha seleccionado un vehículo.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboUsuario.Text.Equals("juan2019"))
            {
                cboVehiculo.Items.Clear();
                cboVehiculo.Items.Add("123");
                cboVehiculo.Items.Add("124");
                cboVehiculo.Items.Add("125");
            }
            else if (cboUsuario.Text.Equals("prueba01"))
            {
                cboVehiculo.Items.Clear();
                cboVehiculo.Items.Add("133");
                cboVehiculo.Items.Add("134");
                cboVehiculo.Items.Add("135");
            }
            else if (cboUsuario.Text.Equals("carlos99"))
            {
                cboVehiculo.Items.Clear();
                cboVehiculo.Items.Add("143");
                cboVehiculo.Items.Add("144");
                cboVehiculo.Items.Add("145");
            }
        }

        private void BtnVehi_Click(object sender, EventArgs e){ getinfo(10); }
        ///////////////////////////////
        float total = 0;  /////////////
        int numServicios = 0;///////////
        ///////////////////////////////

        private void BtnAdd_Click(object sender, EventArgs e)
        {
 

            if (cboVehiculo.Text == "" )
            {
                //getinfo(5);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Seleccione un vehículo.");
                MessageBox.Show("Seleccione un vehículo.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboVehiculo.Focus();
            }
            else if (cmbServicios.Text == "")
            {
                //getinfo(6);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Seleccione un servicio.");
                MessageBox.Show("Seleccione un servicio.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbServicios.Focus();
            }

            else if (listaServicios.Contains(cmbServicios.Text.ToString()) && lbxServiciosSeleccionados.Items.Count != 0) {
                //getinfo(13);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("El servicio ya fue añadido.");
                MessageBox.Show("El servicio ya fue añadido.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbServicios.Focus();
            }
            else {
                lbxServiciosSeleccionados.Items.Add(cmbServicios.Text.ToString());
                total = 0;
                foreach (var serv in lbxServiciosSeleccionados.Items)
                {
                    if (serv.Equals("Cambio de llantas"))
                    {
                        total += 200;
                    } else if (serv.Equals("Alineación"))
                    {
                        total += 500;
                    } else if (serv.Equals("Balanceo"))
                    {
                        total += 400;
                    }
                    else if (serv.Equals("Cambio de aceite"))
                    {
                        total += 100;
                    }
                    else if (serv.Equals("Cambio de suspensión"))
                    {
                        total += 1500;
                    }
                    else if (serv.Equals("Chequeo general"))
                    {
                        total += 500;
                    }
                }
                //getinfo(7);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Servicio Agregado.");
                txtTotal.Text = "$" + total.ToString() + ".00";
                btnConfirmar.Enabled = true;
                listaServicios.Add(cmbServicios.Text.ToString());
                btnConfirmar.Focus();
            }
        }

        

        private void BtnTotal_Click(object sender, EventArgs e){  }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            getAyuda();
            //System.Diagnostics.Process.Start("MUsuario.pdf");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtTotal.Text != "$0.00")
            {
                //getinfo(8);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Venta Finalizada.");
                MessageBox.Show("Venta finalizada.", "Venta.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                speech.SpeakAsyncCancelAll();speech.SpeakAsyncCancelAll();
                Menu menu = new Menu(usuarioToolStripMenuItem.Text);
                menu.Show();
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void VentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(usuarioToolStripMenuItem.Text);
            this.Hide();
            venta.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            if(cboUsuario.Text == "" )
            {
                Clientes client = new Clientes(usuarioToolStripMenuItem.Text);
                this.Hide();
                client.Show();
            } else
            {
                //getinfo(1);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("¿Seguro que desea salir?");
                DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (result == DialogResult.Yes)
                {
                    Clientes client = new Clientes(usuarioToolStripMenuItem.Text);
                    this.Hide();
                    client.Show();
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }

        private void VehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if(cboUsuario.Text == "")
            {
                Vehiculos vehicu = new Vehiculos(usuarioToolStripMenuItem.Text);
                this.Hide();
                vehicu.Show();
            }
            else
            {
                //getinfo(1);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("¿Seguro que desea salir?");
                DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (result == DialogResult.Yes)
                {
                    Vehiculos vehicu = new Vehiculos(usuarioToolStripMenuItem.Text);
                    this.Hide();
                    vehicu.Show();
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }

        private void ServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if(cboUsuario.Text == "")
            {
                Servicios servi = new Servicios(usuarioToolStripMenuItem.Text);
                this.Hide();
                servi.Show();
            } else
            {
                //getinfo(1);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("¿Seguro que desea salir?");
                DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (result == DialogResult.Yes)
                {
                    Servicios servi = new Servicios(usuarioToolStripMenuItem.Text);
                    this.Hide();
                    servi.Show();
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            if(cboUsuario.Text == "")
            {
                Reportes repo = new Reportes(usuarioToolStripMenuItem.Text);
                this.Hide();
                repo.Show();
            }
            else
            {
                //getinfo(1);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("¿Seguro que desea salir?");
                DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (result == DialogResult.Yes)
                {
                    Reportes repo = new Reportes(usuarioToolStripMenuItem.Text);
                    this.Hide();
                    repo.Show();
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Venta_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cboVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cboUsuario.Text.Equals(null))
            {
                MessageBox.Show("nel");
            }

            int i = 0;
            lbxServiciosSeleccionados.Text="";
            txtTotal.Text = "$0.00";
            lbxServiciosSeleccionados.Items.Clear();            
        }

        private void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getinfo(9);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Servicio Eliminado");
            lbxServiciosSeleccionados.Text = "";
            txtTotal.Text = "$0.00";
            lbxServiciosSeleccionados.Items.Clear();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Venta_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1) //Venta
            {
                //System.Diagnostics.Process.Start("C:\\Users\\iceca\\Downloads\\ConstanciaVigencia.pdf");
                getAyuda();
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Ingresó a la ayuda.");

            }

            if (e.KeyCode == Keys.F3) //Clientes
            {
               if(cboUsuario.Text == "" )
                {
                    Clientes client = new Clientes(usuarioToolStripMenuItem.Text);
                    this.Hide();
                    client.Show();
                } else
                {
                    //getinfo(1);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("¿Seguro que desea salir?");
                    DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                    if (result == DialogResult.Yes)
                    {
                        Clientes client = new Clientes(usuarioToolStripMenuItem.Text);
                        this.Hide();
                        client.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                    }
                }
            }
            if (e.KeyCode == Keys.F4) //Vehiculos
            {

                if(cboUsuario.Text == "" )
                {
                    Vehiculos vehicu = new Vehiculos(usuarioToolStripMenuItem.Text);
                    this.Hide();
                    vehicu.Show();
                } else
                {
                    //getinfo(1);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("¿Seguro que desea salir?");
                    DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                    if (result == DialogResult.Yes)
                    {
                        Vehiculos vehicu = new Vehiculos(usuarioToolStripMenuItem.Text);
                        this.Hide();
                        vehicu.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                    }
                }
            }
            if (e.KeyCode == Keys.F5) //Servicios
            {
                if(cboUsuario.Text == "" )
                {
                    Servicios servi = new Servicios(usuarioToolStripMenuItem.Text);
                    this.Hide();
                    servi.Show();
                } else
                {
                    //getinfo(1);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("¿Seguro que desea salir?");
                    DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                    if (result == DialogResult.Yes)
                    {
                        Servicios servi = new Servicios(usuarioToolStripMenuItem.Text);
                        this.Hide();
                        servi.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                    }
                }
            }
            if (e.KeyCode == Keys.F6) // Reportes
            {
                if(cboUsuario.Text == "" )
                {
                    Reportes repo = new Reportes(usuarioToolStripMenuItem.Text);
                    this.Hide();
                    repo.Show();
                }
                else
                {
                    //getinfo(1);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("¿Seguro que desea salir?");
                    DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                    if (result == DialogResult.Yes)
                    {
                        Reportes repo = new Reportes(usuarioToolStripMenuItem.Text);
                        this.Hide();
                        repo.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                    }
                }
            }

            if (e.KeyCode == Keys.Escape) //
            {
                if(cboUsuario.Text == "")
                {
                    Menu mainMenu = new Menu("ADMIIFIX");
                    this.Hide();
                    mainMenu.Show();
                } else
                {
                    //getinfo(1);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("¿Seguro que desea salir?");
                    DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                    if (result == DialogResult.Yes)
                    {
                        Menu mainMenu = new Menu("ADMIIFIX");
                        this.Hide();
                        mainMenu.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                    }
                }
            }
            if (e.KeyCode == Keys.L)
            {
                Lupa2 lupa = new Lupa2();
                // this.Hide();
                lupa.Show();
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Se activo la Lupa");
            }

            if (cmbServicios.Text != "")
            {
                if(e.Shift && e.KeyCode == Keys.A)
                {

                    if (listaServicios.Contains(cmbServicios.Text.ToString()) && lbxServiciosSeleccionados.Items.Count != 0)
                    {
                        //getinfo(13);
                        //getAyuda();
                        //speech.SpeakAsync("Ingresó a la ayuda.");
                        speech.SpeakAsyncCancelAll();
                        speech.SpeakAsync("El servicio ya fue añadido.");
                        MessageBox.Show("El servicio ya fue añadido.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else {
                        lbxServiciosSeleccionados.Items.Add(cmbServicios.Text.ToString());
                        total = 0;
                        foreach (var serv in lbxServiciosSeleccionados.Items)
                        {
                            if (serv.Equals("Cambio de llantas"))
                            {
                                total += 200;
                            }
                            else if (serv.Equals("Alineación"))
                            {
                                total += 500;
                            }
                            else if (serv.Equals("Balanceo"))
                            {
                                total += 400;
                            }
                            else if (serv.Equals("Cambio de aceite"))
                            {
                                total += 100;
                            }
                            else if (serv.Equals("Cambio de suspensión"))
                            {
                                total += 1500;
                            }
                            else if (serv.Equals("Chequeo general"))
                            {
                                total += 500;
                            }
                        }
                    
                    }
                    //getinfo(7);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Servicio agregado.");
                    txtTotal.Text = "$" + total.ToString() + ".00";
                    btnConfirmar.Enabled = true;
                    listaServicios.Add(cmbServicios.Text.ToString());
                }
            }

           

            if (txtTotal.Text != "$0.00")
            {

                if (e.Shift && e.KeyCode == Keys.Enter)
                {
                    //getinfo(8);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Venta finalizada.");
                    MessageBox.Show("Venta finalizada.", "Venta.",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Menu menu = new Menu(usuarioToolStripMenuItem.Text);
                    menu.Show();
                }
            }


            if (e.Alt && (e.KeyCode == Keys.Clear || e.KeyCode == Keys.Delete))
            {
                //getinfo(9);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Servicio Eliminado");
                lbxServiciosSeleccionados.Text = "";
                txtTotal.Text = "$0.00";
                lbxServiciosSeleccionados.Items.Clear();
                btnConfirmar.Enabled = false;
            }

            if (e.Shift && e.KeyCode == Keys.C)
            {
                AgregarCliente agregarCliente = new AgregarCliente();
                agregarCliente.ShowDialog();
            }

            if (e.Shift && e.KeyCode == Keys.V)
            {

                if (cboUsuario.Text.Equals(""))
                {
                    //getinfo(2);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Seleccione un usuario.");
                    MessageBox.Show("Seleccione un usuario.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    AñadirVehiculo añadirVehiculo = new AñadirVehiculo(cboUsuario.Text);
                    añadirVehiculo.ShowDialog();
                }
            }


            


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            getAyuda();
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingresó a la ayuda");
        }
    }
}
