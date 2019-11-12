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
    public partial class AñadirVehiculo : Form
    {
        ifix_DBDataContext dc = new ifix_DBDataContext();
        string alarma = "N";
        string cristal = "N";
        string gps = "N";
        string airbag = "N";
        string user;
        SpeechSynthesizer speech = new SpeechSynthesizer();
        //string direccion = "C:\\Users\\Plem\\Desktop\\FINALPROYECTO\\IFIX\\Sonidos\\";
        InicioSesion iniSesion = new InicioSesion();
        string direccion;

        public void getinfo(int n)
        {
            SoundPlayer reproducir;
            this.direccion = iniSesion.getDireccion();
            switch (n)
            {
                case 1:
                    reproducir = new SoundPlayer(direccion + "Numero.wav");
                    reproducir.Play();
                    break;
                case 2:
                    reproducir = new SoundPlayer(direccion + "Marca.wav");
                    reproducir.Play();
                    break;
                case 3:
                    reproducir = new SoundPlayer(direccion + "Modelo.wav");
                    reproducir.Play();
                    break;
                case 4:
                    reproducir = new SoundPlayer(direccion + "Color.wav");
                    reproducir.Play();
                    break;
                case 5:
                    reproducir = new SoundPlayer(direccion + "Ano.wav");
                    reproducir.Play();
                    break;
                case 6:
                    reproducir = new SoundPlayer(direccion + "Usuario.wav");
                    reproducir.Play();
                    break;
            }

        }
        public AñadirVehiculo(String usuario)
        {
            InitializeComponent();
            this.CenterToScreen();
            /*cmbAlarma.Items.Add("Sí");
            cmbAlarma.Items.Add("No");
            cmbCristal.Items.Add("Sí");
            cmbCristal.Items.Add("No");
            cmbGPS.Items.Add("Sí");
            cmbGPS.Items.Add("No");
            cmbAir.Items.Add("Sí");
            cmbAir.Items.Add("No");*/
            clientesCombobox();
            tipoCombobox();
            user = usuario;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e) { }

        private void Button1_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            
            int anio = 0;
            if (txtAno.Text != "")
            {
                anio = Int32.Parse(txtAno.Text);
            }
            if (txtSerie.Text == "")
            {
                speech.SpeakAsync("Ingrese un número de serie.");
                MessageBox.Show("Ingrese un número de serie.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSerie.Focus();
            } else if (txtSerie.Text.Length < 16)
            {
                speech.SpeakAsync("Ingrese un número de serie correcto, ingrese los 17 números correspondientes.");
                MessageBox.Show("Ingrese un número de serie correcto.\n" + "Ingrese los 17 números correspondientes.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSerie.Focus();
            }
            else if (txtMarca.Text == "")
            {
                speech.SpeakAsync("Seleccione una marca.");
                MessageBox.Show("Seleccione una marca.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMarca.Focus();
            }
            else if (txtModelo.Text == "")
            {
                speech.SpeakAsync("Seleccione un modelo.");
                MessageBox.Show("Seleccione un modelo.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtModelo.Focus();
            }
            else if (txtColor.Text == "")
            {
                speech.SpeakAsync("Ingrese el color del vehículo.");
                MessageBox.Show("Ingrese el color del vehículo.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtColor.Focus();
            }
            else if (txtAno.Text == "")
            {
                speech.SpeakAsync("Ingrese una año.");
                MessageBox.Show("Ingrese una año.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAno.Focus();
            }
            else if (anio < 1950 || anio > 2019) {
                speech.SpeakAsync("Ingrese una año correcto.");
                MessageBox.Show("Ingrese una año correcto.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAno.Focus();
            }
            else
            {

                if (alarma == "Sí")
                {
                    alarma = "S";
                }
                else { alarma = "N"; }

                if (cristal == "Sí")
                {
                    cristal = "S";
                }
                else { cristal = "N"; }

                if (gps == "Sí")
                {
                    gps = "S";
                }
                else { gps = "N"; }

                if (airbag == "Sí")
                {
                    airbag = "S";
                }
                else { airbag = "N"; }

                if (txtObs.Text == "")
                {
                    speech.SpeakAsync("No hay observaciones ¿Desea continuar?");
                    DialogResult result = MessageBox.Show("No hay observaciones ¿Desea continuar?", "Confirmación.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {
                        speech.SpeakAsync("Vehículo registrado con éxito.");
                        MessageBox.Show("Vehículo registrado con éxito.", "Registro de vehículo.",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        speech.SpeakAsyncCancelAll();
                    }
                    else if (result == DialogResult.No)
                    {
                    }
                } else
                {
                    speech.SpeakAsync("Vehículo registrado con éxito.");
                    MessageBox.Show("Vehículo registrado con éxito.", "Registro de vehículo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    speech.SpeakAsyncCancelAll();
                }



            }

        }

        private void AñadirVehiculo_Load(object sender, EventArgs e)
        {
            speech.SpeakAsync("Ingresó al registro de nuevo vehículo");
            txtUser.Text = user;
            txtSerie.GotFocus += new EventHandler(this.TextGotFocusSerie);
            txtMarca.GotFocus += new EventHandler(this.TextGotFocusMarca);
            txtModelo.GotFocus += new EventHandler(this.TextGotFocusModelo);
            txtColor.GotFocus += new EventHandler(this.TextGotFocusColor);
            txtAno.GotFocus += new EventHandler(this.TextGotFocusAno);
            txtUser.GotFocus += new EventHandler(this.TextGotFocusUser);
            txtObs.GotFocus += new EventHandler(this.TextGotFocusObs);

            button1.GotFocus += new EventHandler(this.TextGotFocusbutton1);
            button2.GotFocus += new EventHandler(this.TextGotFocusbutton2);
        }
        public void TextGotFocusbutton1(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón de registrar nuevo vehiculo.");
        }
        public void TextGotFocusbutton2(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón para cancelar registro de nuevo vehiculo.");
        }
        public void TextGotFocusSerie(object sender, EventArgs e)
        {
            //getinfo(1);
            speech.SpeakAsync("Añadir número de serie.");
        }
        public void TextGotFocusMarca(object sender, EventArgs e)
        {
            //getinfo(2);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Añadir marca del vehículo.");
        }
        public void TextGotFocusModelo(object sender, EventArgs e)
        {
            //getinfo(3);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Añadir modelo del vehículo.");
        }
        public void TextGotFocusColor(object sender, EventArgs e)
        {
            //getinfo(4);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Añadir color del vehículo.");
        }
        public void TextGotFocusAno(object sender, EventArgs e)
        {
            //getinfo(5);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Añadir año del vehículo.");
        }
        public void TextGotFocusUser(object sender, EventArgs e)
        {
            //getinfo(6);
            //speech.SpeakAsyncCancelAll();
            //speech.SpeakAsync("Añadir año del vehículo.");
        }

        public void TextGotFocusObs(object sender, EventArgs e)
        {
            //getinfo(6);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Añadir observaciones.");
        }

        void clientesCombobox()
        {

            /* var clientes = from clt in dc.obtenerNombreCliente() select new { clt.nombre, clt.usuario };

             cmbUser.DataSource = clientes.ToList();
             cmbUser.DisplayMember = "usuario";*/

        }

        void tipoCombobox()
        {
            /* var tipo = from tp in dc.obtenerTipo() select new { tp.tipo };
             cmbTipo.DataSource = tipo.ToList();
             cmbTipo.DisplayMember = "tipo";*/
        }

        private void CmbAlarma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TxtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Solo se aceptan números.");
                MessageBox.Show("Solo se aceptan números.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Solo se aceptan letras.");
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Solo se aceptan letras.");
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Solo se aceptan números.");
                e.Handled = true;
                MessageBox.Show("Solo se aceptan números.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (txtSerie.Text == "" && txtColor.Text == "" &&
                     txtMarca.Text == "" && txtModelo.Text == "" &&
                     txtAno.Text == "" && txtObs.Text == "" &&
                     checkBox1.Checked == false && checkBox2.Checked == false &&
                     checkBox3.Checked == false && checkBox4.Checked == false &&
                     checkBox5.Checked == false && checkBox6.Checked == false &&
                     checkBox7.Checked == false && checkBox8.Checked == false)
                {
                    speech.SpeakAsyncCancelAll();
                    this.Close();
                }
                else
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("¿Seguro que desea salir?");
                    DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {
                        speech.SpeakAsyncCancelAll();
                        this.Close();

                    }
                    else if (result == DialogResult.No)
                    {
                    }
                }
            
            //speech.SpeakAsyncCancelAll();
            // this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {

        }
        void camposVacios()
        {
            if (txtSerie.Text == "")
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Campo serie vacio.");
                MessageBox.Show("Campo serie vacio.");
            }
            if (txtUser.Text == "")
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Campo usuario vacio.");
                MessageBox.Show("Campo usuario vacio");
            }
            if (txtMarca.Text == "")
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Campo marca vacio.");
                MessageBox.Show("Campo marca vacio");
            }
            if (txtModelo.Text == "")
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Campo modelo vacio.");
                MessageBox.Show("Campo modelo vacio");
            }
            if (txtColor.Text == "")
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Campo color vacio.");
                MessageBox.Show("Campo color vacio");
            }
            if (txtAno.Text == "")
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Campo año vacio.");
                MessageBox.Show("Campo año vacio");
            }

        }

        private void txtMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMarca.Text.Equals("Mazda"))
            {
                txtModelo.Items.Clear();
                txtModelo.Items.Add("Mazda 2");
                txtModelo.Items.Add("Mazda 3");
                txtModelo.Items.Add("Mazda 6");
            }
            else if (txtMarca.Text.Equals("Ford"))
            {
                txtModelo.Items.Clear();
                txtModelo.Items.Add("Fiesta");
                txtModelo.Items.Add("Focus");
                txtModelo.Items.Add("Mustang");
            }
            else if (txtMarca.Text.Equals("Chevrolet"))
            {
                txtModelo.Items.Clear();
                txtModelo.Items.Add("Chevy");
                txtModelo.Items.Add("Spark");
                txtModelo.Items.Add("Aveo");
            }
            else if (txtMarca.Text.Equals("Nissan"))
            {
                txtModelo.Items.Clear();
                txtModelo.Items.Add("March");
                txtModelo.Items.Add("Sentra");
                txtModelo.Items.Add("Altima");
            }
            else if (txtMarca.Text.Equals("Toyota"))
            {
                txtModelo.Items.Clear();
                txtModelo.Items.Add("Prius C");
                txtModelo.Items.Add("Corolla");
                txtModelo.Items.Add("Camry");
            }
        }

        private void AñadirVehiculo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Reportes
            {
                if (txtSerie.Text == "" && txtColor.Text == "" &&
                     txtMarca.Text == "" && txtModelo.Text == "" &&
                     txtAno.Text == "" && txtObs.Text == "" &&
                     checkBox1.Checked == false && checkBox2.Checked == false &&
                     checkBox3.Checked == false && checkBox4.Checked == false &&
                     checkBox5.Checked == false && checkBox6.Checked == false &&
                     checkBox7.Checked == false && checkBox8.Checked == false)
                {
                    speech.SpeakAsyncCancelAll();
                    this.Close();
                } else
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("¿Seguro que desea salir?");
                    DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {
                        speech.SpeakAsyncCancelAll();
                        this.Close();

                    }
                    else if (result == DialogResult.No)
                    {
                    }
                }
            }


            
                if (e.Alt && e.KeyCode == Keys.Enter)
                {

                int anio = 0;
                if (txtAno.Text != "")
                {
                    anio = Int32.Parse(txtAno.Text);
                }
                if (txtSerie.Text == "")
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Ingrese un número de serie.");
                    MessageBox.Show("Ingrese un número de serie.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSerie.Focus();
                }
                else if (txtSerie.Text.Length < 16)
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Ingrese un número de serie correcto ingrese los 17 números correspondientes.");
                    MessageBox.Show("Ingrese un número de serie correcto.\n" + "Ingrese los 17 números correspondientes.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSerie.Focus();
                }
                else if (txtMarca.Text == "")
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Seleccione una marca.");
                    MessageBox.Show("Seleccione una marca.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMarca.Focus();
                }
                else if (txtModelo.Text == "")
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Seleccione un modelo.");
                    MessageBox.Show("Seleccione un modelo.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtModelo.Focus();
                }
                else if (txtColor.Text == "")
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Ingrese el color del vehículo.");
                    MessageBox.Show("Ingrese el color del vehículo.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtColor.Focus();
                }
                else if (txtAno.Text == "")
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Ingrese una año.");
                    MessageBox.Show("Ingrese una año.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAno.Focus();
                }
                else if (anio < 1950 || anio > 2019)
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Ingrese una año correcto.");
                    MessageBox.Show("Ingrese una año correcto.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAno.Focus();
                }
                else
                {

                    if (alarma == "Sí")
                    {
                        alarma = "S";
                    }
                    else { alarma = "N"; }

                    if (cristal == "Sí")
                    {
                        cristal = "S";
                    }
                    else { cristal = "N"; }

                    if (gps == "Sí")
                    {
                        gps = "S";
                    }
                    else { gps = "N"; }

                    if (airbag == "Sí")
                    {
                        airbag = "S";
                    }
                    else { airbag = "N"; }

                    if (txtObs.Text == "")
                    {
                        speech.SpeakAsyncCancelAll();
                        speech.SpeakAsync("No hay observaciones ¿Desea continuar?");
                        DialogResult result = MessageBox.Show("No hay observaciones ¿Desea continuar?", "Confirmación.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                        if (result == DialogResult.Yes)
                        {
                            speech.SpeakAsyncCancelAll();
                            speech.SpeakAsync("Vehiculo registrado con éxito.");
                            MessageBox.Show("Vehiculo registrado con éxito.", "Registro de vehículo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            speech.SpeakAsyncCancelAll();
                        }
                        else if (result == DialogResult.No)
                        {
                        }
                    }
                    else
                    {
                        speech.SpeakAsyncCancelAll();
                        speech.SpeakAsync("Vehículo registrado con exito.");
                        MessageBox.Show("Vehículo registrado con exito.", "Registro de vehículo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        speech.SpeakAsyncCancelAll();
                    }



                }
            }
             

            }
            


        }
    }

