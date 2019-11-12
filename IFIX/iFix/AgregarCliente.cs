using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;
using System.Speech.Synthesis;

namespace iFix
{
    public partial class AgregarCliente : Form
    {
        //string direccion = "C:\\Users\\Plem\\Desktop\\FINALPROYECTO\\IFIX\\Sonidos\\";
        InicioSesion iniSesion = new InicioSesion();
        string direccion;
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public AgregarCliente()
        {
            InitializeComponent();
        }
        public void getinfo(int n)
        {
            SoundPlayer reproducir;
            this.direccion = iniSesion.getDireccion();
            switch (n)
            {
                case 1:
                    reproducir = new SoundPlayer(direccion + "Nombres.wav");
                    reproducir.Play();
                    break;
                case 2:
                    reproducir = new SoundPlayer(direccion + "Apellidos.wav");
                    reproducir.Play();
                    break;
                case 3:
                    reproducir = new SoundPlayer(direccion + "Usuarios.wav");
                    reproducir.Play();
                    break;
                case 4:
                    reproducir = new SoundPlayer(direccion + "Contraseña.wav");
                    reproducir.Play();
                    break;
                case 5:
                    reproducir = new SoundPlayer(direccion + "Telefono.wav");
                    reproducir.Play();
                    break;
                case 6:
                    reproducir = new SoundPlayer(direccion + "Email.wav");
                    reproducir.Play();
                    break;
            }

        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            speech.SpeakAsync("Ingresó al Formulario para registrar un nuevo Cliente");
            txtNombre.GotFocus += new EventHandler(this.TextGotFocusNombre);
            txtNombre.LostFocus += new EventHandler(this.TextLostFocusNombre);

            txtApellido.GotFocus += new EventHandler(this.TextGotFocusApellido);
            txtApellido.LostFocus += new EventHandler(this.TextLostFocusApellido);

            txtUsuario.GotFocus += new EventHandler(this.TextGotFocusUsuario);
            txtUsuario.LostFocus += new EventHandler(this.TextLostFocusUsuario);

            txtContrasena.GotFocus += new EventHandler(this.TextGotFocusPass);
            txtContrasena.LostFocus += new EventHandler(this.TextLostFocusPass);

            txtTelefono.GotFocus += new EventHandler(this.TextGotFocusTelefono);
            txtTelefono.LostFocus += new EventHandler(this.TextLostFocusTelefono);

            txtCorreo.GotFocus += new EventHandler(this.TextGotFocusCorreo);
            txtCorreo.LostFocus += new EventHandler(this.TextLostFocusCorreo);

            registrarBtn.GotFocus += new EventHandler(this.BtnFocusregistrarBtn);
            button1.GotFocus += new EventHandler(this.BtnFocusbutton1);
        }
        public void BtnFocusregistrarBtn(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón para registrar nuevo cliente");
            
        }
        public void BtnFocusbutton1(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón para cancelar registro");

        }
        //Funciones de GotFocus & LostFocus Nombre
        public void TextGotFocusNombre(object sender, EventArgs e) {
            //getinfo(1);
            //speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingrese el Nombre");
            if (txtNombre.Text == "Nombre(s)") {
                
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        public void TextGotFocusApellido(object sender, EventArgs e)
        {
            //getinfo(2);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingrese los apellidos");
            if (txtApellido.Text == "Apellido(s)")
            {
                
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        public void TextGotFocusUsuario(object sender, EventArgs e)
        {
            //getinfo(3);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingrese el usuario");
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        public void TextGotFocusPass(object sender, EventArgs e)
        {
            //getinfo(4);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingrese la contraseña");
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
            }
        }

        public void TextGotFocusTelefono(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingrese el teléfono");
            txtTelefono.Text = "";
            //getinfo(5);

        }
        int bandxD = 0;
        public void TextGotFocusCorreo(object sender, EventArgs e)
        {
            //getinfo(6);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingrese el correo eléctronico");
            //txtTelefono.Text = "___-___-____";        
        }

        // Funciones de LostFocus
        public void TextLostFocusNombre(object sender, EventArgs e)
        {
            //getinfo(1);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Faltó el nombre, porfavor, ingreselo");
            if (txtNombre.Text == "")
            {
                
                txtNombre.Text = "Nombre(s)";
                txtNombre.ForeColor = Color.Gainsboro;
            }
        }

        public void TextLostFocusApellido(object sender, EventArgs e)
        {
            //getinfo(2);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Faltó los apellidos, porfavor, ingreselos");
            if (txtApellido.Text == "")
            {
                
                txtApellido.Text = "Apellido(s)";
                txtApellido.ForeColor = Color.Gainsboro;
            }
        }

        public void TextLostFocusUsuario(object sender, EventArgs e)
        {
            //getinfo(3);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Faltó el usuario, porfavor, ingreselo");
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gainsboro;
            }
        }

        public void TextLostFocusPass(object sender, EventArgs e)
        {
            //getinfo(4);
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Faltó la contraseña, porfavor, ingresela");
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.Gainsboro;
            }
        }

        public void TextLostFocusTelefono(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Faltó el teléfono, porfavor, ingreselo");
            //getinfo(5);

        }

        public void TextLostFocusCorreo(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Faltó el correo eléctronico, porfavor, ingreselo");
            //getinfo(6);

        }
        void camposVacion()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Campo nombre vacio");
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Campo apellido vacio");
            }
            if (txtContrasena.Text == "")
            {
                MessageBox.Show("Campo contraseña vacio");
            }
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Campo usuario vacio");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e) { }

        private void txtApellido_TextChanged(object sender, EventArgs e) { }

        private void txtUsuario_TextChanged(object sender, EventArgs e) { }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            bandxD = 1;
        }

        private void txtContrasena_TextChanged_1(object sender, EventArgs e) { }
        

        private void txtCorreo_TextChanged_1(object sender, EventArgs e) { }

        private void Button1_Click(object sender, EventArgs e)
        {
            string patron = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)*[a-zA-Z]{2,9})$";
            speech.SpeakAsyncCancelAll();
            
            if (txtNombre.Text == "" || txtNombre.Text.Equals("Nombre(s)")) //Nombres
            {
                speech.SpeakAsync("Ingrese un nombre o nombres.");
                MessageBox.Show("Ingrese un nombre o nombres.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
            }
            else if (txtApellido.Text == "" || txtApellido.Text.Equals("Apellido(s)")) //Apellidos
            {
                speech.SpeakAsync("Ingrese un apellido o apellidos.");
                MessageBox.Show("Ingrese un apellido o apellidos.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
            }
            else if (txtUsuario.TextLength < 8)
            {
                speech.SpeakAsync("El nombre de usuario debe contener 8 caracteres.");
                MessageBox.Show("El nombre de usuario debe contener 8 caracteres.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Usuario
                txtUsuario.Focus();
            }
            else if (txtContrasena.Text == "" || txtContrasena.Text.Equals("Contraseña")) //Contraseña
            {
                speech.SpeakAsync("Ingrese una contraseña adecuada.");
                MessageBox.Show("Ingrese una contraseña adecuada.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContrasena.Focus();
            }
            //else if (txtTelefono.Text == "" || txtTelefono.Text.Equals("___-___-____")) //Contraseña
            else if (!txtTelefono.MaskCompleted)
            {
                speech.SpeakAsync("Ingrese un numero telefónico válido.");
                MessageBox.Show("Ingrese un numero telefónico válido.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefono.Focus();
            }else  if (!Regex.IsMatch(txtCorreo.Text, patron)) //Correo 
            {
                speech.SpeakAsync("Ingrese un formato de correo electrónico adecuado.");
                MessageBox.Show("Ingrese un formato de correo electrónico adecuado.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
            }
            else
            {
                string nombre = txtNombre.Text + " " + txtApellido.Text;
                string usuario = txtUsuario.Text;
                string contra = txtContrasena.Text;
                string correo = txtCorreo.Text;
                string telef = txtTelefono.Text;

                /*ifix_DBDataContext dc = new ifix_DBDataContext();
                dc.agregarCliente(nombre.ToString(), usuario.ToString(), contra.ToString(),
                    telef.ToString(), correo.ToString()
                  );*/


                speech.SpeakAsync("Cliente registrado con éxito.");
                MessageBox.Show("Cliente registrado con éxito.", "Registro de Cliente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                speech.SpeakAsyncCancelAll();



            }

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Solo se aceptan letras.");
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Solo se aceptan letras.");
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 32)
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Solo se aceptan letras y números.");
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras y números.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 32)
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Solo se aceptan letras y números.");
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras y números.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtApellido.Text == ""
                    && txtUsuario.Text == "" && txtContrasena.Text == ""
                    && txtTelefono.Text.Equals("000-000-0000") && txtCorreo.Text == "")
            {
                speech.SpeakAsyncCancelAll();
                this.Close();
            }
            else
            {
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("¿Seguro que desea salir?");
                DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


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
            //this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgregarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Reportes
            {
                if (txtNombre.Text == "" && txtApellido.Text == "" 
                    && txtUsuario.Text == "" && txtContrasena.Text == "" 
                    && txtTelefono.Text.Equals("000-000-0000") && txtCorreo.Text == "")
                {
                    speech.SpeakAsyncCancelAll();
                    this.Close();
                }
                else
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("¿Seguro que desea salir?");
                    DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


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

            
                if(e.Alt && e.KeyCode == Keys.Enter)
            {
                speech.SpeakAsyncCancelAll();
                string patron = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)*[a-zA-Z]{2,9})$";

                if (txtNombre.Text == "" || txtNombre.Text.Equals("Nombre(s)")) //Nombres
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Ingrese un nombre o nombres.");
                    MessageBox.Show("Ingrese un nombre o nombres.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus();
                }
                else if (txtApellido.Text == "" || txtApellido.Text.Equals("Apellido(s)")) //Apellidos
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Ingrese un apellido o apellidos.");
                    MessageBox.Show("Ingrese un apellido o apellidos.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtApellido.Focus();
                }
                else if (txtUsuario.TextLength < 8)
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("El nombre de usuario debe contener 8 caracteres.");
                    MessageBox.Show("El nombre de usuario debe contener 8 caracteres.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Usuario
                    txtUsuario.Focus();
                }
                else if (txtContrasena.Text == "" || txtContrasena.Text.Equals("Contraseña")) //Contraseña
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Ingrese una contraseña adecuada.");
                    MessageBox.Show("Ingrese una contraseña adecuada.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContrasena.Focus();
                }
                //else if (txtTelefono.Text == "" || txtTelefono.Text.Equals("___-___-____")) //Contraseña
                else if (!txtTelefono.MaskCompleted)
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Ingrese un numero telefónico válido.");
                    MessageBox.Show("Ingrese un numero telefónico válido.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTelefono.Focus();
                }
                else if (!Regex.IsMatch(txtCorreo.Text, patron)) //Correo 
                {
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Ingrese un formato de correo electrónico adecuado.");
                    MessageBox.Show("Ingrese un formato de correo electrónico adecuado.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCorreo.Focus();
                }
                else
                {
                    string nombre = txtNombre.Text + " " + txtApellido.Text;
                    string usuario = txtUsuario.Text;
                    string contra = txtContrasena.Text;
                    string correo = txtCorreo.Text;
                    string telef = txtTelefono.Text;

                    /*ifix_DBDataContext dc = new ifix_DBDataContext();
                    dc.agregarCliente(nombre.ToString(), usuario.ToString(), contra.ToString(),
                        telef.ToString(), correo.ToString()
                      );*/


                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Cliente registrado con éxito.");
                    MessageBox.Show("Cliente registrado con éxito.", "Registro de Cliente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    speech.SpeakAsyncCancelAll();




                }
            }









                //MessageBox.Show("Cliente registrado con exito.");
                //this.Close();
            }
            





        }
    }

