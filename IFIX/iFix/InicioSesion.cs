using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace iFix
{
    public partial class InicioSesion : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        string usuario = "admiifix";
        string pass = "miadmiifix";
        string direccion = "C:\\Users\\Plem\\Desktop\\IFIX\\Sonidos\\";
        string direccion2 = "C:\\Users\\Plem\\Desktop\\IFIX\\";

        public string getDireccion()
        {
            return this.direccion;
        }
        public string getDireccion2()
        {
            return this.direccion2;
        }
        public void getinco(int n)
        {
            SoundPlayer reproducir;
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Volume = 100;
            speech.Rate = 0;

            
            switch (n)
            {
                case 1:
                    reproducir = new SoundPlayer(direccion + "UsuarioContraInco.wav");
                    reproducir.Play();
                    //speech.SpeakAsync("Usuario Prueba");
                    break;
                case 2:
                    reproducir = new SoundPlayer(direccion + "UsuarioInco.wav");
                    reproducir.Play();
                    break;
                case 3:
                    reproducir = new SoundPlayer(direccion + "ContraInco.wav");
                    reproducir.Play();
                    break;
                case 4:
                    reproducir = new SoundPlayer(direccion + "Usuario.wav");
                    reproducir.Play();
                    //speech.SpeakAsync("Usuario Prueba");
                    break;
                case 5:
                    reproducir = new SoundPlayer(direccion + "Contraseña.wav");
                    reproducir.Play();
                    break;
                case 6:
                    reproducir = new SoundPlayer(direccion + "FaltoUsuario.wav");
                    reproducir.Play();
                    break;
                case 7:
                    reproducir = new SoundPlayer(direccion + "FaltoContra.wav");
                    reproducir.Play();
                    break;

            }
            
            
        }

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void txtContrasena_TextChanged(object sender, EventArgs e) { }

        private void lblIniciarSesion_Click(object sender, EventArgs e) {
            if (txtUsuario.Text.Equals(usuario) && txtContrasena.Text.Equals(pass)) {
                Menu menu = new Menu(txtUsuario.Text.ToUpper());
                this.Hide();
                speech.SpeakAsyncCancelAll();
                menu.Show();
            }
            else if ((txtUsuario.Text == "" || txtUsuario.Text == "Usuario") && (txtContrasena.Text == "" || txtContrasena.Text == "Contraseña"))
            {
                //getinco(1);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Usuario o contraseña incorrecta.");
                MessageBox.Show("Usuario o contraseña incorrecta.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
            }
            else if (txtUsuario.Text != usuario)
            {
                //getinco(2);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Usuario incorrecto.");
                MessageBox.Show("Usuario incorrecto.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
            }
            else if (txtContrasena.Text != pass)
            {
                //getinco(3);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Contraseña incorrecta.");
                MessageBox.Show("Contraseña incorrecta.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContrasena.Focus();
                
            }





            /*else if (txtContrasena.Text.Equals("") || txtUsuario.Text.Equals("")) {
                MessageBox.Show("Introduzca un usuario y/o contraseña");
            } else if (txtContrasena.ForeColor == Color.Gainsboro || txtUsuario.Text.Equals("Usuario")) {
                MessageBox.Show("Introduzca un usuario y/o contraseña");
            } else if (txtUsuario.TextLength < 8){
                MessageBox.Show("Usuario invalido");
            } else {
                MessageBox.Show("Usuario o contraseña invalidos");
            }]*/

            //Menu menu = new Menu(txtUsuario.Text.ToUpper());
            //this.Hide(); menu.Show();
        }

        private void InicioSesion_Load(object sender, EventArgs e) {
            speech.SpeakAsync("Bienvenido a AIFIX, Se encuentra en el inicio de sesión");
            txtUsuario.GotFocus += new EventHandler(this.TextGotFocusUser);
            txtUsuario.LostFocus += new EventHandler(this.TextLostFocusUser);

            txtContrasena.GotFocus += new EventHandler(this.TextGotFocusPass);
            txtContrasena.LostFocus += new EventHandler(this.TextLostFocusPass);

            btnIniciarSesion.GotFocus += new EventHandler(this.BtnGotFocusInicioSesion);
            btnCambiarContrasena.GotFocus += new EventHandler(this.BtnGotFocusCambiarContrasena);
        }

        public void BtnGotFocusCambiarContrasena(object sender, EventArgs e)
        {
            //SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Volume = 100;
            speech.Rate = 0;
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón de Olvidé mi Contraseña");
        }

        public void BtnGotFocusInicioSesion(object sender, EventArgs e)
        {
            //SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Volume = 100;
            speech.Rate = 0;
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Botón de Inicio de Sesión");
        }

        public void TextGotFocusUser(object sender, EventArgs e)
        {
            //speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingrese un Usuario");
            if (txtUsuario.Text == "Usuario"){
                //getinco(4);
                
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        public void TextLostFocusUser(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") {
                //getinco(6);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Faltó el Usuario");
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gainsboro;
            }
        }

        public void TextGotFocusPass(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("Ingrese una Contraseña");
            if (txtContrasena.Text == "Contraseña") {
                //getinco(5);
                
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.PasswordChar = '*';
            }
        }

        public void TextLostFocusPass(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "") {
                //getinco(7);
                speech.SpeakAsyncCancelAll();
                speech.SpeakAsync("Falto la Contraseña");
                txtContrasena.PasswordChar = '\0';
                txtContrasena.ForeColor = Color.Gainsboro;
                txtContrasena.Text = "Contraseña";
            }
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            speech.SpeakAsync("La Contraseña es : " + pass);
            MessageBox.Show("Contraseña: "+pass,"Contraseña.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InicioSesion_KeyUp(object sender, KeyEventArgs e)
        {
            //if(txtUsuario.Text != "" && txtContrasena.Text != "")
            //{
                if(e.Alt && e.KeyCode == Keys.Enter)
                {
                    if (txtUsuario.Text.Equals(usuario) && txtContrasena.Text.Equals(pass))
                    {
                        Menu menu = new Menu(txtUsuario.Text.ToUpper());
                        this.Hide(); menu.Show();
                }
                else if ((txtUsuario.Text == "" || txtUsuario.Text == "Usuario") && (txtContrasena.Text == "" || txtContrasena.Text == "Contraseña"))
                {
                    //getinco(1);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Usuario o contraseña incorrecta, porfavor, ingreselo de nuevo.");
                    MessageBox.Show("Usuario o contraseña incorrecta.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                }
                else if (txtUsuario.Text != usuario)
                {
                    //getinco(2);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Usuario incorrecto, porfavor, ingreselo de nuevo.");
                    MessageBox.Show("Usuario incorrecto.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                }
                else if (txtContrasena.Text != pass)
                {
                    //getinco(3);
                    speech.SpeakAsyncCancelAll();
                    speech.SpeakAsync("Contraseña incorrecta, porfavor, ingresela de nuevo.");
                    MessageBox.Show("Contraseña incorrecta.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContrasena.Focus();
                }
            }
            //}

            if (e.Shift && e.KeyCode == Keys.O)
            {
                MessageBox.Show(pass);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
